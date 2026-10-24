using System;
using System.Drawing;
using System.Windows.Forms;
using FixFlow.Data;
using FixFlow.Models;
using FixFlow.Services;

namespace FixFlow.Forms
{
    public partial class RepairOrdersForm : Form
    {
        private readonly RepairService _repairService = new RepairService();
        private readonly InventoryService _inventoryService = new InventoryService();
        private readonly BillingService _billingService = new BillingService();
        private readonly PartRepository _partRepo = new PartRepository();
        private readonly CustomerRepository _customerRepo = new CustomerRepository();
        private readonly DeviceRepository _deviceRepo = new DeviceRepository();

        private int _currentOrderId;
        private RepairOrder _currentOrder;

        public RepairOrdersForm()
        {
            InitializeComponent();

            dgvOrderParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // R6
            dgvOrderParts.MultiSelect = false;
            dgvOrderParts.ReadOnly = true;
            dgvOrderParts.AllowUserToAddRows = false;
            numHoursWorked.Maximum = 1000;

            WireEvents();
            InitializePartsDropdown();
            SetNoOrderState();
        }

        public RepairOrdersForm(int orderId) : this()
        {
            LoadOrderDetails(orderId);
        }

        private void SetNoOrderState()
        {
            if (lblOrderTitle != null) lblOrderTitle.Text = "No repair order selected";
            if (lblHeaderStatus != null) lblHeaderStatus.Text = "Open an order from the Repair Board.";
            UpdateButtonStates();
        }

        private void NumHoursWorked_ValueChanged(object sender, EventArgs e)
        {
            RecalculateCosts();
        }

        private void WireEvents()
        {
            btnAdd.Click -= btnAdd_Click; btnAdd.Click += btnAdd_Click;
            btnRemovePart.Click -= btnRemovePart_Click; btnRemovePart.Click += btnRemovePart_Click;
            btnUpdateProgress.Click -= btnUpdateProgress_Click; btnUpdateProgress.Click += btnUpdateProgress_Click;
            btnReceivePayment.Click -= btnReceivePayment_Click; btnReceivePayment.Click += btnReceivePayment_Click;
            btnReleaseDevice.Click -= btnReleaseDevice_Click; btnReleaseDevice.Click += btnReleaseDevice_Click;
            numHoursWorked.ValueChanged -= NumHoursWorked_ValueChanged;
            numHoursWorked.ValueChanged += NumHoursWorked_ValueChanged;
        }

        private void UpdateButtonStates()
        {
            bool hasOrder = _currentOrder != null;
            RepairStatus status = hasOrder ? _currentOrder.Status : RepairStatus.Released;
            bool open = hasOrder && status != RepairStatus.Released;

            bool isTech = Session.IsLoggedIn && Session.CurrentUser.Role == UserRole.Technician;
            bool isReception = Session.IsLoggedIn && Session.CurrentUser.Role == UserRole.Receptionist;

            decimal balance = 0m;
            if (hasOrder)
            {
                try { balance = _billingService.GetSummary(_currentOrder).Balance; }
                catch (Exception ex) { System.Diagnostics.Debug.WriteLine(ex); }
            }

            // Work fields are locked for receptionists, released orders, and once the order is Ready for Pickup
            bool canEditWork = open && !isReception && status != RepairStatus.ReadyForPickup;
            txtDiagnosis.ReadOnly = !canEditWork;
            numHoursWorked.Enabled = canEditWork;
            btnAdd.Enabled = canEditWork;
            btnRemovePart.Enabled = canEditWork;
            numPartQty.Enabled = canEditWork;
            cmbAvailableParts.Enabled = canEditWork;

            btnUpdateProgress.Enabled = open && (status == RepairStatus.Diagnosing
                || status == RepairStatus.WaitingForParts || status == RepairStatus.Repairing);
            btnReceivePayment.Enabled = open && !isTech && balance > 0;
            btnReleaseDevice.Enabled = hasOrder && !isTech && status == RepairStatus.ReadyForPickup;
        }

        private void InitializePartsDropdown()
        {
            try
            {
                if (cmbAvailableParts != null)
                {
                    cmbAvailableParts.DataSource = _partRepo.GetAll();
                    cmbAvailableParts.DisplayMember = "Name";
                    cmbAvailableParts.ValueMember = "PartId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading Parts", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadOrderDetails(int orderId)
        {
            _currentOrderId = orderId;
            _currentOrder = _repairService.GetOrder(orderId);
            if (_currentOrder == null) return;

            // 1. Dynamic Header Labels
            if (lblOrderTitle != null)
                lblOrderTitle.Text = $"Repair Order RO-{orderId:D4}";

            if (lblHeaderStatus != null)
                lblHeaderStatus.Text = $"{_currentOrder.DateIn:MMM dd} · {_currentOrder.StatusString}";

            // 2. Customer & Device Sub-Section
            Device dev = _deviceRepo.GetById(_currentOrder.DeviceId);
            Customer cust = dev != null ? _customerRepo.GetById(dev.CustomerId) : null;

            string techName = "(Unassigned)";
            if (_currentOrder.TechnicianId > 0)
            {
                var techUser = new UserRepository().GetById(_currentOrder.TechnicianId);
                if (techUser != null) techName = techUser.Username;
            }

            if (lblValCustomer != null)
                lblValCustomer.Text = cust != null ? $"{cust.Name} · {cust.Contact}" : "Unknown Customer";

            if (lblValDevice != null)
                lblValDevice.Text = dev != null ? $"{dev.DeviceType} · {dev.Brand} {dev.Model}" : "Unknown Device";

            if (lblValReported != null)
                lblValReported.Text = _currentOrder.Problem;

            if (lblValAssigned != null)
                lblValAssigned.Text = techName;

            // 3. Form Window Title
            if (cust != null && dev != null)
            {
                this.Text = $"Repair Order #RO-{orderId:D4} - {cust.Name} ({dev.DeviceType} {dev.Brand})";
            }

            // 4. Input Fields & Details
            if (txtDiagnosis != null)
            {
                txtDiagnosis.Text = _currentOrder.Diagnosis;
            }

            if (numHoursWorked != null)
            {
                numHoursWorked.Value = _currentOrder.HoursWorked;
            }

            // 5. Update Stepper Visuals, Parts List, and Cost Summaries
            UpdateStepperVisuals(_currentOrder.Status);
            LoadOrderPartsGrid();
            RecalculateCosts();
            UpdateButtonStates();
        }

        private void UpdateStepperVisuals(RepairStatus currentStatus)
        {
            Color tealActive = Color.FromArgb(26, 188, 156);   // #1ABC9C (Teal)
            Color darkInactive = Color.FromArgb(45, 49, 57);   // #2D3139 (Dark Grey)
            Color textDark = Color.FromArgb(33, 37, 43);       // Dark text for active step
            Color textLight = Color.FromArgb(160, 168, 178);   // Muted text for inactive step

            int activeStep = 0;
            switch (currentStatus)
            {
                case RepairStatus.Received:
                    activeStep = 1;
                    break;
                case RepairStatus.Diagnosing:
                case RepairStatus.WaitingForParts:
                    activeStep = 2;
                    break;
                case RepairStatus.Repairing:
                    activeStep = 3;
                    break;
                case RepairStatus.ReadyForPickup:
                    activeStep = 4;
                    break;
                case RepairStatus.Released:
                    activeStep = 5;
                    break;
            }

            Action<Control, int> styleControl = (ctrl, stepNumber) =>
            {
                if (ctrl == null) return;
                bool isPassedOrCurrent = stepNumber <= activeStep;
                ctrl.BackColor = isPassedOrCurrent ? tealActive : darkInactive;
                ctrl.ForeColor = isPassedOrCurrent ? textDark : textLight;
            };

            styleControl(step1, 1);
            styleControl(step2, 2);
            styleControl(step3, 3);
            styleControl(step4, 4);
            styleControl(step5, 5);
        }

        private void LoadOrderPartsGrid()
        {
            if (dgvOrderParts != null && _currentOrder != null)
            {
                dgvOrderParts.DataSource = null;
                dgvOrderParts.DataSource = _currentOrder.Parts;
            }
        }

        private void RecalculateCosts()
        {
            if (_currentOrder == null) return;
            try
            {
                if (numHoursWorked != null)
                {
                    _currentOrder.HoursWorked = numHoursWorked.Value;
                }

                BillingSummary summary = _billingService.GetSummary(_currentOrder);

                if (lblLaborVal != null)
                    lblLaborVal.Text = $"₱{summary.Labor:N2}";

                if (lblPartsVal != null)
                    lblPartsVal.Text = $"₱{summary.PartsCost:N2}";

                if (lblTotalCost != null)
                    lblTotalCost.Text = $"₱{summary.TotalCost:N2}";

                if (lblPaidVal != null)
                    lblPaidVal.Text = $"₱{summary.AmountPaid:N2}"; // Updated from summary.PaidAmount

                if (lblBalance != null)
                    lblBalance.Text = $"₱{summary.Balance:N2}";
            }
            catch (Exception ex) { System.Diagnostics.Debug.WriteLine(ex); }
            UpdateButtonStates();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAvailableParts.SelectedItem is Part selectedPart)
                {
                    int qty = numPartQty != null ? (int)numPartQty.Value : 1;
                    _inventoryService.UsePart(_currentOrderId, selectedPart.PartId, qty);
                    LoadOrderDetails(_currentOrderId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Part Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemovePart_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrderParts.SelectedRows.Count > 0 && dgvOrderParts.SelectedRows[0].DataBoundItem is RepairPart rp)
                {
                    _inventoryService.ReturnPart(_currentOrderId, rp.PartId);
                    LoadOrderDetails(_currentOrderId);
                }
                else
                {
                    MessageBox.Show("Please select an allocated part to return.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Return Part Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateProgress_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentOrder == null) return;

                switch (_currentOrder.Status)
                {
                    case RepairStatus.Diagnosing:
                        _repairService.SubmitDiagnosis(_currentOrderId, txtDiagnosis.Text, numHoursWorked.Value);
                        MessageBox.Show("Diagnosis submitted. Order moved to 'Waiting for Parts'.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case RepairStatus.WaitingForParts:
                        _repairService.ProceedToRepair(_currentOrderId);
                        MessageBox.Show("Order moved to 'Repairing'.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case RepairStatus.Repairing:
                        _repairService.UpdateDetails(_currentOrderId, txtDiagnosis.Text, numHoursWorked.Value);
                        MessageBox.Show("Repair details and hours saved.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        MessageBox.Show("There is nothing to save at this stage.", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                }

                LoadOrderDetails(_currentOrderId);
                if (Modal) Close();   // only close when opened with ShowDialog
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Action Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReceivePayment_Click(object sender, EventArgs e)
        {
            try
            {
                // Administrators may have unsaved hours on screen: save them so the balance matches the database
                if (Session.CurrentUser.Role == UserRole.Administrator
                    && _currentOrder.Status != RepairStatus.Released)
                {
                    _repairService.UpdateDetails(_currentOrderId, txtDiagnosis.Text, numHoursWorked.Value);
                }

                // Always bill from the saved order
                RepairOrder fresh = _repairService.GetOrder(_currentOrderId);
                BillingSummary summary = _billingService.GetSummary(fresh);
                if (summary.Balance <= 0)
                {
                    MessageBox.Show("This repair order is already paid in full.", "Paid in Full",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Total Balance Due: ₱{summary.Balance:N2}\nEnter cash amount received:",
                    "Receive Cash Payment", summary.Balance.ToString("0.00"));

                if (string.IsNullOrWhiteSpace(input)) return;   // cancelled
                if (!decimal.TryParse(input, out decimal cashReceived) || cashReceived <= 0)
                {
                    MessageBox.Show("Enter a valid amount greater than zero.", "Invalid Amount",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cashReceived < summary.Balance)
                {
                    MessageBox.Show("Entered cash amount is less than the total balance due.",
                        "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _billingService.RecordPayment(_currentOrderId, summary.Balance);
                string message = $"Payment recorded!\nChange: ₱{cashReceived - summary.Balance:N2}";

                // The step that never ran: move Repairing -> Ready for Pickup once fully paid
                if (fresh.Status == RepairStatus.Repairing)
                {
                    try
                    {
                        _repairService.MoveOrder(_currentOrderId, RepairStatus.ReadyForPickup);
                        message += "\nThe order is now Ready for Pickup.";
                    }
                    catch (Exception moveEx)
                    {
                        message += "\nPayment was saved, but the order could not move to Ready for Pickup:\n" + moveEx.Message;
                    }
                }

                MessageBox.Show(message, "Payment Received", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadOrderDetails(_currentOrderId);   // stepper updates and Release Device becomes enabled
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReleaseDevice_Click(object sender, EventArgs e)
        {
            try
            {
                _repairService.MoveOrder(_currentOrderId, RepairStatus.Released);
                MessageBox.Show("Device successfully released to customer.", "Device Released", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadOrderDetails(_currentOrderId);
                if (Modal) Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Release Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}