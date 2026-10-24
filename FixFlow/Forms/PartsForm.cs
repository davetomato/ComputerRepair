using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using FixFlow.Models;
using FixFlow.Services;
using FixFlow.UI;

namespace FixFlow.Forms
{
    public partial class PartsForm : Form
    {
        private const int LowStockLevel = 3;
        private readonly PartService _partService = new PartService();
        private List<Part> _parts;
        private int _selectedPartId = 0;

        public PartsForm()
        {
            InitializeComponent();

            Theme.StyleGrid(dgvParts);
            Theme.StylePrimary(btnAddPart);
            Theme.StylePrimary(btnSave);
            Theme.StyleSecondary(btnDelete, Theme.Danger);

            dgvParts.CellClick += dgvParts_CellClick;
            dgvParts.CellPainting += (s, e) => Theme.PaintBadgeCell(dgvParts, e, "Status");
            txtSearch.TextChanged += (s, e) => Render();
            btnAddPart.Click += (s, e) => { NewPart(); txtName.Focus(); };
            btnSave.Click += btnSave_Click;
            btnDelete.Click += btnDelete_Click;
            Load += PartsForm_Load;
        }

        private void PartsForm_Load(object sender, EventArgs e)
        {
            // Only the administrator may change parts (PartService rule)
            bool isAdmin = Session.IsInRole(UserRole.Administrator);
            btnAddPart.Visible = isAdmin;
            cardEdit.Visible = isAdmin;
            if (!isAdmin) tblMain.ColumnStyles[1].Width = 0;

            LoadParts();
        }

        private void LoadParts()
        {
            try
            {
                _parts = _partService.GetAll();
                Render();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Parts", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Render()
        {
            if (_parts == null) return;
            string term = txtSearch.Text.Trim();

            DataTable t = new DataTable();
            t.Columns.Add("PartId", typeof(int));
            t.Columns.Add("Part", typeof(string));
            t.Columns.Add("Stock", typeof(int));
            t.Columns.Add("Price", typeof(decimal));
            t.Columns.Add("Status", typeof(string));

            foreach (Part p in _parts)
            {
                if (term.Length > 0 && p.Name.IndexOf(term, StringComparison.OrdinalIgnoreCase) < 0)
                    continue;
                string status = p.Stock == 0 ? "Out" : (p.Stock <= LowStockLevel ? "Low" : "In stock");
                t.Rows.Add(p.PartId, p.Name, p.Stock, p.Price, status);
            }

            dgvParts.DataSource = t;
            dgvParts.Columns["PartId"].Visible = false;
            dgvParts.Columns["Price"].DefaultCellStyle.Format = "₱#,##0.00";
        }

        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = Convert.ToInt32(dgvParts.Rows[e.RowIndex].Cells["PartId"].Value);
            Part part = _parts.Find(p => p.PartId == id);
            if (part == null) return;

            _selectedPartId = part.PartId;
            txtName.Text = part.Name;
            txtStock.Text = part.Stock.ToString();
            txtPrice.Text = part.Price.ToString("0.00");
        }

        private void NewPart()
        {
            _selectedPartId = 0;
            txtName.Clear();
            txtStock.Clear();
            txtPrice.Clear();
            dgvParts.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int stock;
            decimal price;
            if (!int.TryParse(txtStock.Text.Trim(), out stock) || stock < 0)
            {
                MessageBox.Show("Stock must be a whole number, 0 or more.", "Check input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPrice.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out price) || price < 0)
            {
                MessageBox.Show("Price must be a number, 0 or more.", "Check input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_selectedPartId == 0)
                    _partService.Add(txtName.Text, price, stock);
                else
                    _partService.Update(_selectedPartId, txtName.Text, price, stock);

                NewPart();
                LoadParts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could not save part", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedPartId == 0)
            {
                MessageBox.Show("Select a part from the list first.", "Selection required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Delete this part?", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                _partService.Delete(_selectedPartId);
                NewPart();
                LoadParts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deletion blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}