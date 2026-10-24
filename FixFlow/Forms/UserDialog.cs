using System;
using System.Drawing;
using System.Windows.Forms;
using FixFlow.Models;
using FixFlow.Services;
using FixFlow.UI;

namespace FixFlow.Forms
{
    public class UserDialog : Form
    {
        private readonly AuthService _auth = new AuthService();
        private readonly InputBox txtUser = new InputBox();
        private readonly InputBox txtPass = new InputBox();
        private readonly ComboBox cmbRole = new ComboBox();

        public UserDialog()
        {
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScaleDimensions = new SizeF(96f, 96f);
            Text = "New User";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            BackColor = Theme.Card;
            ForeColor = Theme.Text;

            Controls.Add(Theme.MakeLabel("New user account", 24, 20, 12f, true, Color.White));

            Controls.Add(Theme.MakeLabel("USERNAME", 24, 66, 8.5f, true, Theme.Muted));
            txtUser.Location = new Point(24, 88);
            txtUser.Size = new Size(332, 40);
            Controls.Add(txtUser);

            Controls.Add(Theme.MakeLabel("PASSWORD (6+ characters)", 24, 140, 8.5f, true, Theme.Muted));
            txtPass.Location = new Point(24, 162);
            txtPass.Size = new Size(332, 40);
            txtPass.Inner.UseSystemPasswordChar = true;
            Controls.Add(txtPass);

            Controls.Add(Theme.MakeLabel("ROLE", 24, 214, 8.5f, true, Theme.Muted));
            cmbRole.Location = new Point(24, 236);
            cmbRole.Size = new Size(332, 28);
            cmbRole.DataSource = Enum.GetValues(typeof(UserRole));
            Theme.StyleCombo(cmbRole);
            Controls.Add(cmbRole);

            Button btnCreate = new Button { Text = "Create User", Location = new Point(24, 296), Size = new Size(180, 42) };
            Button btnCancel = new Button { Text = "Cancel", Location = new Point(216, 296), Size = new Size(140, 42) };
            Theme.StylePrimary(btnCreate);
            Theme.StyleSecondary(btnCancel, Theme.Text);
            btnCreate.Click += btnCreate_Click;
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; };
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);

            AcceptButton = btnCreate;
            CancelButton = btnCancel;
            ClientSize = new Size(380, 360);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                UserRole role = (UserRole)cmbRole.SelectedItem;
                _auth.CreateUser(role, txtUser.Text.Trim(), txtPass.Text);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Cannot create user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}