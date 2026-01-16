using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Cashier
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPaymentNext_Click(object sender, EventArgs e)
        {
            if (rbtnCashPay.Checked)
            {
                CashPay cashForm = new CashPay();
                cashForm.Show();
                this.Hide();   
            }
            else if (rbtnCardPay.Checked)
            {
                CardPay cardForm = new CardPay();
                cardForm.Show();
                this.Hide();   
            }
            else
            {
                MessageBox.Show(
                    "Please select a payment method.",
                    "Payment Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnPaymentBack_Click(object sender, EventArgs e)
        {
            PaymentHistory historyForm = new PaymentHistory();
            historyForm.Show();
            this.Close();   
        }

    }
}
