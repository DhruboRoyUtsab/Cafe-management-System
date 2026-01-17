using CMS.Chef;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Assets
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSignIn ad = new AdminSignIn();
            ad.Show();
            this.Hide();
        }

        private void CBtn_Click(object sender, EventArgs e)
        {
            CashierSignIn cs = new CashierSignIn();
            cs.Show();
            this.Hide();
        }

        private void WBtn_Click(object sender, EventArgs e)
        {
            WaiterSignIn ws = new WaiterSignIn();
            ws.Show();
            this.Hide();
        }

        private void ChfBtn_Click(object sender, EventArgs e)
        {
            Baristasignin baristasignin = new Baristasignin();
            baristasignin.Show();
            this.Hide();
        }
    }
}
