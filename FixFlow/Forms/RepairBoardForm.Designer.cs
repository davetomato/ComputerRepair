namespace FixFlow.Forms
{
    partial class RepairBoardForm
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
            tblColumns = new TableLayoutPanel();
            lblTitle = new Label();
            panel1 = new Panel();
            pnlReceived = new FlowLayoutPanel();
            pnlDiagnosing = new FlowLayoutPanel();
            pnlWaitingForParts = new FlowLayoutPanel();
            pnlRepairing = new FlowLayoutPanel();
            pnlReadyForPickup = new FlowLayoutPanel();
            pnlReleased = new FlowLayoutPanel();
            tblColumns.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblColumns
            // 
            tblColumns.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblColumns.ColumnCount = 6;
            tblColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblColumns.Controls.Add(pnlReleased, 5, 0);
            tblColumns.Controls.Add(pnlReadyForPickup, 4, 0);
            tblColumns.Controls.Add(pnlRepairing, 3, 0);
            tblColumns.Controls.Add(pnlWaitingForParts, 2, 0);
            tblColumns.Controls.Add(pnlDiagnosing, 1, 0);
            tblColumns.Controls.Add(pnlReceived, 0, 0);
            tblColumns.Location = new Point(20, 75);
            tblColumns.Name = "tblColumns";
            tblColumns.RowCount = 1;
            tblColumns.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblColumns.Size = new Size(1220, 620);
            tblColumns.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(232, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Workflow Board";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 50);
            panel1.TabIndex = 1;
            // 
            // pnlReceived
            // 
            pnlReceived.AutoScroll = true;
            pnlReceived.Dock = DockStyle.Fill;
            pnlReceived.FlowDirection = FlowDirection.TopDown;
            pnlReceived.Location = new Point(3, 3);
            pnlReceived.Name = "pnlReceived";
            pnlReceived.Size = new Size(197, 614);
            pnlReceived.TabIndex = 0;
            pnlReceived.WrapContents = false;
            // 
            // pnlDiagnosing
            // 
            pnlDiagnosing.AutoScroll = true;
            pnlDiagnosing.Dock = DockStyle.Fill;
            pnlDiagnosing.FlowDirection = FlowDirection.TopDown;
            pnlDiagnosing.Location = new Point(206, 3);
            pnlDiagnosing.Name = "pnlDiagnosing";
            pnlDiagnosing.Size = new Size(197, 614);
            pnlDiagnosing.TabIndex = 1;
            pnlDiagnosing.WrapContents = false;
            // 
            // pnlWaitingForParts
            // 
            pnlWaitingForParts.AutoScroll = true;
            pnlWaitingForParts.Dock = DockStyle.Fill;
            pnlWaitingForParts.FlowDirection = FlowDirection.TopDown;
            pnlWaitingForParts.Location = new Point(409, 3);
            pnlWaitingForParts.Name = "pnlWaitingForParts";
            pnlWaitingForParts.Size = new Size(197, 614);
            pnlWaitingForParts.TabIndex = 2;
            pnlWaitingForParts.WrapContents = false;
            // 
            // pnlRepairing
            // 
            pnlRepairing.AutoScroll = true;
            pnlRepairing.Dock = DockStyle.Fill;
            pnlRepairing.FlowDirection = FlowDirection.TopDown;
            pnlRepairing.Location = new Point(612, 3);
            pnlRepairing.Name = "pnlRepairing";
            pnlRepairing.Size = new Size(197, 614);
            pnlRepairing.TabIndex = 3;
            pnlRepairing.WrapContents = false;
            // 
            // pnlReadyForPickup
            // 
            pnlReadyForPickup.AutoScroll = true;
            pnlReadyForPickup.Dock = DockStyle.Fill;
            pnlReadyForPickup.FlowDirection = FlowDirection.TopDown;
            pnlReadyForPickup.Location = new Point(815, 3);
            pnlReadyForPickup.Name = "pnlReadyForPickup";
            pnlReadyForPickup.Size = new Size(197, 614);
            pnlReadyForPickup.TabIndex = 4;
            pnlReadyForPickup.WrapContents = false;
            // 
            // pnlReleased
            // 
            pnlReleased.AutoScroll = true;
            pnlReleased.Dock = DockStyle.Fill;
            pnlReleased.FlowDirection = FlowDirection.TopDown;
            pnlReleased.Location = new Point(1018, 3);
            pnlReleased.Name = "pnlReleased";
            pnlReleased.Size = new Size(199, 614);
            pnlReleased.TabIndex = 5;
            pnlReleased.WrapContents = false;
            // 
            // RepairBoardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 37, 43);
            ClientSize = new Size(1262, 673);
            Controls.Add(tblColumns);
            Controls.Add(panel1);
            Name = "RepairBoardForm";
            Text = "Workflow Board";
            tblColumns.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tblColumns;
        private Label lblTitle;
        private Panel panel1;
        private FlowLayoutPanel pnlReleased;
        private FlowLayoutPanel pnlReadyForPickup;
        private FlowLayoutPanel pnlRepairing;
        private FlowLayoutPanel pnlWaitingForParts;
        private FlowLayoutPanel pnlDiagnosing;
        private FlowLayoutPanel pnlReceived;
    }
}