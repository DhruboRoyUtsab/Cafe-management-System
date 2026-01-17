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
        private bool WaiterLogin(string name, string password)
        {
            SqlConnection conn = new SqlConnection(
                @"Data Source=UTSAB-PC\SQLEXPRESS;
          Initial Catalog=CMSDb;
          Integrated Security=True;
          Encrypt=True;
          TrustServerCertificate=True;");

            string query = "SELECT COUNT(*) FROM Waiter WHERE Name=@name AND Password=@password";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@password", password);

            conn.Open();
            int result = (int)cmd.ExecuteScalar();
            conn.Close();

            return result == 1;
        }


        private void BtnWaiterSIgnIn_Click(object sender, EventArgs e)
        {
            string name = TBWaiterUsername.Text.Trim();
            string password = TBWaiterPassword.Text.Trim();

            if (name == "" || password == "")
            {
                MessageBox.Show("Name and Password are required",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (WaiterLogin(name, password))
            {
                Order order = new Order();
                order.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Waiter Name or Password",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WaiterSignIn_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
