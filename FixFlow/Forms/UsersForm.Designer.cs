namespace FixFlow.Forms
{
    partial class UsersForm
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
            btnAddUser = new Button();
            lblTitle = new Label();
            pnlHeaderLine = new Panel();
            pnlBody = new Panel();
            tblUsers = new TableLayoutPanel();
            cardUsers = new FixFlow.UI.CardPanel();
            dgvUsers = new DataGridView();
            pnlUserActions = new Panel();
            btnDeleteUser = new Button();
            lblUsersTitle = new Label();
            cardRates = new FixFlow.UI.CardPanel();
            panel1 = new Panel();
            btnSaveRate = new Button();
            txtRate = new FixFlow.UI.InputBox();
            lblSelectedRate = new Label();
            dgvRates = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            tblUsers.SuspendLayout();
            cardUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            pnlUserActions.SuspendLayout();
            cardRates.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRates).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(40, 44, 52);
            pnlHeader.Controls.Add(btnAddUser);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(pnlHeaderLine);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1012, 64);
            pnlHeader.TabIndex = 1;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddUser.Location = new Point(876, 13);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(130, 38);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "+ Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(223, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Users and Rates";
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
            pnlBody.Controls.Add(tblUsers);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 64);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(24);
            pnlBody.Size = new Size(1012, 559);
            pnlBody.TabIndex = 2;
            // 
            // tblUsers
            // 
            tblUsers.ColumnCount = 2;
            tblUsers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblUsers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblUsers.Controls.Add(cardUsers, 0, 0);
            tblUsers.Controls.Add(cardRates, 1, 0);
            tblUsers.Dock = DockStyle.Fill;
            tblUsers.Location = new Point(24, 24);
            tblUsers.Name = "tblUsers";
            tblUsers.RowCount = 1;
            tblUsers.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblUsers.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblUsers.Size = new Size(964, 511);
            tblUsers.TabIndex = 0;
            // 
            // cardUsers
            // 
            cardUsers.BackColor = Color.FromArgb(40, 44, 52);
            cardUsers.Controls.Add(dgvUsers);
            cardUsers.Controls.Add(pnlUserActions);
            cardUsers.Controls.Add(lblUsersTitle);
            cardUsers.Dock = DockStyle.Fill;
            cardUsers.ForeColor = Color.FromArgb(220, 225, 230);
            cardUsers.Location = new Point(0, 0);
            cardUsers.Margin = new Padding(0, 0, 7, 0);
            cardUsers.Name = "cardUsers";
            cardUsers.Padding = new Padding(16, 52, 16, 16);
            cardUsers.Size = new Size(475, 511);
            cardUsers.TabIndex = 0;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(16, 52);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(443, 387);
            dgvUsers.TabIndex = 3;
            // 
            // pnlUserActions
            // 
            pnlUserActions.Controls.Add(btnDeleteUser);
            pnlUserActions.Dock = DockStyle.Bottom;
            pnlUserActions.Location = new Point(16, 439);
            pnlUserActions.Name = "pnlUserActions";
            pnlUserActions.Size = new Size(443, 56);
            pnlUserActions.TabIndex = 2;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(0, 12);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(140, 38);
            btnDeleteUser.TabIndex = 0;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // lblUsersTitle
            // 
            lblUsersTitle.AutoSize = true;
            lblUsersTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsersTitle.ForeColor = Color.FromArgb(160, 168, 178);
            lblUsersTitle.Location = new Point(20, 18);
            lblUsersTitle.Name = "lblUsersTitle";
            lblUsersTitle.Size = new Size(130, 20);
            lblUsersTitle.TabIndex = 1;
            lblUsersTitle.Text = "USER ACCOUNTS";
            // 
            // cardRates
            // 
            cardRates.BackColor = Color.FromArgb(40, 44, 52);
            cardRates.Controls.Add(panel1);
            cardRates.Controls.Add(dgvRates);
            cardRates.Dock = DockStyle.Fill;
            cardRates.ForeColor = Color.FromArgb(220, 225, 230);
            cardRates.Location = new Point(489, 0);
            cardRates.Margin = new Padding(7, 0, 0, 0);
            cardRates.Name = "cardRates";
            cardRates.Padding = new Padding(16, 0, 16, 16);
            cardRates.Size = new Size(475, 511);
            cardRates.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSaveRate);
            panel1.Controls.Add(txtRate);
            panel1.Controls.Add(lblSelectedRate);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(16, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 125);
            panel1.TabIndex = 6;
            // 
            // btnSaveRate
            // 
            btnSaveRate.Location = new Point(201, 18);
            btnSaveRate.Name = "btnSaveRate";
            btnSaveRate.Size = new Size(130, 40);
            btnSaveRate.TabIndex = 4;
            btnSaveRate.Text = "Save Rate";
            btnSaveRate.UseVisualStyleBackColor = true;
            // 
            // txtRate
            // 
            txtRate.BackColor = Color.FromArgb(33, 37, 43);
            txtRate.Location = new Point(15, 18);
            txtRate.Name = "txtRate";
            txtRate.PlaceholderText = "New rate";
            txtRate.Size = new Size(150, 40);
            txtRate.TabIndex = 3;
            // 
            // lblSelectedRate
            // 
            lblSelectedRate.AutoSize = true;
            lblSelectedRate.Font = new Font("Segoe UI", 9F);
            lblSelectedRate.ForeColor = Color.FromArgb(160, 168, 178);
            lblSelectedRate.Location = new Point(15, 76);
            lblSelectedRate.Name = "lblSelectedRate";
            lblSelectedRate.Size = new Size(229, 20);
            lblSelectedRate.TabIndex = 2;
            lblSelectedRate.Text = "Select a service to change its rate";
            // 
            // dgvRates
            // 
            dgvRates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRates.Location = new Point(16, 0);
            dgvRates.Name = "dgvRates";
            dgvRates.RowHeadersWidth = 51;
            dgvRates.Size = new Size(443, 495);
            dgvRates.TabIndex = 5;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 37, 43);
            ClientSize = new Size(1012, 623);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "UsersForm";
            Text = "Users Form";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            tblUsers.ResumeLayout(false);
            cardUsers.ResumeLayout(false);
            cardUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            pnlUserActions.ResumeLayout(false);
            cardRates.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRates).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlHeaderLine;
        private Button btnAddUser;
        private Panel pnlBody;
        private TableLayoutPanel tblUsers;
        private UI.CardPanel cardUsers;
        private UI.CardPanel cardRates;
        private Panel pnlUserActions;
        private Button btnDeleteUser;
        private Label lblUsersTitle;
        private DataGridView dgvUsers;
        private Button btnSaveRate;
        private UI.InputBox txtRate;
        private Label lblSelectedRate;
        private DataGridView dgvRates;
        private Panel panel1;
    }
}