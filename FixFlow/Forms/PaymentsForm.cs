using System;
using System.Data;
using System.Windows.Forms;
using FixFlow.Services;
using FixFlow.UI;

namespace FixFlow.Forms
{
    public partial class PaymentsForm : Form
    {
        private readonly BillingService _billing = new BillingService();
        private DataTable _data;
        private string _filter = "All";

        public PaymentsForm()
        {
            InitializeComponent();

            Theme.StyleGrid(dgvOrders);
            Theme.StylePrimary(btnReceive);

            btnAll.Tag = "All";
            btnUnpaid.Tag = "Unpaid";
            btnPaid.Tag = "Paid";
            foreach (Button b in new[] { btnAll, btnUnpaid, btnPaid })
                b.Click += FilterChip_Click;

            btnReceive.Click += btnReceive_Click;
            dgvOrders.CellPainting += (s, e) => Theme.PaintBadgeCell(dgvOrders, e, "Status");
            dgvOrders.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) btnReceive_Click(s, e); };
            Load += (s, e) => LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                DataTable source = _billing.GetOrderBalances();

                _data = new DataTable();
                _data.Columns.Add("OrderId", typeof(int));
                _data.Columns.Add("Order", typeof(string));
                _data.Columns.Add("Customer", typeof(string));
                _data.Columns.Add("Total", typeof(decimal));
                _data.Columns.Add("Paid", typeof(decimal));
                _data.Columns.Add("Balance", typeof(decimal));
                _data.Columns.Add("Status", typeof(string));

                decimal unpaidTotal = 0m;
                int withBalance = 0;

                foreach (DataRow r in source.Rows)
                {
                    int id = Convert.ToInt32(r["OrderId"]);
                    decimal total = Convert.ToDecimal(r["TotalCost"]);
                    decimal paid = Convert.ToDecimal(r["AmountPaid"]);
                    decimal balance = Convert.ToDecimal(r["Balance"]);
                    string status = balance <= 0 ? "Paid" : (paid <= 0 ? "Unpaid" : "Partial");

                    if (balance > 0) { unpaidTotal += balance; withBalance++; }
                    _data.Rows.Add(id, "RO-" + id.ToString("D4"), r["Customer"].ToString(),
                                   total, paid, balance, status);
                }

                dgvOrders.DataSource = _data.DefaultView;
                dgvOrders.Columns["OrderId"].Visible = false;
                foreach (string col in new[] { "Total", "Paid", "Balance" })
                    dgvOrders.Columns[col].DefaultCellStyle.Format = "₱#,##0.00";

                lblCollected.Text = _billing.GetCollectedToday().ToString("₱#,##0.00");
                lblUnpaid.Text = unpaidTotal.ToString("₱#,##0.00");
                lblCount.Text = withBalance.ToString();

                ApplyFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Payments", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FilterChip_Click(object sender, EventArgs e)
        {
            _filter = (string)((Button)sender).Tag;
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            foreach (Button b in new[] { btnAll, btnUnpaid, btnPaid })
                Theme.StyleChip(b, (string)b.Tag == _filter);

            if (_data == null) return;
            _data.DefaultView.RowFilter =
                _filter == "Unpaid" ? "Balance > 0" :
                _filter == "Paid" ? "Balance <= 0" : "";
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvOrders.CurrentRow;
            if (row == null)
            {
                MessageBox.Show("Select an order from the list first.", "Selection required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int orderId = Convert.ToInt32(row.Cells["OrderId"].Value);
            decimal balance = Convert.ToDecimal(row.Cells["Balance"].Value);
            if (balance <= 0)
            {
                MessageBox.Show("This order is already fully paid.", "Payments",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (PaymentDialog dlg = new PaymentDialog(orderId, row.Cells["Customer"].Value.ToString(), balance))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                    LoadOrders();
            }
        }
    }
}