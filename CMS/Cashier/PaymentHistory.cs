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
    public partial class PaymentHistory : Form
    {
        public PaymentHistory()
        {
            InitializeComponent();
        }

        private void btnTakePayment_Click(object sender, EventArgs e)
        {
            Payment paymentForm = new Payment();
            paymentForm.Show();      
            this.Hide();
        }


        private void btnPaymentHistoryBack_Click(object sender, EventArgs e)
        {
            CashierSignIn signInForm = new CashierSignIn();
            signInForm.Show();
            this.Hide();
        }


        private void btnPayDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnPaymentHistoryShow_Click(object sender, EventArgs e)
        {

        }

        private void gvAllPay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
