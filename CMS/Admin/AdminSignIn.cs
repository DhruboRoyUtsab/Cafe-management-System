using CMS.Admin;
using CMS.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CMS
{
    public partial class AdminSignIn : Form
    {
        private string username, password;
        public AdminSignIn()
        {
            InitializeComponent();
        }
        private void connect()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=UTSAB-PC\SQLEXPRESS;Initial Catalog=CMSDb;Integrated Security=True;Encrypt=False;");
            conn.Open();
            //string query = "insert into Faculty (Name,Email,DOB,Gender,Qualifications,Dept,Address) values('James','j@gmail.com','2002-10-10','Male','BSc,MSc','CS','AAAAAAAAAAAAAAAAAAAA')";
            string query = "insert into AdminSignIn (username, password) values('" + username + "','" + password + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAdminSIgnIn_Click(object sender, EventArgs e)
        {
            username = TBAdminUsername.Text;
            password = TBAdminPassword.Text;
            connect();
            //MessageBox.Show("Username: " + username + "\nPassword: " + password);
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }

        private void BckBtn_Click(object sender, EventArgs e)
        {
            Homepage hm = new Homepage();
            hm.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
