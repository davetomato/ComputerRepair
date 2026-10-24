using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FixFlow.Models;
using FixFlow.Services;
using FixFlow.Data;

namespace FixFlow.Forms
{
    public partial class RepairBoardForm : Form
    {
        private readonly RepairService _repairService = new RepairService();
        private readonly BillingService _billingService = new BillingService();
        private readonly UserService _userService = new UserService();
        private readonly CustomerRepository _customerRepo = new CustomerRepository();
        private readonly DeviceRepository _deviceRepo = new DeviceRepository();

        public RepairBoardForm()
        {
            InitializeComponent();
            this.Load += RepairBoardForm_Load;
        }

        private void RepairBoardForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadBoardData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading board: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadBoardData()
        {
            // Clear existing controls inside each designer-created panel except headers
            ClearPanelContent(pnlReceived, "Received", out Label lblCountRec);
            ClearPanelContent(pnlDiagnosing, "Diagnosing", out Label lblCountDiag);
            ClearPanelContent(pnlWaitingForParts, "Waiting for Parts", out Label lblCountWait);
            ClearPanelContent(pnlRepairing, "Repairing", out Label lblCountRep);
            ClearPanelContent(pnlReadyForPickup, "Ready for Pickup", out Label lblCountReady);
            ClearPanelContent(pnlReleased, "Released", out Label lblCountRel);

            var boardDict = _repairService.GetBoard();
            var technicians = _userService.GetTechnicians();

            int countRec = 0, countDiag = 0, countWait = 0, countRep = 0, countReady = 0, countRel = 0;

            foreach (var kvp in boardDict)
            {
                RepairStatus status = kvp.Key;
                foreach (var order in kvp.Value)
                {
                    Control card = CreateOrderCard(order, technicians);
                    switch (status)
                    {
                        case RepairStatus.Received:
                            pnlReceived.Controls.Add(card);
                            countRec++;
                            break;
                        case RepairStatus.Diagnosing:
                            pnlDiagnosing.Controls.Add(card);
                            countDiag++;
                            break;
                        case RepairStatus.WaitingForParts:
                            pnlWaitingForParts.Controls.Add(card);
                            countWait++;
                            break;
                        case RepairStatus.Repairing:
                            pnlRepairing.Controls.Add(card);
                            countRep++;
                            break;
                        case RepairStatus.ReadyForPickup:
                            pnlReadyForPickup.Controls.Add(card);
                            countReady++;
                            break;
                        case RepairStatus.Released:
                            pnlReleased.Controls.Add(card);
                            countRel++;
                            break;
                    }
                }
            }

            lblCountRec.Text = countRec.ToString();
            lblCountDiag.Text = countDiag.ToString();
            lblCountWait.Text = countWait.ToString();
            lblCountRep.Text = countRep.ToString();
            lblCountReady.Text = countReady.ToString();
            lblCountRel.Text = countRel.ToString();
        }

        private void ClearPanelContent(FlowLayoutPanel panel, string title, out Label countLabel)
        {
            panel.Controls.Clear();

            Panel header = new Panel();
            header.Width = panel.ClientSize.Width - 10;
            header.Height = 40;
            header.BackColor = Color.FromArgb(40, 44, 52); // Dark charcoal card header (#282C34)

            Label lblHeaderTitle = new Label();
            lblHeaderTitle.Text = title;
            lblHeaderTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(10, 10);
            lblHeaderTitle.AutoSize = true;

            countLabel = new Label();
            countLabel.Text = "0";
            countLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            countLabel.ForeColor = Color.FromArgb(160, 168, 178);
            countLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            countLabel.Location = new Point(header.Width - 35, 11);
            countLabel.AutoSize = true;

            header.Controls.Add(lblHeaderTitle);
            header.Controls.Add(countLabel);
            panel.Controls.Add(header);
        }

        private Control CreateOrderCard(RepairOrder order, List<User> technicians)
        {
            Panel card = new Panel();
            card.Width = pnlReceived.ClientSize.Width - 12;
            card.Height = 175;
            card.BackColor = Color.FromArgb(40, 44, 52); // Card background (#282C34)
            card.Margin = new Padding(0, 5, 0, 5);

            Device device = _deviceRepo.GetById(order.DeviceId);
            Customer customer = device != null ? _customerRepo.GetById(device.CustomerId) : null;
            BillingSummary summary = _billingService.GetSummary(order);

            // Order ID Label
            Label lblId = new Label();
            lblId.Text = $"RO-{order.OrderId:D4}";
            lblId.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblId.ForeColor = Color.White;
            lblId.Location = new Point(12, 10);
            lblId.AutoSize = true;
            card.Controls.Add(lblId);

            // Balance / Payment Status
            Label lblBalance = new Label();
            lblBalance.Text = summary.Balance > 0 ? $"₱{summary.Balance:N0} due" : "Paid in full";
            lblBalance.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblBalance.ForeColor = summary.Balance > 0 ? Color.FromArgb(231, 76, 60) : Color.FromArgb(46, 204, 113);
            lblBalance.TextAlign = ContentAlignment.TopRight;
            lblBalance.Location = new Point(card.Width - 95, 12);
            lblBalance.Size = new Size(85, 18);
            card.Controls.Add(lblBalance);

            // Device Info
            Label lblDevice = new Label();
            lblDevice.Text = device != null ? $"{device.DeviceType} · {device.Brand} {device.Model}" : "Device Info";
            lblDevice.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
            lblDevice.ForeColor = Color.FromArgb(200, 205, 210);
            lblDevice.Location = new Point(12, 32);
            lblDevice.MaximumSize = new Size(card.Width - 24, 20);
            lblDevice.AutoSize = true;
            card.Controls.Add(lblDevice);

            // Customer & Problem Info
            Label lblCustProb = new Label();
            lblCustProb.Text = customer != null ? $"{customer.Name} · {order.Problem}" : order.Problem;
            lblCustProb.Font = new Font("Segoe UI", 8F, FontStyle.Regular);
            lblCustProb.ForeColor = Color.FromArgb(160, 168, 178);
            lblCustProb.Location = new Point(12, 54);
            lblCustProb.MaximumSize = new Size(card.Width - 24, 32);
            lblCustProb.AutoSize = true;
            card.Controls.Add(lblCustProb);

            // Technician Assignment ComboBox
            ComboBox cmbTech = new ComboBox();
            cmbTech.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTech.BackColor = Color.FromArgb(33, 37, 43);
            cmbTech.ForeColor = Color.White;
            cmbTech.Font = new Font("Segoe UI", 8F);
            cmbTech.Location = new Point(12, 92);
            cmbTech.Size = new Size(110, 24);
            cmbTech.Items.Add("(Unassigned)");
            foreach (var t in technicians)
            {
                cmbTech.Items.Add(t);
            }

            if (order.TechnicianId > 0)
            {
                var assigned = technicians.Find(t => t.UserId == order.TechnicianId);
                if (assigned != null) cmbTech.SelectedItem = assigned;
            }
            else
            {
                cmbTech.SelectedIndex = 0;
            }

            cmbTech.SelectedIndexChanged += (s, e) =>
            {
                try
                {
                    if (cmbTech.SelectedItem is User selectedTech)
                    {
                        _repairService.AssignTechnician(order.OrderId, selectedTech.UserId);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Assignment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
            card.Controls.Add(cmbTech);

            // Action Button for Next Workflow Stage
            Button btnAction = new Button();
            btnAction.FlatStyle = FlatStyle.Flat;
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.BackColor = Color.FromArgb(26, 188, 156); // Teal accent (#1ABC9C)
            btnAction.ForeColor = Color.FromArgb(33, 37, 43);
            btnAction.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnAction.Cursor = Cursors.Hand;
            btnAction.Location = new Point(12, 128);
            btnAction.Size = new Size(card.Width - 24, 30);

            ConfigureActionButton(btnAction, order);
            card.Controls.Add(btnAction);

            return card;
        }

        private void ConfigureActionButton(Button btn, RepairOrder order)
        {
            switch (order.Status)
            {
                case RepairStatus.Received:
                    btn.Text = "Start Diagnosis →";
                    btn.Click += (s, e) => {
                        try
                        {
                            _repairService.StartDiagnosis(order.OrderId);
                            RepairOrdersForm form = new RepairOrdersForm(order.OrderId);
                            form.ShowDialog();
                            LoadBoardData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Action Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    };
                    break;
                case RepairStatus.Diagnosing:
                    btn.Text = "Submit Diagnosis →";
                    btn.Click += (s, e) => {
                        RepairOrdersForm form = new RepairOrdersForm(order.OrderId);
                        form.ShowDialog();
                        LoadBoardData();
                    };
                    break;
                case RepairStatus.WaitingForParts:
                    btn.Text = "Select Parts →";
                    btn.Click += (s, e) => {
                        RepairOrdersForm form = new RepairOrdersForm(order.OrderId);
                        form.ShowDialog();
                        LoadBoardData();
                    };
                    break;
                case RepairStatus.Repairing:
                    btn.Text = "Record Payment →";
                    btn.Click += (s, e) => {
                        RepairOrdersForm form = new RepairOrdersForm(order.OrderId);
                        form.ShowDialog();
                        LoadBoardData();
                    };
                    break;
                case RepairStatus.ReadyForPickup:
                    btn.Text = "Release Device →";
                    btn.Click += (s, e) => {
                        try
                        {
                            _repairService.MoveOrder(order.OrderId, RepairStatus.Released);
                            LoadBoardData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Release Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    };
                    break;
                case RepairStatus.Released:
                    btn.Text = "Completed";
                    btn.Enabled = false;
                    break;
            }
        }

        private void AdvanceStatus(int orderId, RepairStatus nextStatus)
        {
            try
            {
                _repairService.MoveOrder(orderId, nextStatus);
                LoadBoardData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Workflow Action Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}