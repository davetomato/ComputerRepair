using System;
using System.Data;
using System.Windows.Forms;
using FixFlow.Models;
using FixFlow.Services;
using FixFlow.UI;

namespace FixFlow.Forms
{
    public partial class UsersForm : Form
    {
        private readonly UserService _userService = new UserService();
        private readonly ServiceRateService _rateService = new ServiceRateService();
        private string _selectedService = null;

        public UsersForm()
        {
            InitializeComponent();

            Theme.StyleGrid(dgvUsers);
            Theme.StyleGrid(dgvRates);
            Theme.StylePrimary(btnAddUser);
            Theme.StylePrimary(btnSaveRate);
            Theme.StyleSecondary(btnDeleteUser, Theme.Danger);

            btnAddUser.Click += btnAddUser_Click;
            btnDeleteUser.Click += btnDeleteUser_Click;
            btnSaveRate.Click += btnSaveRate_Click;
            dgvRates.CellClick += dgvRates_CellClick;
            Load += (s, e) => { LoadUsers(); LoadRates(); };
        }

        // ---------- Users ----------
        private void LoadUsers()
        {
            try
            {
                DataTable t = new DataTable();
                t.Columns.Add("UserId", typeof(int));
                t.Columns.Add("Username", typeof(string));
                t.Columns.Add("Role", typeof(string));
                foreach (User u in _userService.GetAll())
                    t.Rows.Add(u.UserId, u.Username, u.Role.ToString());

                dgvUsers.DataSource = t;
                dgvUsers.Columns["UserId"].Visible = false;
                dgvUsers.Columns["Username"].HeaderText = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (UserDialog dlg = new UserDialog())
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                    LoadUsers();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvUsers.CurrentRow;
            if (row == null)
            {
                MessageBox.Show("Select a user first.", "Selection required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(row.Cells["UserId"].Value);
            string name = row.Cells["Username"].Value.ToString();
            if (MessageBox.Show("Delete user '" + name + "'?", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                _userService.Delete(id);   // blocks deleting yourself / the last administrator
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deletion blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ---------- Service rates ----------
        private void LoadRates()
        {
            try
            {
                DataTable t = new DataTable();
                t.Columns.Add("Name", typeof(string));
                t.Columns.Add("Rate", typeof(decimal));
                t.Columns.Add("Billing", typeof(string));
                foreach (ServiceType s in _rateService.GetAll())
                    t.Rows.Add(s.Name, s.Rate, s.Name == "Hardware Repair" ? "Per hour" : "Flat fee");

                dgvRates.DataSource = t;
                dgvRates.Columns["Name"].HeaderText = "Service";
                dgvRates.Columns["Rate"].HeaderText = "Labor fee";
                dgvRates.Columns["Rate"].DefaultCellStyle.Format = "₱#,##0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Service rates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvRates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvRates.Rows[e.RowIndex];
            _selectedService = row.Cells["Name"].Value.ToString();
            txtRate.Text = Convert.ToDecimal(row.Cells["Rate"].Value).ToString("0.00");
            lblSelectedRate.Text = "Editing: " + _selectedService + " (" + row.Cells["Billing"].Value + ")";
        }

        private void btnSaveRate_Click(object sender, EventArgs e)
        {
            if (_selectedService == null)
            {
                MessageBox.Show("Select a service from the list first.", "Selection required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal rate;
            if (!decimal.TryParse(txtRate.Text.Trim(), out rate) || rate < 0)
            {
                MessageBox.Show("Enter a valid rate (0 or more).", "Check input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _rateService.UpdateRate(_selectedService, rate);
                LoadRates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}