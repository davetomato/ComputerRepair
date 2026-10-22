namespace FixFlow.Forms
{
    partial class LoginForm
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
            label4 = new Label();
            lblError = new Label();
            btnLogin = new Button();
            pnlUsername = new Panel();
            txtUsername = new TextBox();
            pnlPassword = new Panel();
            btnTogglePassword = new Button();
            txtPassword = new TextBox();
            cardPanel = new Panel();
            label3 = new Label();
            btnBack = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlUsername.SuspendLayout();
            pnlPassword.SuspendLayout();
            cardPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(32, 73);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 1;
            label4.Text = "Sign in to continue";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(32, 248);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(26, 188, 156);
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(26, 188, 156);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(32, 278);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(361, 46);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.FromArgb(33, 37, 43);
            pnlUsername.Controls.Add(txtUsername);
            pnlUsername.Location = new Point(34, 134);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(361, 40);
            pnlUsername.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(33, 37, 43);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(10, 10);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(341, 23);
            txtUsername.TabIndex = 0;
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.FromArgb(33, 37, 43);
            pnlPassword.Controls.Add(btnTogglePassword);
            pnlPassword.Controls.Add(txtPassword);
            pnlPassword.Location = new Point(32, 193);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(361, 40);
            pnlPassword.TabIndex = 6;
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.Cursor = Cursors.Hand;
            btnTogglePassword.FlatAppearance.BorderSize = 0;
            btnTogglePassword.FlatStyle = FlatStyle.Flat;
            btnTogglePassword.ForeColor = Color.FromArgb(160, 168, 178);
            btnTogglePassword.Location = new Point(323, 3);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(35, 35);
            btnTogglePassword.TabIndex = 2;
            btnTogglePassword.Text = "👁";
            btnTogglePassword.UseVisualStyleBackColor = true;
            btnTogglePassword.Click += btnTogglePassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(33, 37, 43);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.WhiteSmoke;
            txtPassword.Location = new Point(10, 10);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(341, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // cardPanel
            // 
            cardPanel.Anchor = AnchorStyles.None;
            cardPanel.BackColor = Color.FromArgb(40, 44, 52);
            cardPanel.Controls.Add(label3);
            cardPanel.Controls.Add(pnlPassword);
            cardPanel.Controls.Add(btnBack);
            cardPanel.Controls.Add(pnlUsername);
            cardPanel.Controls.Add(btnLogin);
            cardPanel.Controls.Add(lblError);
            cardPanel.Controls.Add(label4);
            cardPanel.Location = new Point(353, 120);
            cardPanel.Name = "cardPanel";
            cardPanel.Size = new Size(425, 392);
            cardPanel.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(32, 23);
            label3.Name = "label3";
            label3.Size = new Size(127, 41);
            label3.TabIndex = 0;
            label3.Text = "FixFlow";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(40, 44, 52);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.ForeColor = Color.FromArgb(160, 168, 178);
            btnBack.Location = new Point(32, 335);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(361, 35);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back to Home";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(cardPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1132, 653);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 37, 43);
            ClientSize = new Size(1132, 653);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FixFlow - Sign in";
            pnlUsername.ResumeLayout(false);
            pnlUsername.PerformLayout();
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            cardPanel.ResumeLayout(false);
            cardPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Label lblError;
        private Button btnLogin;
        private Panel pnlUsername;
        private TextBox txtUsername;
        private Panel pnlPassword;
        private TextBox txtPassword;
        private Panel cardPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Button btnBack;
        private Button btnTogglePassword;
    }
}