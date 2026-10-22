using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FixFlow.Forms
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Normal;

            SetRoundedCorners(btnGetStarted, 10);
            SetRoundedCorners(btnSignIn, 10);
            SetRoundedCorners(cardRecord, 12);
            SetRoundedCorners(cardCosting, 12);
            SetRoundedCorners(cardReports, 12);

            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.FlatAppearance.BorderSize = 2;
            btnSignIn.FlatAppearance.BorderColor = Color.FromArgb(26, 188, 156);
            btnSignIn.BackColor = Color.FromArgb(40, 44, 52); 
            btnSignIn.ForeColor = Color.FromArgb(26, 188, 156);

            btnGetStarted.FlatStyle = FlatStyle.Flat;
            btnGetStarted.FlatAppearance.BorderSize = 0;
            btnGetStarted.BackColor = Color.FromArgb(26, 188, 156);
            btnGetStarted.ForeColor = Color.FromArgb(33, 37, 43);

            btnSignIn.Click += OpenLogin;
            btnGetStarted.Click += OpenLogin;
        }

        private void OpenLogin(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void SetRoundedCorners(Control control, int radius)
        {
            if (control.Width == 0 || control.Height == 0) return;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            control.Region = new Region(path);
        }
    }
}