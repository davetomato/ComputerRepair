using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FixFlow.Models;
using FixFlow.Services;

namespace FixFlow.Forms
{
    public partial class MainDashboard : Form
    {
        private readonly User _currentUser;

        // Constructor accepting the logged-in user object
        public MainDashboard(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser ?? Session.CurrentUser;
            this.Load += MainDashboard_Load;
        }

        // Parameterless constructor for fallback / designer
        public MainDashboard() : this(Session.CurrentUser)
        {
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            if (_currentUser == null && !Session.IsLoggedIn)
            {
                MessageBox.Show("No active session found. Please log in.", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            lblUserSession.Text = $"Logged in as: {Session.CurrentUser.Username} ({Session.CurrentUser.Role})";


            this.WindowState = FormWindowState.Maximized;

            if (_currentUser != null)
            {
                // 1. Ensure the label belongs to the sidebar and is brought to the fron

                BuildSidebarMenu();
                LoadDefaultView();
            }
        }

        private Button _activeNavButton = null;
        private void BuildSidebarMenu()
        {
            if (pnlSidebar == null) return;

            pnlSidebar.Controls.Clear();

            IList<string> allowedMenus = _currentUser.GetAllowedMenus();

            int topPosition = 80; // Start below top branding
            foreach (string menuName in allowedMenus)
            {
                Button btn = new Button();
                btn.Text = menuName;
                btn.Width = pnlSidebar.Width - 30;
                btn.Height = 40;
                btn.Left = 15;
                btn.Top = topPosition;

                // Modern Flat Styling
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(30, 34, 39);      // Dark charcoal background
                btn.ForeColor = Color.FromArgb(160, 168, 178);   // Muted grey text
                btn.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.MiddleLeft;     // Left-aligned text
                btn.Padding = new Padding(10, 0, 0, 0);          // Slight left padding
                btn.Cursor = Cursors.Hand;
                btn.Tag = menuName;

                // Hover Effects (Turns slightly lighter grey on hover unless it's the active tab)
                btn.MouseEnter += (s, e) => {
                    if (btn != _activeNavButton)
                    {
                        btn.BackColor = Color.FromArgb(40, 44, 52);
                        btn.ForeColor = Color.White;
                    }
                };

                btn.MouseLeave += (s, e) => {
                    if (btn != _activeNavButton)
                    {
                        btn.BackColor = Color.FromArgb(30, 34, 39);
                        btn.ForeColor = Color.FromArgb(160, 168, 178);
                    }
                };

                btn.Click += MenuButton_Click;

                pnlSidebar.Controls.Add(btn);
                topPosition += 53; // Equal vertical spacing gap
            }

            // Automatically highlight the first button by default if available
            if (pnlSidebar.Controls.Count > 0 && pnlSidebar.Controls[0] is Button firstBtn)
            {
                SetActiveButton(firstBtn);
            }
        }

        private void SetActiveButton(Button clickedButton)
        {
            // Reset previous active button style back to normal dark
            if (_activeNavButton != null)
            {
                _activeNavButton.BackColor = Color.FromArgb(30, 34, 39);
                _activeNavButton.ForeColor = Color.FromArgb(160, 168, 178);
            }

            // Set new active button style to Teal Accent
            _activeNavButton = clickedButton;
            _activeNavButton.BackColor = Color.FromArgb(26, 188, 156); // Teal background (#1ABC9C)
            _activeNavButton.ForeColor = Color.FromArgb(33, 37, 43);   // Dark text for contrast
        }

        private void LoadDefaultView()
        {
            LoadFormIntoContainer(new RepairBoardForm());
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Highlight this button with the teal indicator
            SetActiveButton(btn);

            string menu = btn.Tag.ToString();

            Form targetForm = null;
            switch (menu)
            {
                case "Workflow Board":
                case "Repair Board":
                    targetForm = new RepairBoardForm();
                    break;
                case "Repair Orders":
                    targetForm = new RepairOrdersForm(); // Swap this if you have a tabular grid form for orders!
                    break;
                case "Customers & Devices":
                case "Customers and Devices":
                    targetForm = new CustomersDevicesForm();
                    break;
                case "Parts":
                case "Parts Inventory":
                    targetForm = new PartsForm();
                    break;
                case "Payments":
                    targetForm = new PaymentsForm();
                    break;
                case "Reports":
                    targetForm = new ReportsForm();
                    break;
                case "Users":
                case "Users & Rates":
                    targetForm = new UsersForm();
                    break;
                case "Service Rates":
                    targetForm = new ServiceRatesForm();
                    break;
            }

            if (targetForm != null)
            {
                LoadFormIntoContainer(targetForm);
            }
            else
            {
                MessageBox.Show($"The form for '{menu}' is not yet linked.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadFormIntoContainer(Form targetForm)
        {
            if (pnlContainer == null) return;

            pnlContainer.Controls.Clear();
            targetForm.TopLevel = false;
            targetForm.FormBorderStyle = FormBorderStyle.None;
            targetForm.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(targetForm);
            targetForm.Show();
        }
    }
}