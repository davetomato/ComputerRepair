using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace FixFlow.UI
{
    public static class Theme
    {
        public static readonly Color Background = Color.FromArgb(33, 37, 43);
        public static readonly Color Card = Color.FromArgb(40, 44, 52);
        public static readonly Color Border = Color.FromArgb(55, 61, 72);
        public static readonly Color Input = Color.FromArgb(33, 37, 43);
        public static readonly Color RowSelected = Color.FromArgb(48, 54, 64);
        public static readonly Color Accent = Color.FromArgb(26, 188, 156);
        public static readonly Color TextOnAccent = Color.FromArgb(33, 37, 43);
        public static readonly Color Text = Color.FromArgb(220, 225, 230);
        public static readonly Color Muted = Color.FromArgb(160, 168, 178);
        public static readonly Color Danger = Color.FromArgb(231, 76, 60);

        public static GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = Math.Min(radius * 2, Math.Min(r.Width, r.Height));
            if (d < 2) { path.AddRectangle(r); return path; }
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Rounds a control with a Region. radius 0 = pill shape (height / 2).
        public static void Round(Control c, int radius)
        {
            bool first = c.Region == null;
            Action apply = () =>
            {
                if (c.Width <= 0 || c.Height <= 0) return;
                int r = radius <= 0 ? c.Height / 2 : radius;
                using (GraphicsPath p = RoundedRect(new Rectangle(0, 0, c.Width, c.Height), r))
                    c.Region = new Region(p);
            };
            apply();
            if (first) c.SizeChanged += (s, e) => apply();
        }

        public static Label MakeLabel(string text, int x, int y, float size, bool bold, Color color)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                Location = new Point(x, y),
                ForeColor = color,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", size, bold ? FontStyle.Bold : FontStyle.Regular)
            };
        }

        // ---------- Buttons ----------
        private static void FlatBase(Button b)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.UseVisualStyleBackColor = false;
            b.Cursor = Cursors.Hand;
            b.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        }

        public static void StylePrimary(Button b)
        {
            FlatBase(b);
            b.BackColor = Accent;
            b.ForeColor = TextOnAccent;
            b.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 205, 172);
            b.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 160, 133);
            Round(b, 8);
        }

        public static void StyleSecondary(Button b, Color fore)
        {
            FlatBase(b);
            b.BackColor = Border;
            b.ForeColor = fore;
            b.FlatAppearance.MouseOverBackColor = RowSelected;
            b.FlatAppearance.MouseDownBackColor = Card;
            Round(b, 8);
        }

        public static void StyleChip(Button b, bool active)
        {
            FlatBase(b);
            b.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            b.BackColor = active ? Accent : Border;
            b.ForeColor = active ? TextOnAccent : Accent;
            b.FlatAppearance.MouseOverBackColor = active ? Accent : RowSelected;
            b.FlatAppearance.MouseDownBackColor = active ? Accent : RowSelected;
            Round(b, 0);
        }

        public static void StyleCombo(ComboBox c)
        {
            c.DropDownStyle = ComboBoxStyle.DropDownList;
            c.FlatStyle = FlatStyle.Flat;
            c.BackColor = Input;
            c.ForeColor = Color.White;
            c.Font = new Font("Segoe UI", 10f);
        }

        // ---------- Grid ----------
        public static void StyleGrid(DataGridView g)
        {
            g.BackgroundColor = Card;
            g.BorderStyle = BorderStyle.None;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.GridColor = Border;
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            g.EnableHeadersVisualStyles = false;
            g.RowHeadersVisible = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.AllowUserToResizeColumns = false;
            g.ReadOnly = true;
            g.MultiSelect = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 40;
            g.RowTemplate.Height = 44;

            DataGridViewCellStyle head = g.ColumnHeadersDefaultCellStyle;
            head.BackColor = Card; head.ForeColor = Muted;
            head.SelectionBackColor = Card; head.SelectionForeColor = Muted;
            head.Font = new Font("Segoe UI", 9.5f);
            head.Padding = new Padding(8, 0, 0, 0);

            DataGridViewCellStyle cell = g.DefaultCellStyle;
            cell.BackColor = Card; cell.ForeColor = Text;
            cell.SelectionBackColor = RowSelected; cell.SelectionForeColor = Color.White;
            cell.Font = new Font("Segoe UI", 9.5f);
            cell.Padding = new Padding(8, 0, 0, 0);
        }

        // Draws a pill badge in a grid cell (Paid / Unpaid / Partial / Low / In stock...)
        public static void PaintBadgeCell(DataGridView grid, DataGridViewCellPaintingEventArgs e, string columnName)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.Value == null) return;
            if (grid.Columns[e.ColumnIndex].Name != columnName) return;

            string text = e.Value.ToString();
            Color back, fore;
            switch (text)
            {
                case "Paid":
                case "In stock":
                    back = Color.FromArgb(183, 235, 200); fore = Color.FromArgb(22, 90, 50); break;
                case "Unpaid":
                case "Low":
                case "Out":
                    back = Color.FromArgb(244, 183, 183); fore = Color.FromArgb(122, 28, 28); break;
                case "Partial":
                    back = Color.FromArgb(250, 222, 130); fore = Color.FromArgb(110, 80, 10); break;
                default:
                    back = Border; fore = Text; break;
            }

            e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border
                                | DataGridViewPaintParts.SelectionBackground);
            using (Font font = new Font("Segoe UI", 8f, FontStyle.Bold))
            {
                Size size = TextRenderer.MeasureText(text, font);
                int h = 22, w = size.Width + 18;
                Rectangle r = new Rectangle(e.CellBounds.X + 8, e.CellBounds.Y + (e.CellBounds.Height - h) / 2, w, h);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath p = RoundedRect(r, h / 2))
                using (SolidBrush br = new SolidBrush(back))
                    e.Graphics.FillPath(br, p);
                TextRenderer.DrawText(e.Graphics, text, font, r, fore,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
            }
            e.Handled = true;
        }
    }

    // ===== Rounded dark card =====
    public class CardPanel : Panel
    {
        public CardPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Theme.Card;
            ForeColor = Theme.Text;
            Padding = new Padding(16);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Parent != null ? Parent.BackColor : Theme.Background);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = Theme.RoundedRect(new Rectangle(0, 0, Width - 1, Height - 1), 12))
            using (SolidBrush fill = new SolidBrush(BackColor))
            using (Pen pen = new Pen(Theme.Border))
            {
                e.Graphics.FillPath(fill, path);
                e.Graphics.DrawPath(pen, path);
            }
        }
    }

    // ===== Dark rounded text box with placeholder =====
    public class InputBox : Panel
    {
        private readonly TextBox _tb = new TextBox();
        private bool _focused;

        public InputBox()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            Size = new Size(200, 40);
            BackColor = Theme.Input;
            _tb.BorderStyle = BorderStyle.None;
            _tb.BackColor = Theme.Input;
            _tb.ForeColor = Color.White;
            _tb.Font = new Font("Segoe UI", 10f);
            _tb.Enter += (s, e) => { _focused = true; Invalidate(); };
            _tb.Leave += (s, e) => { _focused = false; Invalidate(); };
            _tb.TextChanged += (s, e) => OnTextChanged(e);
            Controls.Add(_tb);
            Click += (s, e) => _tb.Focus();
        }

        [Browsable(false)]
        public TextBox Inner { get { return _tb; } }

        [Browsable(true), DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get { return _tb.Text; }
            set { _tb.Text = value; }
        }

        [DefaultValue("")]
        public string PlaceholderText
        {
            get { return _tb.PlaceholderText; }
            set { _tb.PlaceholderText = value; }
        }

        public void Clear() { _tb.Clear(); }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            _tb.Location = new Point(12, Math.Max(0, (Height - _tb.Height) / 2));
            _tb.Width = Math.Max(10, Width - 24);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Parent != null ? Parent.BackColor : Theme.Card);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = Theme.RoundedRect(new Rectangle(0, 0, Width - 1, Height - 1), 8))
            using (SolidBrush fill = new SolidBrush(Theme.Input))
            using (Pen pen = new Pen(_focused ? Theme.Accent : Theme.Border))
            {
                e.Graphics.FillPath(fill, path);
                e.Graphics.DrawPath(pen, path);
            }
        }
    }

    // ===== Simple teal bar chart (no extra packages needed) =====
    // ===== Simple teal bar chart (no extra packages needed) =====
    public class BarChart : Control
    {
        private List<KeyValuePair<string, decimal>> _items = new List<KeyValuePair<string, decimal>>();

        [Browsable(true)]
        [DefaultValue(false)]
        public bool IsCurrency { get; set; }

        public BarChart()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Theme.Card;
            ForeColor = Theme.Muted;
            Font = new Font("Segoe UI", 8.5f);
        }

        public void SetData(IEnumerable<KeyValuePair<string, decimal>> data)
        {
            _items = data.ToList();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(BackColor);
            if (_items.Count == 0)
            {
                TextRenderer.DrawText(g, "No data for this period", Font, ClientRectangle, ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                return;
            }

            g.SmoothingMode = SmoothingMode.AntiAlias;
            int valueH = 22, labelH = 24;
            Rectangle plot = new Rectangle(0, valueH, Width, Math.Max(10, Height - valueH - labelH));
            decimal max = _items.Max(i => i.Value);
            if (max <= 0) max = 1;

            float slot = (float)Width / _items.Count;
            float barW = Math.Min(64f, slot * 0.6f);

            for (int i = 0; i < _items.Count; i++)
            {
                decimal v = _items[i].Value;
                float h = (float)(v / max) * plot.Height;
                if (v > 0 && h < 3) h = 3;
                int x = (int)(i * slot + (slot - barW) / 2);
                Rectangle bar = new Rectangle(x, plot.Bottom - (int)h, (int)barW, (int)h);

                using (GraphicsPath p = Theme.RoundedRect(bar, 6))
                using (SolidBrush br = new SolidBrush(Theme.Accent))
                    g.FillPath(br, p);

                string valueText = IsCurrency ? "₱" + v.ToString("#,##0") : v.ToString("#,##0.##");
                TextRenderer.DrawText(g, valueText, Font,
                    new Rectangle((int)(i * slot), bar.Top - valueH, (int)slot, valueH),
                    Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.Bottom);

                TextRenderer.DrawText(g, _items[i].Key, Font,
                    new Rectangle((int)(i * slot), plot.Bottom + 4, (int)slot, labelH),
                    ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);
            }
        }
    }
}