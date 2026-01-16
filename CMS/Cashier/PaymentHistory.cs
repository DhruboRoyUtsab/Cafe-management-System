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

        private void PaymentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CurrentOrder_Click(object sender, EventArgs e)
        {
            CurrentOrder currentOrder = new CurrentOrder();
            currentOrder.Show();
            this.Hide();
        }
    }
}
