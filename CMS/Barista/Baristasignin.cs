using CMS.Assets;
using CMS.Barista;
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

namespace CMS.Chef
{
    public partial class Baristasignin : Form
    {
        public Baristasignin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=UTSAB-PC\SQLEXPRESS;Initial Catalog=CMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");

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
            if (string.IsNullOrWhiteSpace(usernametxtbox.Text) ||
                string.IsNullOrWhiteSpace(passwordtxtbox.Text))
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            try
            {
                conn.Open();

                string query = @"SELECT COUNT(*) FROM Chef WHERE name = @name AND password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", usernametxtbox.Text);
                cmd.Parameters.AddWithValue("@password", passwordtxtbox.Text);

                int result = (int)cmd.ExecuteScalar();

                if (result == 1)
                {
                    BaristaInventory baristaInventory = new BaristaInventory();
                    baristaInventory.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void usernametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Homepage  homePage = new Homepage();
            homePage.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
