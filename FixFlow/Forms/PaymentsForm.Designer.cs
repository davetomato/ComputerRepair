namespace FixFlow.Forms
{
    partial class PaymentsForm
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
            btnReceive = new Button();
            lblTitle = new Label();
            pnlHeaderLine = new Panel();
            pnlBody = new Panel();
            tblPayments = new TableLayoutPanel();
            cardCollected = new FixFlow.UI.CardPanel();
            lblCollected = new Label();
            label1 = new Label();
            cardUnpaid = new FixFlow.UI.CardPanel();
            lblUnpaid = new Label();
            label3 = new Label();
            cardCount = new FixFlow.UI.CardPanel();
            llblCount = new Label();
            label4 = new Label();
            cardOrders = new FixFlow.UI.CardPanel();
            panel1 = new Panel();
            lblOrdersTitle = new Label();
            btnAll = new Button();
            btnUnpaid = new Button();
            btnPaid = new Button();
            dgvOrders = new DataGridView();
            lblCount = new Label();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            tblPayments.SuspendLayout();
            cardCollected.SuspendLayout();
            cardUnpaid.SuspendLayout();
            cardCount.SuspendLayout();
            cardOrders.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(40, 44, 52);
            pnlHeader.Controls.Add(btnReceive);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(pnlHeaderLine);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1012, 64);
            pnlHeader.TabIndex = 1;
            // 
            // btnReceive
            // 
            btnReceive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReceive.Location = new Point(846, 13);
            btnReceive.Name = "btnReceive";
            btnReceive.Size = new Size(160, 38);
            btnReceive.TabIndex = 2;
            btnReceive.Text = "Receive Payment";
            btnReceive.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(132, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Payment";
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
            pnlBody.Controls.Add(tblPayments);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 64);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(24);
            pnlBody.Size = new Size(1012, 559);
            pnlBody.TabIndex = 2;
            // 
            // tblPayments
            // 
            tblPayments.ColumnCount = 3;
            tblPayments.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblPayments.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblPayments.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblPayments.Controls.Add(cardCollected, 0, 0);
            tblPayments.Controls.Add(cardUnpaid, 1, 0);
            tblPayments.Controls.Add(cardCount, 2, 0);
            tblPayments.Controls.Add(cardOrders, 0, 1);
            tblPayments.Dock = DockStyle.Fill;
            tblPayments.Location = new Point(24, 24);
            tblPayments.Name = "tblPayments";
            tblPayments.RowCount = 2;
            tblPayments.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            tblPayments.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPayments.Size = new Size(964, 511);
            tblPayments.TabIndex = 0;
            // 
            // cardCollected
            // 
            cardCollected.BackColor = Color.FromArgb(40, 44, 52);
            cardCollected.Controls.Add(lblCollected);
            cardCollected.Controls.Add(label1);
            cardCollected.Dock = DockStyle.Fill;
            cardCollected.ForeColor = Color.FromArgb(220, 225, 230);
            cardCollected.Location = new Point(0, 0);
            cardCollected.Margin = new Padding(0, 0, 14, 14);
            cardCollected.Name = "cardCollected";
            cardCollected.Padding = new Padding(16);
            cardCollected.Size = new Size(307, 92);
            cardCollected.TabIndex = 0;
            // 
            // lblCollected
            // 
            lblCollected.AutoSize = true;
            lblCollected.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCollected.ForeColor = Color.White;
            lblCollected.Location = new Point(18, 38);
            lblCollected.Name = "lblCollected";
            lblCollected.Size = new Size(96, 41);
            lblCollected.TabIndex = 1;
            lblCollected.Text = "₱0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(160, 168, 178);
            label1.Location = new Point(18, 14);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Collected today";
            // 
            // cardUnpaid
            // 
            cardUnpaid.BackColor = Color.FromArgb(40, 44, 52);
            cardUnpaid.Controls.Add(lblUnpaid);
            cardUnpaid.Controls.Add(label3);
            cardUnpaid.Dock = DockStyle.Fill;
            cardUnpaid.ForeColor = Color.FromArgb(220, 225, 230);
            cardUnpaid.Location = new Point(321, 0);
            cardUnpaid.Margin = new Padding(0, 0, 14, 14);
            cardUnpaid.Name = "cardUnpaid";
            cardUnpaid.Padding = new Padding(16);
            cardUnpaid.Size = new Size(307, 92);
            cardUnpaid.TabIndex = 1;
            // 
            // lblUnpaid
            // 
            lblUnpaid.AutoSize = true;
            lblUnpaid.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblUnpaid.ForeColor = Color.White;
            lblUnpaid.Location = new Point(18, 38);
            lblUnpaid.Name = "lblUnpaid";
            lblUnpaid.Size = new Size(96, 41);
            lblUnpaid.TabIndex = 2;
            lblUnpaid.Text = "₱0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(160, 168, 178);
            label3.Location = new Point(18, 14);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 1;
            label3.Text = "Unpaid balances";
            // 
            // cardCount
            // 
            cardCount.BackColor = Color.FromArgb(40, 44, 52);
            cardCount.Controls.Add(lblCount);
            cardCount.Controls.Add(llblCount);
            cardCount.Controls.Add(label4);
            cardCount.Dock = DockStyle.Fill;
            cardCount.ForeColor = Color.FromArgb(220, 225, 230);
            cardCount.Location = new Point(642, 0);
            cardCount.Margin = new Padding(0, 0, 14, 14);
            cardCount.Name = "cardCount";
            cardCount.Padding = new Padding(16);
            cardCount.Size = new Size(308, 92);
            cardCount.TabIndex = 2;
            // 
            // llblCount
            // 
            llblCount.AutoSize = true;
            llblCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            llblCount.ForeColor = Color.White;
            llblCount.Location = new Point(18, 38);
            llblCount.Name = "llblCount";
            llblCount.Size = new Size(35, 41);
            llblCount.TabIndex = 2;
            llblCount.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(160, 168, 178);
            label4.Location = new Point(18, 14);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 1;
            label4.Text = "Orders with balance";
            // 
            // cardOrders
            // 
            cardOrders.BackColor = Color.FromArgb(40, 44, 52);
            tblPayments.SetColumnSpan(cardOrders, 3);
            cardOrders.Controls.Add(panel1);
            cardOrders.Controls.Add(dgvOrders);
            cardOrders.Dock = DockStyle.Fill;
            cardOrders.ForeColor = Color.FromArgb(220, 225, 230);
            cardOrders.Location = new Point(0, 106);
            cardOrders.Margin = new Padding(0);
            cardOrders.Name = "cardOrders";
            cardOrders.Padding = new Padding(16);
            cardOrders.Size = new Size(964, 405);
            cardOrders.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblOrdersTitle);
            panel1.Controls.Add(btnAll);
            panel1.Controls.Add(btnUnpaid);
            panel1.Controls.Add(btnPaid);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(16, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 60);
            panel1.TabIndex = 5;
            // 
            // lblOrdersTitle
            // 
            lblOrdersTitle.AutoSize = true;
            lblOrdersTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOrdersTitle.ForeColor = Color.FromArgb(160, 168, 178);
            lblOrdersTitle.Location = new Point(3, 0);
            lblOrdersTitle.Name = "lblOrdersTitle";
            lblOrdersTitle.Size = new Size(67, 20);
            lblOrdersTitle.TabIndex = 0;
            lblOrdersTitle.Text = "ORDERS";
            // 
            // btnAll
            // 
            btnAll.Location = new Point(3, 23);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(72, 30);
            btnAll.TabIndex = 1;
            btnAll.Text = "All";
            btnAll.UseVisualStyleBackColor = true;
            // 
            // btnUnpaid
            // 
            btnUnpaid.Location = new Point(81, 23);
            btnUnpaid.Name = "btnUnpaid";
            btnUnpaid.Size = new Size(72, 30);
            btnUnpaid.TabIndex = 2;
            btnUnpaid.Text = "Unpaid";
            btnUnpaid.UseVisualStyleBackColor = true;
            // 
            // btnPaid
            // 
            btnPaid.Location = new Point(159, 23);
            btnPaid.Name = "btnPaid";
            btnPaid.Size = new Size(72, 30);
            btnPaid.TabIndex = 3;
            btnPaid.Text = "Paid";
            btnPaid.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(16, 16);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(932, 373);
            dgvOrders.TabIndex = 4;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(180, 14);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(50, 20);
            lblCount.TabIndex = 3;
            lblCount.Text = "label2";
            // 
            // PaymentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 37, 43);
            ClientSize = new Size(1012, 623);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "PaymentsForm";
            Text = "Payment Form";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            tblPayments.ResumeLayout(false);
            cardCollected.ResumeLayout(false);
            cardCollected.PerformLayout();
            cardUnpaid.ResumeLayout(false);
            cardUnpaid.PerformLayout();
            cardCount.ResumeLayout(false);
            cardCount.PerformLayout();
            cardOrders.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlHeaderLine;
        private Button btnReceive;
        private Panel pnlBody;
        private TableLayoutPanel tblPayments;
        private UI.CardPanel cardCollected;
        private UI.CardPanel cardUnpaid;
        private UI.CardPanel cardCount;
        private UI.CardPanel cardOrders;
        private Label lblCollected;
        private Label label1;
        private Label lblUnpaid;
        private Label label3;
        private Label llblCount;
        private Label label4;
        private Button btnPaid;
        private Button btnUnpaid;
        private Button btnAll;
        private Label lblOrdersTitle;
        private Panel panel1;
        private DataGridView dgvOrders;
        private Label lblCount;
    }
}