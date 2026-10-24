namespace FixFlow.Forms
{
    partial class PartsForm
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
            btnAddPart = new Button();
            txtSearch = new TextBox();
            lblTitle = new Label();
            pnlHeaderLine = new Panel();
            pnlBody = new Panel();
            tblMain = new TableLayoutPanel();
            cardList = new Panel();
            dgvParts = new DataGridView();
            lblListTitle = new Label();
            cardEdit = new Panel();
            btnDelete = new Button();
            btnSave = new Button();
            lblEditTitle = new Label();
            txtName = new FixFlow.UI.InputBox();
            txtStock = new FixFlow.UI.InputBox();
            txtPrice = new FixFlow.UI.InputBox();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            tblMain.SuspendLayout();
            cardList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParts).BeginInit();
            cardEdit.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(40, 44, 52);
            pnlHeader.Controls.Add(btnAddPart);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(pnlHeaderLine);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1012, 64);
            pnlHeader.TabIndex = 0;
            // 
            // btnAddPart
            // 
            btnAddPart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddPart.Location = new Point(876, 13);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(130, 38);
            btnAddPart.TabIndex = 3;
            btnAddPart.Text = "+ Add Part";
            btnAddPart.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(584, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search part";
            txtSearch.Size = new Size(280, 27);
            txtSearch.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(219, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Parts Inventory";
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
            pnlBody.Controls.Add(tblMain);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 64);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(24);
            pnlBody.Size = new Size(1012, 559);
            pnlBody.TabIndex = 1;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 364F));
            tblMain.Controls.Add(cardList, 0, 0);
            tblMain.Controls.Add(cardEdit, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(24, 24);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(964, 511);
            tblMain.TabIndex = 0;
            // 
            // cardList
            // 
            cardList.Controls.Add(dgvParts);
            cardList.Controls.Add(lblListTitle);
            cardList.Dock = DockStyle.Fill;
            cardList.Location = new Point(0, 0);
            cardList.Margin = new Padding(0);
            cardList.Name = "cardList";
            cardList.Padding = new Padding(16, 52, 16, 16);
            cardList.Size = new Size(600, 511);
            cardList.TabIndex = 0;
            // 
            // dgvParts
            // 
            dgvParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParts.Dock = DockStyle.Fill;
            dgvParts.Location = new Point(16, 52);
            dgvParts.Name = "dgvParts";
            dgvParts.RowHeadersWidth = 51;
            dgvParts.Size = new Size(568, 443);
            dgvParts.TabIndex = 1;
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListTitle.ForeColor = Color.FromArgb(160, 168, 178);
            lblListTitle.Location = new Point(20, 18);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(55, 20);
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "PARTS";
            // 
            // cardEdit
            // 
            cardEdit.Controls.Add(txtPrice);
            cardEdit.Controls.Add(txtStock);
            cardEdit.Controls.Add(txtName);
            cardEdit.Controls.Add(btnDelete);
            cardEdit.Controls.Add(btnSave);
            cardEdit.Controls.Add(lblEditTitle);
            cardEdit.Dock = DockStyle.Fill;
            cardEdit.Location = new Point(624, 0);
            cardEdit.Margin = new Padding(24, 0, 0, 0);
            cardEdit.Name = "cardEdit";
            cardEdit.Padding = new Padding(20);
            cardEdit.Size = new Size(340, 511);
            cardEdit.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(176, 214);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 42);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(20, 214);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 42);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save Part";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblEditTitle
            // 
            lblEditTitle.AutoSize = true;
            lblEditTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditTitle.ForeColor = Color.FromArgb(160, 168, 178);
            lblEditTitle.Location = new Point(20, 18);
            lblEditTitle.Name = "lblEditTitle";
            lblEditTitle.Size = new Size(132, 20);
            lblEditTitle.TabIndex = 1;
            lblEditTitle.Text = "ADD / EDIT PART";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(33, 37, 43);
            txtName.Location = new Point(20, 52);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Part name";
            txtName.Size = new Size(300, 40);
            txtName.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.FromArgb(33, 37, 43);
            txtStock.Location = new Point(20, 104);
            txtStock.Name = "txtStock";
            txtStock.PlaceholderText = "Stock quantity";
            txtStock.Size = new Size(300, 40);
            txtStock.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(33, 37, 43);
            txtPrice.Location = new Point(20, 156);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price (₱)";
            txtPrice.Size = new Size(300, 40);
            txtPrice.TabIndex = 9;
            // 
            // PartsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 37, 43);
            ClientSize = new Size(1012, 623);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "PartsForm";
            Text = "Parts Inventory";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            tblMain.ResumeLayout(false);
            cardList.ResumeLayout(false);
            cardList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParts).EndInit();
            cardEdit.ResumeLayout(false);
            cardEdit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlHeaderLine;
        private Label lblTitle;
        private Panel pnlBody;
        private TableLayoutPanel tblMain;
        private Button btnAddPart;
        private TextBox txtSearch;
        private Panel cardList;
        private Panel cardEdit;
        private DataGridView dgvParts;
        private Label lblListTitle;
        private Label lblEditTitle;
        private Button btnDelete;
        private Button btnSave;
        private UI.InputBox txtPrice;
        private UI.InputBox txtStock;
        private UI.InputBox txtName;
    }
}