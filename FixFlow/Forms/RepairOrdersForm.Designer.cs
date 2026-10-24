namespace FixFlow.Forms
{
    partial class RepairOrdersForm
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
            pnlStepper = new Panel();
            step4 = new Panel();
            label4 = new Label();
            step5 = new Panel();
            label5 = new Label();
            step3 = new Panel();
            label3 = new Label();
            step2 = new Panel();
            label2 = new Label();
            step1 = new Panel();
            label1 = new Label();
            lblOrderTitle = new Label();
            lblHeaderStatus = new Label();
            pnlLeftColumn = new GroupBox();
            txtDiagnosis = new TextBox();
            lblDiagnosisHeader = new Label();
            lblValAssigned = new Label();
            lblKeyAssigned = new Label();
            lblValReported = new Label();
            lblKeyReported = new Label();
            lblValDevice = new Label();
            lblKeyDevice = new Label();
            lblValCustomer = new Label();
            lblKeyCustomer = new Label();
            label6 = new Label();
            pnlMiddleColumn = new GroupBox();
            btnRemovePart = new Button();
            btnAdd = new Button();
            numPartQty = new NumericUpDown();
            cmbAvailableParts = new ComboBox();
            numLaborPrice = new NumericUpDown();
            numHoursWorked = new NumericUpDown();
            txtLaborDescription = new TextBox();
            lblHoursUnit = new Label();
            lblLaborHeader = new Label();
            lblPartsFooter = new Label();
            dgvOrderParts = new DataGridView();
            label7 = new Label();
            pnlRightColumn = new Panel();
            btnUpdateProgress = new Button();
            btnReleaseDevice = new Button();
            btnReceivePayment = new Button();
            lblBalance = new Label();
            lblKeyBalance = new Label();
            lblPaidVal = new Label();
            lblKeyPaid = new Label();
            lblTotalCost = new Label();
            lblKeyTotal = new Label();
            lblPartsVal = new Label();
            lblKeyParts = new Label();
            lblLaborVal = new Label();
            lblKeyLabor = new Label();
            label8 = new Label();
            pnlStepper.SuspendLayout();
            step4.SuspendLayout();
            step5.SuspendLayout();
            step3.SuspendLayout();
            step2.SuspendLayout();
            step1.SuspendLayout();
            pnlLeftColumn.SuspendLayout();
            pnlMiddleColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPartQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLaborPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHoursWorked).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderParts).BeginInit();
            pnlRightColumn.SuspendLayout();
            SuspendLayout();
            // 
            // pnlStepper
            // 
            pnlStepper.Controls.Add(step4);
            pnlStepper.Controls.Add(step5);
            pnlStepper.Controls.Add(step3);
            pnlStepper.Controls.Add(step2);
            pnlStepper.Controls.Add(step1);
            pnlStepper.Location = new Point(24, 65);
            pnlStepper.Name = "pnlStepper";
            pnlStepper.Size = new Size(1072, 45);
            pnlStepper.TabIndex = 1;
            // 
            // step4
            // 
            step4.Controls.Add(label4);
            step4.Location = new Point(650, 3);
            step4.Name = "step4";
            step4.Size = new Size(215, 39);
            step4.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(47, 4);
            label4.Name = "label4";
            label4.Size = new Size(96, 31);
            label4.TabIndex = 2;
            label4.Text = "4 Ready";
            // 
            // step5
            // 
            step5.Controls.Add(label5);
            step5.Location = new Point(871, 3);
            step5.Name = "step5";
            step5.Size = new Size(198, 39);
            step5.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(39, 4);
            label5.Name = "label5";
            label5.Size = new Size(124, 31);
            label5.TabIndex = 2;
            label5.Text = "5 Released";
            // 
            // step3
            // 
            step3.BackColor = Color.FromArgb(16, 185, 129);
            step3.Controls.Add(label3);
            step3.Location = new Point(426, 3);
            step3.Name = "step3";
            step3.Size = new Size(218, 39);
            step3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 4);
            label3.Name = "label3";
            label3.Size = new Size(132, 31);
            label3.TabIndex = 2;
            label3.Text = "3 Repairing";
            // 
            // step2
            // 
            step2.BackColor = Color.FromArgb(16, 185, 129);
            step2.Controls.Add(label2);
            step2.Location = new Point(218, 3);
            step2.Name = "step2";
            step2.Size = new Size(202, 39);
            step2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 4);
            label2.Name = "label2";
            label2.Size = new Size(152, 31);
            label2.TabIndex = 2;
            label2.Text = "2 Diagnosing";
            // 
            // step1
            // 
            step1.BackColor = Color.FromArgb(16, 185, 129);
            step1.Controls.Add(label1);
            step1.Location = new Point(3, 3);
            step1.Name = "step1";
            step1.Size = new Size(209, 39);
            step1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 4);
            label1.Name = "label1";
            label1.Size = new Size(121, 31);
            label1.TabIndex = 1;
            label1.Text = "1 Received";
            // 
            // lblOrderTitle
            // 
            lblOrderTitle.AutoSize = true;
            lblOrderTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderTitle.ForeColor = Color.White;
            lblOrderTitle.Location = new Point(24, 20);
            lblOrderTitle.Name = "lblOrderTitle";
            lblOrderTitle.Size = new Size(248, 31);
            lblOrderTitle.TabIndex = 0;
            lblOrderTitle.Text = "Repair Order RO-0131";
            // 
            // lblHeaderStatus
            // 
            lblHeaderStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHeaderStatus.AutoSize = true;
            lblHeaderStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeaderStatus.ForeColor = Color.White;
            lblHeaderStatus.Location = new Point(880, 24);
            lblHeaderStatus.Name = "lblHeaderStatus";
            lblHeaderStatus.Size = new Size(194, 20);
            lblHeaderStatus.TabIndex = 1;
            lblHeaderStatus.Text = "Received Oct 15 • Repairing";
            // 
            // pnlLeftColumn
            // 
            pnlLeftColumn.AutoSize = true;
            pnlLeftColumn.BackColor = Color.FromArgb(40, 44, 52);
            pnlLeftColumn.Controls.Add(txtDiagnosis);
            pnlLeftColumn.Controls.Add(lblDiagnosisHeader);
            pnlLeftColumn.Controls.Add(lblValAssigned);
            pnlLeftColumn.Controls.Add(lblKeyAssigned);
            pnlLeftColumn.Controls.Add(lblValReported);
            pnlLeftColumn.Controls.Add(lblKeyReported);
            pnlLeftColumn.Controls.Add(lblValDevice);
            pnlLeftColumn.Controls.Add(lblKeyDevice);
            pnlLeftColumn.Controls.Add(lblValCustomer);
            pnlLeftColumn.Controls.Add(lblKeyCustomer);
            pnlLeftColumn.Controls.Add(label6);
            pnlLeftColumn.ForeColor = Color.White;
            pnlLeftColumn.Location = new Point(24, 125);
            pnlLeftColumn.Name = "pnlLeftColumn";
            pnlLeftColumn.Size = new Size(390, 540);
            pnlLeftColumn.TabIndex = 2;
            pnlLeftColumn.TabStop = false;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.BackColor = Color.FromArgb(33, 37, 43);
            txtDiagnosis.BorderStyle = BorderStyle.FixedSingle;
            txtDiagnosis.ForeColor = Color.White;
            txtDiagnosis.Location = new Point(16, 285);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.ScrollBars = ScrollBars.Vertical;
            txtDiagnosis.Size = new Size(358, 90);
            txtDiagnosis.TabIndex = 10;
            // 
            // lblDiagnosisHeader
            // 
            lblDiagnosisHeader.AutoSize = true;
            lblDiagnosisHeader.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiagnosisHeader.ForeColor = Color.FromArgb(130, 140, 150);
            lblDiagnosisHeader.Location = new Point(16, 260);
            lblDiagnosisHeader.Name = "lblDiagnosisHeader";
            lblDiagnosisHeader.Size = new Size(170, 17);
            lblDiagnosisHeader.TabIndex = 9;
            lblDiagnosisHeader.Text = "DIAGNOSIS (TECHNICIAN)";
            // 
            // lblValAssigned
            // 
            lblValAssigned.AutoSize = true;
            lblValAssigned.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValAssigned.ForeColor = Color.White;
            lblValAssigned.Location = new Point(109, 135);
            lblValAssigned.Name = "lblValAssigned";
            lblValAssigned.Size = new Size(37, 20);
            lblValAssigned.TabIndex = 8;
            lblValAssigned.Text = "Ana";
            // 
            // lblKeyAssigned
            // 
            lblKeyAssigned.AutoSize = true;
            lblKeyAssigned.ForeColor = Color.FromArgb(160, 168, 178);
            lblKeyAssigned.Location = new Point(16, 135);
            lblKeyAssigned.Name = "lblKeyAssigned";
            lblKeyAssigned.Size = new Size(87, 20);
            lblKeyAssigned.TabIndex = 7;
            lblKeyAssigned.Text = "Assigned to";
            // 
            // lblValReported
            // 
            lblValReported.AutoSize = true;
            lblValReported.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValReported.ForeColor = Color.White;
            lblValReported.Location = new Point(95, 105);
            lblValReported.Name = "lblValReported";
            lblValReported.Size = new Size(153, 20);
            lblValReported.TabIndex = 6;
            lblValReported.Text = "Keys not responding";
            // 
            // lblKeyReported
            // 
            lblKeyReported.AutoSize = true;
            lblKeyReported.ForeColor = Color.FromArgb(160, 168, 178);
            lblKeyReported.Location = new Point(16, 105);
            lblKeyReported.Name = "lblKeyReported";
            lblKeyReported.Size = new Size(71, 20);
            lblKeyReported.TabIndex = 5;
            lblKeyReported.Text = "Reported";
            // 
            // lblValDevice
            // 
            lblValDevice.AutoSize = true;
            lblValDevice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValDevice.ForeColor = Color.White;
            lblValDevice.Location = new Point(95, 75);
            lblValDevice.Name = "lblValDevice";
            lblValDevice.Size = new Size(172, 20);
            lblValDevice.TabIndex = 4;
            lblValDevice.Text = "Asus X515 · SN ····4821";
            // 
            // lblKeyDevice
            // 
            lblKeyDevice.AutoSize = true;
            lblKeyDevice.ForeColor = Color.FromArgb(160, 168, 178);
            lblKeyDevice.Location = new Point(16, 75);
            lblKeyDevice.Name = "lblKeyDevice";
            lblKeyDevice.Size = new Size(54, 20);
            lblKeyDevice.TabIndex = 3;
            lblKeyDevice.Text = "Device";
            // 
            // lblValCustomer
            // 
            lblValCustomer.AutoSize = true;
            lblValCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValCustomer.ForeColor = Color.White;
            lblValCustomer.Location = new Point(95, 45);
            lblValCustomer.Name = "lblValCustomer";
            lblValCustomer.Size = new Size(171, 20);
            lblValCustomer.TabIndex = 2;
            lblValCustomer.Text = "K. Tan · 0917 000 0000";
            // 
            // lblKeyCustomer
            // 
            lblKeyCustomer.AutoSize = true;
            lblKeyCustomer.ForeColor = Color.FromArgb(160, 168, 178);
            lblKeyCustomer.Location = new Point(16, 45);
            lblKeyCustomer.Name = "lblKeyCustomer";
            lblKeyCustomer.Size = new Size(72, 20);
            lblKeyCustomer.TabIndex = 1;
            lblKeyCustomer.Text = "Customer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(130, 140, 150);
            label6.Location = new Point(16, 16);
            label6.Name = "label6";
            label6.Size = new Size(159, 17);
            label6.TabIndex = 0;
            label6.Text = "CUSTOMER AND DEVICE";
            // 
            // pnlMiddleColumn
            // 
            pnlMiddleColumn.BackColor = Color.FromArgb(40, 44, 52);
            pnlMiddleColumn.Controls.Add(btnRemovePart);
            pnlMiddleColumn.Controls.Add(btnAdd);
            pnlMiddleColumn.Controls.Add(numPartQty);
            pnlMiddleColumn.Controls.Add(cmbAvailableParts);
            pnlMiddleColumn.Controls.Add(numLaborPrice);
            pnlMiddleColumn.Controls.Add(numHoursWorked);
            pnlMiddleColumn.Controls.Add(txtLaborDescription);
            pnlMiddleColumn.Controls.Add(lblHoursUnit);
            pnlMiddleColumn.Controls.Add(lblLaborHeader);
            pnlMiddleColumn.Controls.Add(lblPartsFooter);
            pnlMiddleColumn.Controls.Add(dgvOrderParts);
            pnlMiddleColumn.Controls.Add(label7);
            pnlMiddleColumn.Font = new Font("Segoe UI", 7.5F);
            pnlMiddleColumn.ForeColor = Color.FromArgb(120, 128, 138);
            pnlMiddleColumn.Location = new Point(430, 125);
            pnlMiddleColumn.Name = "pnlMiddleColumn";
            pnlMiddleColumn.Size = new Size(310, 540);
            pnlMiddleColumn.TabIndex = 3;
            pnlMiddleColumn.TabStop = false;
            // 
            // btnRemovePart
            // 
            btnRemovePart.BackColor = Color.FromArgb(45, 49, 57);
            btnRemovePart.Cursor = Cursors.Hand;
            btnRemovePart.FlatStyle = FlatStyle.Flat;
            btnRemovePart.ForeColor = Color.FromArgb(231, 76, 60);
            btnRemovePart.Location = new Point(16, 273);
            btnRemovePart.Name = "btnRemovePart";
            btnRemovePart.Size = new Size(278, 26);
            btnRemovePart.TabIndex = 12;
            btnRemovePart.Text = "Remove Selected Part";
            btnRemovePart.UseVisualStyleBackColor = false;
            btnRemovePart.Click += btnRemovePart_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(26, 188, 156);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.FromArgb(33, 37, 43);
            btnAdd.Location = new Point(233, 232);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(61, 26);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // numPartQty
            // 
            numPartQty.BackColor = Color.FromArgb(33, 37, 43);
            numPartQty.ForeColor = Color.White;
            numPartQty.Location = new Point(177, 234);
            numPartQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPartQty.Name = "numPartQty";
            numPartQty.Size = new Size(50, 24);
            numPartQty.TabIndex = 10;
            numPartQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbAvailableParts
            // 
            cmbAvailableParts.BackColor = Color.FromArgb(33, 37, 43);
            cmbAvailableParts.ForeColor = Color.White;
            cmbAvailableParts.FormattingEnabled = true;
            cmbAvailableParts.Location = new Point(16, 235);
            cmbAvailableParts.Name = "cmbAvailableParts";
            cmbAvailableParts.Size = new Size(155, 23);
            cmbAvailableParts.TabIndex = 9;
            // 
            // numLaborPrice
            // 
            numLaborPrice.BackColor = Color.FromArgb(33, 37, 43);
            numLaborPrice.DecimalPlaces = 1;
            numLaborPrice.ForeColor = Color.White;
            numLaborPrice.Location = new Point(179, 342);
            numLaborPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numLaborPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numLaborPrice.Name = "numLaborPrice";
            numLaborPrice.Size = new Size(106, 24);
            numLaborPrice.TabIndex = 8;
            numLaborPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numHoursWorked
            // 
            numHoursWorked.BackColor = Color.FromArgb(33, 37, 43);
            numHoursWorked.DecimalPlaces = 1;
            numHoursWorked.ForeColor = Color.White;
            numHoursWorked.Location = new Point(16, 371);
            numHoursWorked.Maximum = new decimal(new int[] { 999, 0, 0, 65536 });
            numHoursWorked.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numHoursWorked.Name = "numHoursWorked";
            numHoursWorked.Size = new Size(85, 24);
            numHoursWorked.TabIndex = 7;
            numHoursWorked.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            // 
            // txtLaborDescription
            // 
            txtLaborDescription.BackColor = Color.FromArgb(33, 37, 43);
            txtLaborDescription.BorderStyle = BorderStyle.FixedSingle;
            txtLaborDescription.ForeColor = Color.White;
            txtLaborDescription.Location = new Point(16, 341);
            txtLaborDescription.Multiline = true;
            txtLaborDescription.Name = "txtLaborDescription";
            txtLaborDescription.Size = new Size(145, 25);
            txtLaborDescription.TabIndex = 6;
            // 
            // lblHoursUnit
            // 
            lblHoursUnit.AutoSize = true;
            lblHoursUnit.Font = new Font("Segoe UI", 8.5F);
            lblHoursUnit.ForeColor = Color.FromArgb(160, 168, 178);
            lblHoursUnit.Location = new Point(110, 374);
            lblHoursUnit.Name = "lblHoursUnit";
            lblHoursUnit.Size = new Size(101, 20);
            lblHoursUnit.TabIndex = 5;
            lblHoursUnit.Text = "Hours worked";
            // 
            // lblLaborHeader
            // 
            lblLaborHeader.AutoSize = true;
            lblLaborHeader.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLaborHeader.ForeColor = Color.FromArgb(130, 140, 150);
            lblLaborHeader.Location = new Point(16, 316);
            lblLaborHeader.Name = "lblLaborHeader";
            lblLaborHeader.Size = new Size(50, 17);
            lblLaborHeader.TabIndex = 4;
            lblLaborHeader.Text = "LABOR";
            // 
            // lblPartsFooter
            // 
            lblPartsFooter.AutoSize = true;
            lblPartsFooter.ForeColor = Color.FromArgb(120, 128, 138);
            lblPartsFooter.Location = new Point(16, 215);
            lblPartsFooter.Name = "lblPartsFooter";
            lblPartsFooter.Size = new Size(253, 17);
            lblPartsFooter.TabIndex = 3;
            lblPartsFooter.Text = "Saving deducts these from Parts Inventory";
            // 
            // dgvOrderParts
            // 
            dgvOrderParts.BackgroundColor = Color.FromArgb(33, 37, 43);
            dgvOrderParts.BorderStyle = BorderStyle.None;
            dgvOrderParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderParts.Location = new Point(16, 45);
            dgvOrderParts.Name = "dgvOrderParts";
            dgvOrderParts.RowHeadersVisible = false;
            dgvOrderParts.RowHeadersWidth = 51;
            dgvOrderParts.Size = new Size(278, 160);
            dgvOrderParts.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(130, 140, 150);
            label7.Location = new Point(16, 16);
            label7.Name = "label7";
            label7.Size = new Size(84, 17);
            label7.TabIndex = 1;
            label7.Text = "PARTS USED";
            // 
            // pnlRightColumn
            // 
            pnlRightColumn.BackColor = Color.FromArgb(40, 44, 52);
            pnlRightColumn.Controls.Add(btnUpdateProgress);
            pnlRightColumn.Controls.Add(btnReleaseDevice);
            pnlRightColumn.Controls.Add(btnReceivePayment);
            pnlRightColumn.Controls.Add(lblBalance);
            pnlRightColumn.Controls.Add(lblKeyBalance);
            pnlRightColumn.Controls.Add(lblPaidVal);
            pnlRightColumn.Controls.Add(lblKeyPaid);
            pnlRightColumn.Controls.Add(lblTotalCost);
            pnlRightColumn.Controls.Add(lblKeyTotal);
            pnlRightColumn.Controls.Add(lblPartsVal);
            pnlRightColumn.Controls.Add(lblKeyParts);
            pnlRightColumn.Controls.Add(lblLaborVal);
            pnlRightColumn.Controls.Add(lblKeyLabor);
            pnlRightColumn.Controls.Add(label8);
            pnlRightColumn.Location = new Point(756, 125);
            pnlRightColumn.Name = "pnlRightColumn";
            pnlRightColumn.Size = new Size(320, 520);
            pnlRightColumn.TabIndex = 4;
            // 
            // btnUpdateProgress
            // 
            btnUpdateProgress.BackColor = Color.FromArgb(52, 152, 219);
            btnUpdateProgress.Cursor = Cursors.Hand;
            btnUpdateProgress.FlatAppearance.BorderSize = 0;
            btnUpdateProgress.FlatStyle = FlatStyle.Flat;
            btnUpdateProgress.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateProgress.ForeColor = Color.White;
            btnUpdateProgress.Location = new Point(16, 460);
            btnUpdateProgress.Name = "btnUpdateProgress";
            btnUpdateProgress.Size = new Size(288, 45);
            btnUpdateProgress.TabIndex = 15;
            btnUpdateProgress.Text = "Update Workflow Progress";
            btnUpdateProgress.UseVisualStyleBackColor = false;
            btnUpdateProgress.Click += btnUpdateProgress_Click;
            // 
            // btnReleaseDevice
            // 
            btnReleaseDevice.BackColor = Color.FromArgb(40, 44, 52);
            btnReleaseDevice.Cursor = Cursors.Hand;
            btnReleaseDevice.FlatAppearance.BorderColor = Color.FromArgb(26, 188, 156);
            btnReleaseDevice.FlatStyle = FlatStyle.Flat;
            btnReleaseDevice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReleaseDevice.ForeColor = Color.FromArgb(26, 188, 156);
            btnReleaseDevice.Location = new Point(16, 400);
            btnReleaseDevice.Name = "btnReleaseDevice";
            btnReleaseDevice.Size = new Size(288, 45);
            btnReleaseDevice.TabIndex = 14;
            btnReleaseDevice.Text = "Release Device";
            btnReleaseDevice.UseVisualStyleBackColor = false;
            btnReleaseDevice.Click += btnReleaseDevice_Click;
            // 
            // btnReceivePayment
            // 
            btnReceivePayment.BackColor = Color.FromArgb(26, 188, 156);
            btnReceivePayment.Cursor = Cursors.Hand;
            btnReceivePayment.FlatAppearance.BorderSize = 0;
            btnReceivePayment.FlatStyle = FlatStyle.Flat;
            btnReceivePayment.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReceivePayment.ForeColor = Color.FromArgb(33, 37, 43);
            btnReceivePayment.Location = new Point(16, 340);
            btnReceivePayment.Name = "btnReceivePayment";
            btnReceivePayment.Size = new Size(288, 45);
            btnReceivePayment.TabIndex = 13;
            btnReceivePayment.Text = "Receive Cash Payment";
            btnReceivePayment.UseVisualStyleBackColor = false;
            btnReceivePayment.Click += btnReceivePayment_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = Color.FromArgb(26, 188, 156);
            lblBalance.Location = new Point(210, 175);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(66, 23);
            lblBalance.TabIndex = 12;
            lblBalance.Text = "₱1,400";
            // 
            // lblKeyBalance
            // 
            lblKeyBalance.AutoSize = true;
            lblKeyBalance.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKeyBalance.ForeColor = Color.FromArgb(26, 188, 156);
            lblKeyBalance.Location = new Point(16, 175);
            lblKeyBalance.Name = "lblKeyBalance";
            lblKeyBalance.Size = new Size(63, 20);
            lblKeyBalance.TabIndex = 11;
            lblKeyBalance.Text = "Balance";
            // 
            // lblPaidVal
            // 
            lblPaidVal.AutoSize = true;
            lblPaidVal.ForeColor = Color.White;
            lblPaidVal.Location = new Point(230, 145);
            lblPaidVal.Name = "lblPaidVal";
            lblPaidVal.Size = new Size(42, 20);
            lblPaidVal.TabIndex = 10;
            lblPaidVal.Text = "₱100";
            // 
            // lblKeyPaid
            // 
            lblKeyPaid.AutoSize = true;
            lblKeyPaid.Font = new Font("Segoe UI", 8.5F);
            lblKeyPaid.ForeColor = Color.FromArgb(160, 168, 178);
            lblKeyPaid.Location = new Point(16, 145);
            lblKeyPaid.Name = "lblKeyPaid";
            lblKeyPaid.Size = new Size(80, 20);
            lblKeyPaid.TabIndex = 9;
            lblKeyPaid.Text = "Paid (cash)";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCost.ForeColor = Color.White;
            lblTotalCost.Location = new Point(215, 115);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(59, 20);
            lblTotalCost.TabIndex = 8;
            lblTotalCost.Text = "₱1,500";
            // 
            // lblKeyTotal
            // 
            lblKeyTotal.AutoSize = true;
            lblKeyTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKeyTotal.ForeColor = Color.White;
            lblKeyTotal.Location = new Point(16, 115);
            lblKeyTotal.Name = "lblKeyTotal";
            lblKeyTotal.Size = new Size(44, 20);
            lblKeyTotal.TabIndex = 7;
            lblKeyTotal.Text = "Total";
            // 
            // lblPartsVal
            // 
            lblPartsVal.AutoSize = true;
            lblPartsVal.ForeColor = Color.White;
            lblPartsVal.Location = new Point(220, 80);
            lblPartsVal.Name = "lblPartsVal";
            lblPartsVal.Size = new Size(53, 20);
            lblPartsVal.TabIndex = 6;
            lblPartsVal.Text = "₱1,200";
            // 
            // lblKeyParts
            // 
            lblKeyParts.AutoSize = true;
            lblKeyParts.ForeColor = Color.FromArgb(160, 168, 178);
            lblKeyParts.Location = new Point(16, 80);
            lblKeyParts.Name = "lblKeyParts";
            lblKeyParts.Size = new Size(40, 20);
            lblKeyParts.TabIndex = 5;
            lblKeyParts.Text = "Parts";
            // 
            // lblLaborVal
            // 
            lblLaborVal.AutoSize = true;
            lblLaborVal.ForeColor = Color.White;
            lblLaborVal.Location = new Point(230, 50);
            lblLaborVal.Name = "lblLaborVal";
            lblLaborVal.Size = new Size(42, 20);
            lblLaborVal.TabIndex = 4;
            lblLaborVal.Text = "₱300";
            // 
            // lblKeyLabor
            // 
            lblKeyLabor.AutoSize = true;
            lblKeyLabor.ForeColor = Color.FromArgb(160, 168, 178);
            lblKeyLabor.Location = new Point(16, 50);
            lblKeyLabor.Name = "lblKeyLabor";
            lblKeyLabor.Size = new Size(47, 20);
            lblKeyLabor.TabIndex = 3;
            lblKeyLabor.Text = "Labor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(130, 140, 150);
            label8.Location = new Point(16, 16);
            label8.Name = "label8";
            label8.Size = new Size(138, 17);
            label8.TabIndex = 2;
            label8.Text = "COST AND PAYMENT";
            // 
            // RepairOrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 37, 43);
            ClientSize = new Size(1102, 653);
            Controls.Add(pnlRightColumn);
            Controls.Add(pnlMiddleColumn);
            Controls.Add(pnlLeftColumn);
            Controls.Add(lblHeaderStatus);
            Controls.Add(pnlStepper);
            Controls.Add(lblOrderTitle);
            MaximizeBox = false;
            Name = "RepairOrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Repair Order Management";
            pnlStepper.ResumeLayout(false);
            step4.ResumeLayout(false);
            step4.PerformLayout();
            step5.ResumeLayout(false);
            step5.PerformLayout();
            step3.ResumeLayout(false);
            step3.PerformLayout();
            step2.ResumeLayout(false);
            step2.PerformLayout();
            step1.ResumeLayout(false);
            step1.PerformLayout();
            pnlLeftColumn.ResumeLayout(false);
            pnlLeftColumn.PerformLayout();
            pnlMiddleColumn.ResumeLayout(false);
            pnlMiddleColumn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPartQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLaborPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHoursWorked).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderParts).EndInit();
            pnlRightColumn.ResumeLayout(false);
            pnlRightColumn.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlStepper;
        private Label lblOrderTitle;
        private Label lblHeaderStatus;
        private Panel step4;
        private Panel step5;
        private Panel step3;
        private Panel step2;
        private Panel step1;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox pnlLeftColumn;
        private Label label6;
        private GroupBox pnlMiddleColumn;
        private Label lblValCustomer;
        private Label lblKeyCustomer;
        private Label lblValAssigned;
        private Label lblKeyAssigned;
        private Label lblValReported;
        private Label lblKeyReported;
        private Label lblValDevice;
        private Label lblKeyDevice;
        private Label lblDiagnosisHeader;
        private TextBox txtDiagnosis;
        private Label label7;
        private Label lblLaborHeader;
        private Label lblPartsFooter;
        private DataGridView dgvOrderParts;
        private TextBox txtLaborDescription;
        private Label lblHoursUnit;
        private NumericUpDown numHoursWorked;
        private Panel pnlRightColumn;
        private NumericUpDown numLaborPrice;
        private Label label8;
        private Label lblLaborVal;
        private Label lblKeyLabor;
        private Label lblPaidVal;
        private Label lblKeyPaid;
        private Label lblTotalCost;
        private Label lblKeyTotal;
        private Label lblPartsVal;
        private Label lblKeyParts;
        private Label lblKeyBalance;
        private Button btnReceivePayment;
        private Label lblBalance;
        private Button btnReleaseDevice;
        private ComboBox cmbAvailableParts;
        private Button btnRemovePart;
        private Button btnAdd;
        private NumericUpDown numPartQty;
        private Button btnUpdateProgress;
    }
}