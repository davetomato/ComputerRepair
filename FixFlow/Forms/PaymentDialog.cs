using System;
using System.Drawing;
using System.Windows.Forms;
using FixFlow.Services;
using FixFlow.UI;

namespace FixFlow.Forms
{
    public class PaymentDialog : Form
    {
        private readonly BillingService _billing = new BillingService();
        private readonly int _orderId;
        private readonly InputBox txtAmount = new InputBox();

        public PaymentDialog(int orderId, string customer, decimal balance)
        {
            _orderId = orderId;

            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScaleDimensions = new SizeF(96f, 96f);
            Text = "Receive Payment";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            BackColor = Theme.Card;
            ForeColor = Theme.Text;

            Controls.Add(Theme.MakeLabel("RO-" + orderId.ToString("D4") + "  ·  " + customer, 24, 20, 12f, true, Color.White));
            Controls.Add(Theme.MakeLabel("Balance due: " + balance.ToString("₱#,##0.00"), 24, 54, 9.5f, false, Theme.Muted));
            Controls.Add(Theme.MakeLabel("AMOUNT RECEIVED", 24, 96, 8.5f, true, Theme.Muted));

            txtAmount.Location = new Point(24, 120);
            txtAmount.Size = new Size(332, 40);
            txtAmount.Text = balance.ToString("0.00");
            Controls.Add(txtAmount);

            Button btnOk = new Button { Text = "Record Payment", Location = new Point(24, 190), Size = new Size(180, 42) };
            Button btnCancel = new Button { Text = "Cancel", Location = new Point(216, 190), Size = new Size(140, 42) };
            Theme.StylePrimary(btnOk);
            Theme.StyleSecondary(btnCancel, Theme.Text);
            btnOk.Click += btnOk_Click;
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; };
            Controls.Add(btnOk);
            Controls.Add(btnCancel);

            AcceptButton = btnOk;
            CancelButton = btnCancel;
            ClientSize = new Size(380, 256);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (!decimal.TryParse(txtAmount.Text.Trim(), out amount))
            {
                MessageBox.Show(this, "Enter a valid amount.", "Check input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                _billing.RecordPayment(_orderId, amount);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Payment blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}