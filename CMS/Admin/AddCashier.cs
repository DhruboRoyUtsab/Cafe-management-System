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
    public partial class AddCashier : Form
    {
        public AddCashier()
        {
            InitializeComponent();
        }
        //private void connect()
        //{
        //    SqlConnection conn = new SqlConnection(@"Data Source=UTSAB-PC\SQLEXPRESS;Initial Catalog=CMSDb;Integrated Security=True;Encrypt=True;");
        //    conn.Open();
        //    //string query = "insert into Faculty (Name,Email,DOB,Gender,Qualifications,Dept,Address) values('James','j@gmail.com','2002-10-10','Male','BSc,MSc','CS','AAAAAAAAAAAAAAAAAAAA')";
        //    string query = "insert into Faculty (Name,Email,DOB,Gender,Qualifications,Dept,Address) values('" + name + "','" + email + "','" + dob + "','" + gender + "','" + qua + "','" + dept + "','" + address + "')";
        //    SqlCommand cmd = new SqlCommand(query, conn);
        //    cmd.ExecuteNonQuery();
        //}

        private void lblSignIn_Click(object sender, EventArgs e)
        {

        }

        private void AddCashier_Load(object sender, EventArgs e)
        {

        }
    }
}
