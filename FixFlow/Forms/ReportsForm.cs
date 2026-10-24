using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FixFlow.Services;
using FixFlow.UI;

namespace FixFlow.Forms
{
    public partial class ReportsForm : Form
    {
        private readonly ReportService _reports = new ReportService();
        private Button[] _chips;
        private string _current = "Repairs";
        private DateTime _from, _to;
        private bool _allTime;

        public ReportsForm()
        {
            InitializeComponent();

            Theme.StyleGrid(dgvReport);
            Theme.StyleCombo(cmbRange);

            _chips = new[] { btnRepairs, btnIncome, btnParts, btnWorkload, btnUnpaid };
            btnRepairs.Tag = "Repairs";
            btnIncome.Tag = "Income";
            btnParts.Tag = "Parts";
            btnWorkload.Tag = "Workload";
            btnUnpaid.Tag = "Unpaid";
            foreach (Button chip in _chips)
                chip.Click += Chip_Click;

            Load += ReportsForm_Load;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            Func<DateTime, string> span = a => a.ToString("MMM d") + " – " + today.ToString("MMM d, yyyy");

            cmbRange.Items.Add("This month  (" + span(new DateTime(today.Year, today.Month, 1)) + ")");
            cmbRange.Items.Add("Last 30 days  (" + span(today.AddDays(-29)) + ")");
            cmbRange.Items.Add("This year  (" + span(new DateTime(today.Year, 1, 1)) + ")");
            cmbRange.Items.Add("All time");
            cmbRange.SelectedIndex = 0;
            cmbRange.SelectedIndexChanged += (s, a) => { ApplyRange(); RunReport(); };

            ApplyRange();
            RunReport();
        }

        private void ApplyRange()
        {
            DateTime today = DateTime.Today;
            _allTime = false;
            switch (cmbRange.SelectedIndex)
            {
                case 0: _from = new DateTime(today.Year, today.Month, 1); break;
                case 1: _from = today.AddDays(-29); break;
                case 2: _from = new DateTime(today.Year, 1, 1); break;
                default: _allTime = true; _from = new DateTime(2000, 1, 1); break;
            }
            _to = today;
        }

        private void Chip_Click(object sender, EventArgs e)
        {
            _current = (string)((Button)sender).Tag;
            RunReport();
        }

        private void RunReport()
        {
            try
            {
                DataTable table;
                string title;
                bool money = false;
                Func<DataRow, string> label;
                Func<DataRow, decimal> value;

                switch (_current)
                {
                    case "Income":
                        table = _allTime ? _reports.IncomePerMonth() : _reports.IncomePerMonth(_from, _to);
                        title = "INCOME PER MONTH";
                        money = true;
                        label = r => new DateTime(Convert.ToInt32(r["PaymentYear"]),
                                                  Convert.ToInt32(r["PaymentMonth"]), 1).ToString("MMM yyyy");
                        value = r => Convert.ToDecimal(r["TotalIncome"]);
                        break;
                    case "Parts":
                        table = _allTime ? _reports.PartsUsage() : _reports.PartsUsage(_from, _to);
                        title = "PARTS USED (QUANTITY)";
                        label = r => r["Name"].ToString();
                        value = r => Convert.ToDecimal(r["QuantityUsed"]);
                        break;
                    case "Workload":
                        table = _reports.TechnicianWorkload();
                        title = "ACTIVE REPAIRS PER TECHNICIAN";
                        label = r => r["Technician"].ToString();
                        value = r => Convert.ToDecimal(r["ActiveRepairs"]);
                        break;
                    case "Unpaid":
                        table = _reports.UnpaidBalances();
                        title = "UNPAID BALANCES";
                        money = true;
                        label = r => "RO-" + Convert.ToInt32(r["OrderId"]).ToString("D4");
                        value = r => Convert.ToDecimal(r["Balance"]);
                        break;
                    default:
                        table = _allTime ? _reports.RepairsPerStatus() : _reports.RepairsPerStatus(_from, _to);
                        title = "REPAIRS PER STATUS";
                        label = r => r["Status"].ToString();
                        value = r => Convert.ToDecimal(r["Repairs"]);
                        break;
                }

                // Table
                dgvReport.DataSource = table;
                foreach (DataGridViewColumn col in dgvReport.Columns)
                {
                    switch (col.Name)
                    {
                        case "TotalIncome":
                        case "PartsRevenue":
                        case "Labor":
                        case "PartsCost":
                        case "TotalCost":
                        case "AmountPaid":
                        case "Balance":
                            col.DefaultCellStyle.Format = "₱#,##0.00";
                            break;
                    }
                }

                // Chart (max 8 bars)
                List<KeyValuePair<string, decimal>> data = new List<KeyValuePair<string, decimal>>();
                foreach (DataRow row in table.Rows)
                    data.Add(new KeyValuePair<string, decimal>(label(row), value(row)));
                const int maxBars = 8;
                if (data.Count > maxBars)
                    data = _current == "Income"
                        ? data.GetRange(data.Count - maxBars, maxBars)
                        : data.GetRange(0, maxBars);

                barChart.IsCurrency = money;
                barChart.SetData(data);
                lblChartTitle.Text = title;

                // The date range only applies to three of the reports
                cmbRange.Enabled = _current == "Repairs" || _current == "Income" || _current == "Parts";

                foreach (Button chip in _chips)
                    Theme.StyleChip(chip, (string)chip.Tag == _current);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Report error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}