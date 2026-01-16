using CMS.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Admin
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void CBtn_Click(object sender, EventArgs e)
        {
            AddCashier addCashier = new AddCashier();
            addCashier.Show();
            this.Hide();
        }

        private void WBtn_Click(object sender, EventArgs e)
        {
            Waiter waiter  = new Waiter();
            waiter.Show();
            this.Hide();    
        }

        private void ChfBtn_Click(object sender, EventArgs e)
        {
            Chef chef  = new Chef();
            chef.Show();
            this.Hide();
        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            Homepage hm = new Homepage();
            hm.Show();
            this.Hide();
        }
    }
}
