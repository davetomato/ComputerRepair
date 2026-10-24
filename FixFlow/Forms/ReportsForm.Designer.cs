namespace FixFlow.Forms
{
    partial class ReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            cmbRange = new ComboBox();
            lblTitle = new Label();
            pnlHeaderLine = new Panel();
            pnlBody = new Panel();
            tblReports = new TableLayoutPanel();
            pnlChips = new Panel();
            btnUnpaid = new Button();
            btnWorkload = new Button();
            btnParts = new Button();
            btnIncome = new Button();
            btnRepairs = new Button();
            cardChart = new FixFlow.UI.CardPanel();
            barChart = new FixFlow.UI.BarChart();
            lblChartTitle = new Label();
            cardTable = new FixFlow.UI.CardPanel();
            dgvReport = new DataGridView();
            lblTableTitle = new Label();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            tblReports.SuspendLayout();
            pnlChips.SuspendLayout();
            cardChart.SuspendLayout();
            cardTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(40, 44, 52);
            pnlHeader.Controls.Add(cmbRange);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(pnlHeaderLine);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1012, 64);
            pnlHeader.TabIndex = 2;
            // 
            // cmbRange
            // 
            cmbRange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbRange.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRange.FormattingEnabled = true;
            cmbRange.Location = new Point(716, 17);
            cmbRange.Name = "cmbRange";
            cmbRange.Size = new Size(290, 28);
            cmbRange.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(118, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Reports";
            // 
            // pnlHeaderLine
            // 
            pnlHeaderLine.BackColor = Color.FromArgb(55, 61, 72);
            pnlHeaderLine.Dock = DockStyle.Bottom;
            pnlHeaderLine.Location = new Point(0, 63);
            pnlHeaderLine.Name = "pnlHeaderLine";
            pnlHeaderLine.Size = new Size(1012, 1);
            pnlHeaderLine.TabIndex = 0;
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(tblReports);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 64);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(24);
            pnlBody.Size = new Size(1012, 559);
            pnlBody.TabIndex = 3;
            // 
            // tblReports
            // 
            tblReports.ColumnCount = 2;
            tblReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tblReports.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tblReports.Controls.Add(pnlChips, 0, 0);
            tblReports.Controls.Add(cardChart, 0, 1);
            tblReports.Controls.Add(cardTable, 1, 1);
            tblReports.Dock = DockStyle.Fill;
            tblReports.Location = new Point(24, 24);
            tblReports.Name = "tblReports";
            tblReports.RowCount = 2;
            tblReports.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tblReports.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblReports.Size = new Size(964, 511);
            tblReports.TabIndex = 0;
            // 
            // pnlChips
            // 
            tblReports.SetColumnSpan(pnlChips, 2);
            pnlChips.Controls.Add(btnUnpaid);
            pnlChips.Controls.Add(btnWorkload);
            pnlChips.Controls.Add(btnParts);
            pnlChips.Controls.Add(btnIncome);
            pnlChips.Controls.Add(btnRepairs);
            pnlChips.Dock = DockStyle.Fill;
            pnlChips.Location = new Point(0, 0);
            pnlChips.Margin = new Padding(0);
            pnlChips.Name = "pnlChips";
            pnlChips.Size = new Size(964, 44);
            pnlChips.TabIndex = 0;
            // 
            // btnUnpaid
            // 
            btnUnpaid.Location = new Point(472, 0);
            btnUnpaid.Name = "btnUnpaid";
            btnUnpaid.Size = new Size(140, 30);
            btnUnpaid.TabIndex = 4;
            btnUnpaid.Text = "Unpaid Balances";
            btnUnpaid.UseVisualStyleBackColor = true;
            // 
            // btnWorkload
            // 
            btnWorkload.Location = new Point(304, 0);
            btnWorkload.Name = "btnWorkload";
            btnWorkload.Size = new Size(160, 30);
            btnWorkload.TabIndex = 3;
            btnWorkload.Text = "Technician Workload";
            btnWorkload.UseVisualStyleBackColor = true;
            // 
            // btnParts
            // 
            btnParts.Location = new Point(184, 0);
            btnParts.Name = "btnParts";
            btnParts.Size = new Size(112, 30);
            btnParts.TabIndex = 2;
            btnParts.Text = "Parts Usage";
            btnParts.UseVisualStyleBackColor = true;
            // 
            // btnIncome
            // 
            btnIncome.Location = new Point(92, 0);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(84, 30);
            btnIncome.TabIndex = 1;
            btnIncome.Text = "Income";
            btnIncome.UseVisualStyleBackColor = true;
            // 
            // btnRepairs
            // 
            btnRepairs.Location = new Point(0, 0);
            btnRepairs.Name = "btnRepairs";
            btnRepairs.Size = new Size(84, 30);
            btnRepairs.TabIndex = 0;
            btnRepairs.Text = "Repairs";
            btnRepairs.UseVisualStyleBackColor = true;
            // 
            // cardChart
            // 
            cardChart.BackColor = Color.FromArgb(40, 44, 52);
            cardChart.Controls.Add(barChart);
            cardChart.Controls.Add(lblChartTitle);
            cardChart.Dock = DockStyle.Fill;
            cardChart.ForeColor = Color.FromArgb(220, 225, 230);
            cardChart.Location = new Point(0, 44);
            cardChart.Margin = new Padding(0, 0, 7, 0);
            cardChart.Name = "cardChart";
            cardChart.Padding = new Padding(16, 52, 16, 16);
            cardChart.Size = new Size(523, 467);
            cardChart.TabIndex = 1;
            // 
            // barChart
            // 
            barChart.BackColor = Color.FromArgb(40, 44, 52);
            barChart.Dock = DockStyle.Fill;
            barChart.Font = new Font("Segoe UI", 8.5F);
            barChart.ForeColor = Color.FromArgb(160, 168, 178);
            barChart.Location = new Point(16, 52);
            barChart.Name = "barChart";
            barChart.Size = new Size(491, 399);
            barChart.TabIndex = 1;
            barChart.Text = "barChart1";
            // 
            // lblChartTitle
            // 
            lblChartTitle.AutoSize = true;
            lblChartTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblChartTitle.ForeColor = Color.FromArgb(160, 168, 178);
            lblChartTitle.Location = new Point(20, 18);
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Size = new Size(42, 20);
            lblChartTitle.TabIndex = 0;
            lblChartTitle.Text = "label";
            // 
            // cardTable
            // 
            cardTable.BackColor = Color.FromArgb(40, 44, 52);
            cardTable.Controls.Add(dgvReport);
            cardTable.Controls.Add(lblTableTitle);
            cardTable.Dock = DockStyle.Fill;
            cardTable.ForeColor = Color.FromArgb(220, 225, 230);
            cardTable.Location = new Point(537, 44);
            cardTable.Margin = new Padding(7, 0, 0, 0);
            cardTable.Name = "cardTable";
            cardTable.Padding = new Padding(16, 52, 16, 16);
            cardTable.Size = new Size(427, 467);
            cardTable.TabIndex = 2;
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.Location = new Point(16, 52);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(395, 399);
            dgvReport.TabIndex = 2;
            // 
            // lblTableTitle
            // 
            lblTableTitle.AutoSize = true;
            lblTableTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTableTitle.ForeColor = Color.FromArgb(160, 168, 178);
            lblTableTitle.Location = new Point(20, 18);
            lblTableTitle.Name = "lblTableTitle";
            lblTableTitle.Size = new Size(68, 20);
            lblTableTitle.TabIndex = 1;
            lblTableTitle.Text = "DETAILS";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 37, 43);
            ClientSize = new Size(1012, 623);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "ReportsForm";
            Text = "Reports Form";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            tblReports.ResumeLayout(false);
            pnlChips.ResumeLayout(false);
            cardChart.ResumeLayout(false);
            cardChart.PerformLayout();
            cardTable.ResumeLayout(false);
            cardTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private ComboBox cmbRange;
        private Label lblTitle;
        private Panel pnlHeaderLine;
        private Panel pnlBody;
        private TableLayoutPanel tblReports;
        private Panel pnlChips;
        private Button btnUnpaid;
        private Button btnWorkload;
        private Button btnParts;
        private Button btnIncome;
        private Button btnRepairs;
        private UI.CardPanel cardChart;
        private UI.CardPanel cardTable;
        private Label lblChartTitle;
        private UI.BarChart barChart;
        private DataGridView dgvReport;
        private Label lblTableTitle;
    }
}