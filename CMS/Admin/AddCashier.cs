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
        string name, email, password, address,gender;
        DateTime DTPickerDOB, JDPickerDOB;
        public AddCashier()
        {
            InitializeComponent();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            Show();

        }

        private void Show()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=UTSAB-PC\SQLEXPRESS;Initial Catalog=CMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");


            conn.Open();
            string query = "Select * from AddCashier";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView.DataSource = dt;
            dataGridView.AutoGenerateColumns = true;
            conn.Close();
        }

        private void Insert()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=UTSAB-PC\SQLEXPRESS;Initial Catalog=CMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
            conn.Open();
            string query = "insert into AddCashier (Name,Email,Address,DateOfBirth,Gender,JoiningDate,Password) values('" + name + "','" + email + "','" + address + "','" + DTPickerDOB.ToString("yyyy-MM-dd") + "','" + gender + "','" + JDPickerDOB.ToString("yyyy-MM-dd") + "','" + password + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {

        }

        private void AddCashier_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            name = TBACashierUserName.Text;
            email = TBACashierEmail.Text;
            password = TBACashierPassword.Text;
            address = TBACashierAddress.Text;
            DTPickerDOB = dateTimePickerDOB.Value;
            JDPickerDOB = dateTimePickerJD.Value;

            if (RBMale.Checked)
            {
                gender = "Male";
            }
            else if (RBFemale.Checked)
            {
                gender = "Female";
            }

            Insert();
            Show();
            MessageBox.Show("Cashier Added Successfully!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > 0)
            {
                TBACashierUserName.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                TBACashierEmail.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                TBACashierAddress.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePickerDOB.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateTimePickerJD.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                TBACashierPassword.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }
    }
}