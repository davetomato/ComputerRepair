using FixFlow.Data;
using FixFlow.Models;
using FixFlow.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FixFlow.Forms
{
    public partial class CustomersDevicesForm : Form
    {
        private readonly CustomerService _customerService = new CustomerService();
        private readonly DeviceService _deviceService = new DeviceService();
        private readonly RepairService _repairService = new RepairService();

        private int _selectedCustomerId = 0;

        public CustomersDevicesForm()
        {
            InitializeComponent();
            this.Load += CustomersDevicesForm_Load;
        }

        private void CustomersDevicesForm_Load(object sender, EventArgs e)
        {
            InitializeDeviceTypeDropdown();
            ApplyThemeAndStyling();
            LoadCustomerDeviceGrid();

            // Apply smooth rounded corners to cards and buttons
            SetControlRoundedRegion(pnlLeftCard, 12);
            SetControlRoundedRegion(pnlRightCard, 12);
            SetControlRoundedRegion(btnRegisterDevice, 8);
            SetControlRoundedRegion(btnCancel, 8);
            SetControlRoundedRegion(btnDeleteCustomer, 8);

            // Wire up events
            if (txtModel != null)
            {
                txtModel.TextChanged += TxtModel_TextChanged;
            }

            if (txtSearch != null)
            {
                txtSearch.TextChanged += TxtSearch_TextChanged;
            }

            if (btnRegisterDevice != null)
            {
                btnRegisterDevice.Click += btnRegisterDevice_Click;
            }

            if (btnCancel != null)
            {
                btnCancel.Click += btnCancel_Click;
            }

            if (btnDeleteCustomer != null)
            {
                btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            }

            if (dgvData != null)
            {
                dgvData.CellClick += dgvData_CellClick;
                dgvData.KeyDown += dgvData_KeyDown;
            }
        }

        private void InitializeDeviceTypeDropdown()
        {
            try
            {
                if (cmbDeviceType != null)
                {
                    cmbDeviceType.Items.Clear();
                    cmbDeviceType.Items.AddRange(new string[] { "Laptop", "Desktop", "Tablet", "Phone", "Console", "Other" });
                    cmbDeviceType.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading device types: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ApplyThemeAndStyling()
        {
            this.BackColor = Color.FromArgb(33, 37, 43);

            if (dgvData != null)
            {
                dgvData.BackgroundColor = Color.FromArgb(33, 37, 43);
                dgvData.BorderStyle = BorderStyle.None;
                dgvData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgvData.RowHeadersVisible = false;
                dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvData.ReadOnly = true;

                dgvData.EnableHeadersVisualStyles = false;
                dgvData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 44, 52);
                dgvData.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(160, 168, 178);
                dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                dgvData.ColumnHeadersHeight = 40;

                dgvData.DefaultCellStyle.BackColor = Color.FromArgb(33, 37, 43);
                dgvData.DefaultCellStyle.ForeColor = Color.FromArgb(220, 225, 230);
                dgvData.DefaultCellStyle.SelectionBackColor = Color.FromArgb(48, 54, 64);
                dgvData.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvData.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                dgvData.RowTemplate.Height = 45;
            }
        }

        private void SetControlRoundedRegion(Control control, int radius)
        {
            if (control == null || control.Width == 0 || control.Height == 0) return;

            using (GraphicsPath path = new GraphicsPath())
            {
                int diameter = radius * 2;
                Rectangle rect = new Rectangle(0, 0, control.Width, control.Height);

                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                control.Region = new Region(path);
            }
        }

        private void LoadCustomerDeviceGrid(string searchFilter = "")
        {
            try
            {
                var customers = string.IsNullOrWhiteSpace(searchFilter)
                    ? _customerService.GetAll()
                    : _customerService.Search(searchFilter);

                DataTable dt = new DataTable();
                dt.Columns.Add("Customer");
                dt.Columns.Add("Contact No.");
                dt.Columns.Add("Device");
                dt.Columns.Add("Brand / Model");
                dt.Columns.Add("Serial No.");
                dt.Columns.Add("Part to Repair");

                DeviceRepository deviceRepo = new DeviceRepository();
                RepairOrderRepository orderRepo = new RepairOrderRepository();

                foreach (var c in customers)
                {
                    var devices = deviceRepo.GetByCustomer(c.CustomerId);
                    if (devices.Count == 0)
                    {
                        dt.Rows.Add(c.Name, c.Contact, "None", "N/A", "N/A", "N/A");
                    }
                    else
                    {
                        foreach (var d in devices)
                        {
                            var orders = orderRepo.GetByDevice(d.DeviceId);
                            string problem = orders.Count > 0 ? orders[0].Problem : "Standard Repair";

                            dt.Rows.Add(
                                c.Name,
                                c.Contact,
                                d.DeviceType,
                                $"{d.Brand} {d.Model}".Trim(),
                                string.IsNullOrEmpty(d.SerialNo) ? "N/A" : d.SerialNo,
                                problem
                            );
                        }
                    }
                }

                dgvData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data grid: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtModel_TextChanged(object sender, EventArgs e)
        {
            if (txtModel != null && txtSerialNo != null)
            {
                string modelText = txtModel.Text.Trim();
                if (!string.IsNullOrEmpty(modelText))
                {
                    int randomCode = new Random().Next(1000, 9999);
                    txtSerialNo.Text = $"{modelText.ToUpper().Replace(" ", "")}-{randomCode}";
                }
                else
                {
                    txtSerialNo.Clear();
                }
            }
        }

        private void btnRegisterDevice_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName?.Text.Trim() ?? "";
            string lastName = txtLastName?.Text.Trim() ?? "";
            string contact = txtContact?.Text.Trim() ?? "";
            string address = txtAddress?.Text.Trim() ?? "";

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Please fill in First Name, Last Name, and Contact Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string deviceType = cmbDeviceType?.SelectedItem?.ToString() ?? cmbDeviceType?.Text.Trim() ?? "Laptop";
            string brand = txtBrand?.Text.Trim() ?? "";
            string model = txtModel?.Text.Trim() ?? "";
            string serialNo = txtSerialNo?.Text.Trim() ?? "";
            string partToRepair = txtPartToRepair?.Text.Trim() ?? "General Repair";

            if (string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(model))
            {
                MessageBox.Show("Please enter both Brand and Model.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string fullName = $"{firstName} {lastName}";
                Customer newCustomer = _customerService.Add(fullName, contact, address);

                if (newCustomer == null || newCustomer.CustomerId <= 0)
                {
                    throw new Exception("Failed to create customer record.");
                }

                Device newDevice = _deviceService.Add(newCustomer.CustomerId, deviceType, brand, model, serialNo);
                _repairService.CreateOrder(newDevice.DeviceId, "Hardware Repair", partToRepair);

                MessageBox.Show("Customer and device registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear fields
                txtFirstName.Clear();
                txtLastName.Clear();
                txtContact.Clear();
                txtAddress.Clear();
                txtBrand.Clear();
                txtModel.Clear();
                txtSerialNo.Clear();
                if (txtPartToRepair != null) txtPartToRepair.Clear();

                LoadCustomerDeviceGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during registration: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomerDeviceGrid(txtSearch.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtBrand.Clear();
            txtModel.Clear();
            txtSerialNo.Clear();
            if (txtPartToRepair != null) txtPartToRepair.Clear();
            if (cmbDeviceType != null) cmbDeviceType.SelectedIndex = 0;
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            PerformCustomerDeletion();
        }

        private void dgvData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
                PerformCustomerDeletion();
            }
        }

        private DateTime _lastDeleteAttempt = DateTime.MinValue;

        private bool _isDeleting = false;
        private void PerformCustomerDeletion()
        {
            // Prevent duplicate triggers if called within 1 second
            if ((DateTime.Now - _lastDeleteAttempt).TotalMilliseconds < 1000)
            {
                return;
            }
            _lastDeleteAttempt = DateTime.Now;

            if (_selectedCustomerId == 0)
            {
                MessageBox.Show("Please select a customer from the grid to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this customer? (Note: Customers with active devices or repair orders cannot be deleted).",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _customerService.Delete(_selectedCustomerId);

                    MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _selectedCustomerId = 0;
                    LoadCustomerDeviceGrid();
                }
                catch (Exception ex)
                {
                    // This is your safe database constraint block (e.g. active repair/device stage)
                    MessageBox.Show(ex.Message, "Deletion Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvData.Rows[e.RowIndex].Cells["Customer"].Value != null)
            {
                string customerName = dgvData.Rows[e.RowIndex].Cells["Customer"].Value.ToString();

                var customers = _customerService.GetAll();
                var matchedCustomer = customers.Find(c => c.Name.Equals(customerName, StringComparison.OrdinalIgnoreCase));

                if (matchedCustomer != null)
                {
                    _selectedCustomerId = matchedCustomer.CustomerId;
                }
            }
        }
    }
}