namespace FixFlow.Forms
{
    partial class LandingForm
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
            pnlHeroContainer = new Panel();
            cardReports = new Panel();
            label9 = new Label();
            label8 = new Label();
            cardCosting = new Panel();
            label7 = new Label();
            label6 = new Label();
            cardRecord = new Panel();
            label5 = new Label();
            label4 = new Label();
            btnGetStarted = new Button();
            label3 = new Label();
            label2 = new Label();
            btnSignIn = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlHeroContainer.SuspendLayout();
            cardReports.SuspendLayout();
            cardCosting.SuspendLayout();
            cardRecord.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeroContainer
            // 
            pnlHeroContainer.Anchor = AnchorStyles.None;
            pnlHeroContainer.Controls.Add(cardReports);
            pnlHeroContainer.Controls.Add(cardCosting);
            pnlHeroContainer.Controls.Add(cardRecord);
            pnlHeroContainer.Controls.Add(btnGetStarted);
            pnlHeroContainer.Controls.Add(label3);
            pnlHeroContainer.Controls.Add(label2);
            pnlHeroContainer.Controls.Add(btnSignIn);
            pnlHeroContainer.Controls.Add(label1);
            pnlHeroContainer.Location = new Point(41, 16);
            pnlHeroContainer.Name = "pnlHeroContainer";
            pnlHeroContainer.Size = new Size(1050, 620);
            pnlHeroContainer.TabIndex = 8;
            // 
            // cardReports
            // 
            cardReports.BackColor = Color.FromArgb(40, 44, 52);
            cardReports.Controls.Add(label9);
            cardReports.Controls.Add(label8);
            cardReports.Location = new Point(710, 471);
            cardReports.Name = "cardReports";
            cardReports.Size = new Size(330, 125);
            cardReports.TabIndex = 15;
            // 
            // label9
            // 
            label9.ForeColor = Color.White;
            label9.Location = new Point(20, 45);
            label9.Name = "label9";
            label9.Size = new Size(296, 45);
            label9.TabIndex = 3;
            label9.Text = "Repairs, income, parts usage, and technician workload.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(130, 140, 150);
            label8.Location = new Point(20, 20);
            label8.Name = "label8";
            label8.Size = new Size(61, 17);
            label8.TabIndex = 2;
            label8.Text = "REPORTS";
            // 
            // cardCosting
            // 
            cardCosting.BackColor = Color.FromArgb(40, 44, 52);
            cardCosting.Controls.Add(label7);
            cardCosting.Controls.Add(label6);
            cardCosting.Location = new Point(360, 471);
            cardCosting.Name = "cardCosting";
            cardCosting.Size = new Size(330, 125);
            cardCosting.TabIndex = 14;
            // 
            // label7
            // 
            label7.ForeColor = Color.White;
            label7.Location = new Point(20, 45);
            label7.Name = "label7";
            label7.Size = new Size(296, 45);
            label7.TabIndex = 2;
            label7.Text = "Labor and parts are totaled and \r\nused parts leave inventory.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(130, 140, 150);
            label6.Location = new Point(20, 20);
            label6.Name = "label6";
            label6.Size = new Size(132, 17);
            label6.TabIndex = 1;
            label6.Text = "COSTING AND PARTS";
            // 
            // cardRecord
            // 
            cardRecord.BackColor = Color.FromArgb(40, 44, 52);
            cardRecord.Controls.Add(label5);
            cardRecord.Controls.Add(label4);
            cardRecord.Location = new Point(10, 471);
            cardRecord.Name = "cardRecord";
            cardRecord.Size = new Size(330, 125);
            cardRecord.TabIndex = 13;
            // 
            // label5
            // 
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 45);
            label5.Name = "label5";
            label5.Size = new Size(296, 45);
            label5.TabIndex = 1;
            label5.Text = "customers, devices, parts, and repair history.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(130, 140, 150);
            label4.Location = new Point(20, 20);
            label4.Name = "label4";
            label4.Size = new Size(152, 17);
            label4.TabIndex = 0;
            label4.Text = "RECORD MANAGEMENT";
            // 
            // btnGetStarted
            // 
            btnGetStarted.BackColor = Color.FromArgb(26, 188, 156);
            btnGetStarted.Cursor = Cursors.Hand;
            btnGetStarted.FlatAppearance.BorderSize = 0;
            btnGetStarted.FlatStyle = FlatStyle.Flat;
            btnGetStarted.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetStarted.ForeColor = Color.FromArgb(33, 37, 43);
            btnGetStarted.Location = new Point(21, 368);
            btnGetStarted.Name = "btnGetStarted";
            btnGetStarted.Size = new Size(130, 45);
            btnGetStarted.TabIndex = 12;
            btnGetStarted.Text = "Get Started";
            btnGetStarted.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(160, 168, 178);
            label3.Location = new Point(21, 320);
            label3.Name = "label3";
            label3.Size = new Size(614, 25);
            label3.TabIndex = 11;
            label3.Text = "An offline service tracking and billing system for your computer repair shop.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 184);
            label2.Name = "label2";
            label2.Size = new Size(599, 124);
            label2.TabIndex = 10;
            label2.Text = "Every repair, tracked from\r\nreceived to released\r\n";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(40, 44, 52);
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderColor = Color.FromArgb(26, 188, 156);
            btnSignIn.FlatAppearance.BorderSize = 2;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.FromArgb(26, 188, 156);
            btnSignIn.Location = new Point(930, 26);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(110, 40);
            btnSignIn.TabIndex = 9;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 30);
            label1.Name = "label1";
            label1.Size = new Size(117, 38);
            label1.TabIndex = 8;
            label1.Text = "FixFlow";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pnlHeroContainer, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1132, 653);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // LandingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 37, 43);
            ClientSize = new Size(1132, 653);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "LandingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FixFlow - Welcome";
            pnlHeroContainer.ResumeLayout(false);
            pnlHeroContainer.PerformLayout();
            cardReports.ResumeLayout(false);
            cardReports.PerformLayout();
            cardCosting.ResumeLayout(false);
            cardCosting.PerformLayout();
            cardRecord.ResumeLayout(false);
            cardRecord.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void LandingForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel pnlHeroContainer;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel cardReports;
        private Label label9;
        private Label label8;
        private Panel cardCosting;
        private Label label7;
        private Label label6;
        private Panel cardRecord;
        private Label label5;
        private Label label4;
        private Button btnGetStarted;
        private Label label3;
        private Label label2;
        private Button btnSignIn;
        private Label label1;
    }
}