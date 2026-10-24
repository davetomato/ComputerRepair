using FixFlow.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FixFlow.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            SetRoundedCorners(cardPanel, 16);

            SetRoundedCorners(pnlUsername, 10);
            SetRoundedCorners(pnlPassword, 10);

            SetRoundedCorners(btnLogin, 10);

            txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.FromArgb(120, 120, 120);

            txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.FromArgb(120, 120, 120);
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "Username" || string.IsNullOrEmpty(username) ||
                password == "Password" || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter your username and password.";
                lblError.ForeColor = Color.Red;
                return;
            }

            AuthService authService = new AuthService();
            var user = authService.Login(txtUsername.Text, txtPassword.Text);

            if (user != null)
            {
                MainDashboard mainDashboard = new MainDashboard(user);
                this.Hide();
                mainDashboard.ShowDialog();
                this.Close();
            }
            else
            {
                lblError.Text = "Invalid username or password.";
                lblError.ForeColor = Color.Red;
            }
        }

        private void SetRoundedCorners(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            control.Region = new Region(path);
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.White;
            }

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.FromArgb(120, 120, 120);
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.FromArgb(120, 120, 120);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LandingForm landingForm = new LandingForm();
            this.Hide();
            landingForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private bool isPasswordVisible = false;

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password") return;

            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtPassword.UseSystemPasswordChar = false; 
                btnTogglePassword.Text = "🔒"; 
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;  
                btnTogglePassword.Text = "👁"; 
            }
        }
    }
}
