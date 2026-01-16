using CMS.Assets;
using CMS.Cashier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class CashierSignIn : Form
    {
        public CashierSignIn()
        {
            InitializeComponent();
        }

        private void cbCashierShowPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BckBtn_Click(object sender, EventArgs e)
        {
            Homepage hm = new Homepage();
            hm.Show();
            this.Hide();
        }

        private void btnCashierSignIn_Click(object sender, EventArgs e)
        {
            PaymentHistory paymentHistory = new PaymentHistory();
            paymentHistory.Show();
            this.Hide();
        }
    }
}
