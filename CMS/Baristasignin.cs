using CMS.Barista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Chef
{
    public partial class Baristasignin : Form
    {
        public Baristasignin()
        {
            InitializeComponent();
        }

        private void ChefSignin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBaristaSignIn_Click(object sender, EventArgs e)
        {
            BaristaInventory baristaInventory = new BaristaInventory();
            baristaInventory.Show();
            this.Hide();
        }

        private void usernametxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
