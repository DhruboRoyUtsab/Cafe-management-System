using CMS.Admin;
using CMS.Assets;
using CMS.Waiter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CMS
{
    public partial class WaiterSignIn : Form
    {
        public WaiterSignIn()
        {
            InitializeComponent();
        }




        private void BckBtn_Click(object sender, EventArgs e)
        {
            Homepage hm = new Homepage();
            hm.Show();
            this.Hide();
        }

        private void BtnWaiterSIgnIn_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
            this.Hide();
        }

        private void WaiterSignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
