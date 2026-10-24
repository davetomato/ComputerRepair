namespace FixFlow.Forms
{
    partial class MainDashboard
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
            pnlContainer = new Panel();
            pnlSidebar = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            lblUserSession = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(33, 37, 43);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(250, 50);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(550, 400);
            pnlContainer.TabIndex = 5;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(30, 34, 39);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 50);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 400);
            pnlSidebar.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 38);
            label1.TabIndex = 0;
            label1.Text = "FixFlow";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 34, 39);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblUserSession);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 3;
            // 
            // lblUserSession
            // 
            lblUserSession.AutoSize = true;
            lblUserSession.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserSession.ForeColor = Color.White;
            lblUserSession.Location = new Point(150, 18);
            lblUserSession.Name = "lblUserSession";
            lblUserSession.Size = new Size(50, 20);
            lblUserSession.TabIndex = 0;
            lblUserSession.Text = "label1";
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 37, 43);
            ClientSize = new Size(800, 450);
            Controls.Add(pnlContainer);
            Controls.Add(pnlSidebar);
            Controls.Add(panel1);
            Name = "MainDashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Panel pnlSidebar;
        private Panel panel1;
        private Label lblUserSession;
        private Label label1;
    }
}