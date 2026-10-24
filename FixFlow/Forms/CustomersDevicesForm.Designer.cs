namespace FixFlow.Forms
{
    partial class CustomersDevicesForm
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
            label1 = new Label();
            txtSearch = new TextBox();
            dgvData = new DataGridView();
            lblGridHeader = new Label();
            pnlLeftCard = new Panel();
            btnRegisterDevice = new Button();
            btnDeleteCustomer = new Button();
            btnCancel = new Button();
            txtAddress = new TextBox();
            label6 = new Label();
            txtContact = new TextBox();
            label5 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pnlRightCard = new Panel();
            txtPartToRepair = new TextBox();
            label8 = new Label();
            label15 = new Label();
            txtSerialNo = new TextBox();
            label14 = new Label();
            txtModel = new TextBox();
            label13 = new Label();
            txtBrand = new TextBox();
            label12 = new Label();
            cmbDeviceType = new ComboBox();
            label11 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            pnlLeftCard.SuspendLayout();
            pnlRightCard.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(319, 38);
            label1.TabIndex = 0;
            label1.Text = "Customers and Devices";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.BackColor = Color.FromArgb(40, 44, 52);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(1020, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search customer...";
            txtSearch.Size = new Size(220, 27);
            txtSearch.TabIndex = 1;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.BackgroundColor = Color.FromArgb(33, 37, 43);
            dgvData.BorderStyle = BorderStyle.None;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(20, 480);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersVisible = false;
            dgvData.RowHeadersWidth = 51;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(1180, 260);
            dgvData.TabIndex = 4;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // lblGridHeader
            // 
            lblGridHeader.AutoSize = true;
            lblGridHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGridHeader.ForeColor = Color.FromArgb(160, 168, 178);
            lblGridHeader.Location = new Point(20, 455);
            lblGridHeader.Name = "lblGridHeader";
            lblGridHeader.Size = new Size(244, 20);
            lblGridHeader.TabIndex = 5;
            lblGridHeader.Text = "CUSTOMER AND DEVICE DETAILS";
            // 
            // pnlLeftCard
            // 
            pnlLeftCard.BackColor = Color.FromArgb(40, 44, 52);
            pnlLeftCard.Controls.Add(btnRegisterDevice);
            pnlLeftCard.Controls.Add(btnDeleteCustomer);
            pnlLeftCard.Controls.Add(btnCancel);
            pnlLeftCard.Controls.Add(txtAddress);
            pnlLeftCard.Controls.Add(label6);
            pnlLeftCard.Controls.Add(txtContact);
            pnlLeftCard.Controls.Add(label5);
            pnlLeftCard.Controls.Add(txtLastName);
            pnlLeftCard.Controls.Add(label4);
            pnlLeftCard.Controls.Add(txtFirstName);
            pnlLeftCard.Controls.Add(label2);
            pnlLeftCard.Controls.Add(label3);
            pnlLeftCard.Location = new Point(45, 68);
            pnlLeftCard.Name = "pnlLeftCard";
            pnlLeftCard.Size = new Size(592, 364);
            pnlLeftCard.TabIndex = 6;
            // 
            // btnRegisterDevice
            // 
            btnRegisterDevice.BackColor = Color.FromArgb(26, 188, 156);
            btnRegisterDevice.Cursor = Cursors.Hand;
            btnRegisterDevice.FlatAppearance.BorderSize = 0;
            btnRegisterDevice.FlatStyle = FlatStyle.Flat;
            btnRegisterDevice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterDevice.ForeColor = Color.FromArgb(33, 37, 43);
            btnRegisterDevice.Location = new Point(373, 288);
            btnRegisterDevice.Name = "btnRegisterDevice";
            btnRegisterDevice.Size = new Size(147, 35);
            btnRegisterDevice.TabIndex = 34;
            btnRegisterDevice.Text = "Register Device";
            btnRegisterDevice.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Cursor = Cursors.Hand;
            btnDeleteCustomer.FlatAppearance.BorderColor = Color.FromArgb(26, 188, 156);
            btnDeleteCustomer.FlatStyle = FlatStyle.Flat;
            btnDeleteCustomer.ForeColor = Color.FromArgb(26, 188, 156);
            btnDeleteCustomer.Location = new Point(20, 288);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(159, 35);
            btnDeleteCustomer.TabIndex = 31;
            btnDeleteCustomer.Text = "Delete Customer";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(26, 188, 156);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(26, 188, 156);
            btnCancel.Location = new Point(229, 288);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(25, 28, 33);
            txtAddress.ForeColor = Color.White;
            txtAddress.Location = new Point(20, 188);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(500, 50);
            txtAddress.TabIndex = 27;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(20, 165);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 26;
            label6.Text = "Address";
            // 
            // txtContact
            // 
            txtContact.BackColor = Color.FromArgb(25, 28, 33);
            txtContact.ForeColor = Color.White;
            txtContact.Location = new Point(20, 128);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(500, 27);
            txtContact.TabIndex = 25;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(20, 105);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 24;
            label5.Text = "Contact Number";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(25, 28, 33);
            txtLastName.ForeColor = Color.White;
            txtLastName.Location = new Point(280, 68);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(240, 27);
            txtLastName.TabIndex = 23;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(280, 45);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 22;
            label4.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(25, 28, 33);
            txtFirstName.ForeColor = Color.White;
            txtFirstName.Location = new Point(20, 68);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(240, 27);
            txtFirstName.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(160, 168, 178);
            label2.Location = new Point(20, 15);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 19;
            label2.Text = "ADD CUSTOMER DETAILS";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(20, 45);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 20;
            label3.Text = "First Name";
            // 
            // pnlRightCard
            // 
            pnlRightCard.BackColor = Color.FromArgb(40, 44, 52);
            pnlRightCard.Controls.Add(txtPartToRepair);
            pnlRightCard.Controls.Add(label8);
            pnlRightCard.Controls.Add(label15);
            pnlRightCard.Controls.Add(txtSerialNo);
            pnlRightCard.Controls.Add(label14);
            pnlRightCard.Controls.Add(txtModel);
            pnlRightCard.Controls.Add(label13);
            pnlRightCard.Controls.Add(txtBrand);
            pnlRightCard.Controls.Add(label12);
            pnlRightCard.Controls.Add(cmbDeviceType);
            pnlRightCard.Controls.Add(label11);
            pnlRightCard.Controls.Add(label9);
            pnlRightCard.Location = new Point(658, 68);
            pnlRightCard.Name = "pnlRightCard";
            pnlRightCard.Size = new Size(592, 364);
            pnlRightCard.TabIndex = 7;
            // 
            // txtPartToRepair
            // 
            txtPartToRepair.BackColor = Color.FromArgb(25, 28, 33);
            txtPartToRepair.ForeColor = Color.White;
            txtPartToRepair.Location = new Point(20, 277);
            txtPartToRepair.Multiline = true;
            txtPartToRepair.Name = "txtPartToRepair";
            txtPartToRepair.Size = new Size(500, 46);
            txtPartToRepair.TabIndex = 32;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(20, 244);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 31;
            label8.Text = "Part to repair";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(120, 128, 138);
            label15.Location = new Point(20, 215);
            label15.Name = "label15";
            label15.Size = new Size(347, 17);
            label15.TabIndex = 30;
            label15.Text = "The serial number fills in by itself once the model is typed.";
            // 
            // txtSerialNo
            // 
            txtSerialNo.BackColor = Color.FromArgb(25, 28, 33);
            txtSerialNo.ForeColor = Color.White;
            txtSerialNo.Location = new Point(280, 178);
            txtSerialNo.Multiline = true;
            txtSerialNo.Name = "txtSerialNo";
            txtSerialNo.ReadOnly = true;
            txtSerialNo.Size = new Size(240, 25);
            txtSerialNo.TabIndex = 29;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.ForeColor = Color.LightGray;
            label14.Location = new Point(280, 155);
            label14.Name = "label14";
            label14.Size = new Size(101, 20);
            label14.TabIndex = 28;
            label14.Text = "Serial number";
            // 
            // txtModel
            // 
            txtModel.BackColor = Color.FromArgb(25, 28, 33);
            txtModel.ForeColor = Color.White;
            txtModel.Location = new Point(20, 178);
            txtModel.Multiline = true;
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(240, 25);
            txtModel.TabIndex = 27;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.ForeColor = Color.LightGray;
            label13.Location = new Point(20, 155);
            label13.Name = "label13";
            label13.Size = new Size(52, 20);
            label13.TabIndex = 26;
            label13.Text = "Model";
            // 
            // txtBrand
            // 
            txtBrand.BackColor = Color.FromArgb(25, 28, 33);
            txtBrand.ForeColor = Color.White;
            txtBrand.Location = new Point(280, 108);
            txtBrand.Multiline = true;
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(240, 25);
            txtBrand.TabIndex = 25;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.ForeColor = Color.LightGray;
            label12.Location = new Point(280, 75);
            label12.Name = "label12";
            label12.Size = new Size(48, 20);
            label12.TabIndex = 24;
            label12.Text = "Brand";
            // 
            // cmbDeviceType
            // 
            cmbDeviceType.BackColor = Color.FromArgb(25, 28, 33);
            cmbDeviceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeviceType.ForeColor = Color.White;
            cmbDeviceType.FormattingEnabled = true;
            cmbDeviceType.Location = new Point(20, 105);
            cmbDeviceType.Name = "cmbDeviceType";
            cmbDeviceType.Size = new Size(240, 28);
            cmbDeviceType.TabIndex = 23;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.ForeColor = Color.LightGray;
            label11.Location = new Point(20, 71);
            label11.Name = "label11";
            label11.Size = new Size(87, 20);
            label11.TabIndex = 22;
            label11.Text = "Device type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(160, 168, 178);
            label9.Location = new Point(20, 15);
            label9.Name = "label9";
            label9.Size = new Size(160, 20);
            label9.TabIndex = 19;
            label9.Text = "ADD DEVICE DETAILS";
            // 
            // CustomersDevicesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 37, 43);
            ClientSize = new Size(1262, 733);
            Controls.Add(pnlRightCard);
            Controls.Add(pnlLeftCard);
            Controls.Add(lblGridHeader);
            Controls.Add(dgvData);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "CustomersDevicesForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            pnlLeftCard.ResumeLayout(false);
            pnlLeftCard.PerformLayout();
            pnlRightCard.ResumeLayout(false);
            pnlRightCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label1;
        private TextBox txtSearch;
        private DataGridView dgvData;
        private Label lblGridHeader;
        private Panel pnlLeftCard;
        private Button btnDeleteCustomer;
        private TextBox txtAddress;
        private Label label6;
        private TextBox txtContact;
        private Label label5;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtFirstName;
        private Label label2;
        private Label label3;
        private Panel pnlRightCard;
        private Button btnRegisterDevice;
        private Button btnCancel;
        private TextBox txtPartToRepair;
        private Label label8;
        private Label label15;
        private TextBox txtSerialNo;
        private Label label14;
        private TextBox txtModel;
        private Label label13;
        private TextBox txtBrand;
        private Label label12;
        private ComboBox cmbDeviceType;
        private Label label11;
        private Label label9;
    }
}