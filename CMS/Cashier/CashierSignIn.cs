using CMS.Assets;
using CMS.Cashier;
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
        private bool CashierLogin(string email, string password)
        {
            SqlConnection conn = new SqlConnection(
                @"Data Source=UTSAB-PC\SQLEXPRESS;
          Initial Catalog=CMSDb;
          Integrated Security=True;
          Encrypt=True;
          TrustServerCertificate=True;");

            string query = "SELECT COUNT(*) FROM Cashier WHERE Name=@Name AND Password=@password";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", email);
            cmd.Parameters.AddWithValue("@password", password);

            conn.Open();
            int result = (int)cmd.ExecuteScalar();
            conn.Close();

            return result == 1;
        }


        private void btnCashierSignIn_Click(object sender, EventArgs e)
        {
            string email = tbCashierUserName.Text.Trim();
            string password = tbCashierPassword.Text.Trim();

            if (email == "" || password == "")
            {
                MessageBox.Show("Email and Password are required",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CashierLogin(email, password))
            {
                PaymentHistory paymentHistory = new PaymentHistory();
                paymentHistory.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Cashier Email or Password",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminSignInPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCashierSignIn_Click(object sender, EventArgs e)
        {

        }
    }
}
