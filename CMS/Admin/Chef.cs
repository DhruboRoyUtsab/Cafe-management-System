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

namespace CMS.Admin
{
    public partial class Chef : Form
    {
        string name, email, password, address, gender;
        DateTime DTPickerDOB;
        int selectedChefId;
        public Chef()
        {
            InitializeComponent();
        }
        private new void Show()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=UTSAB-PC\SQLEXPRESS;Initial Catalog=CMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
                conn.Open();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Chef", conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void LoadRowToForm(DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                selectedChefId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value);
                TBACashierUserName.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                TBACashierEmail.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

                string g = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                RBMale.Checked = g == "Male";
                RBFemale.Checked = g == "Female";

                TBACashierAddress.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                TBACashierPassword.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();

                DateTime dob;
                if (DateTime.TryParse(dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString(), out dob))
                    dateTimePickerDOB.Value = dob;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                name = TBACashierUserName.Text;
                email = TBACashierEmail.Text;
                password = TBACashierPassword.Text;
                address = TBACashierAddress.Text;
                DTPickerDOB = dateTimePickerDOB.Value;
                gender = "";
                if (RBMale.Checked) gender = "Male";
                else if (RBFemale.Checked) gender = "Female";


                if (string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(address) ||
                    string.IsNullOrWhiteSpace(gender))
                {
                    MessageBox.Show("Please fill all fields and select gender.");
                    return;
                }

                if (password != TBACashierConfirmPassword.Text)
                {
                    MessageBox.Show("Password and Confirm Password do not match!");
                    return;
                }

                Insert();
                Show();
                ClearFields();
                MessageBox.Show("Chef Added Successfully!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                name = TBACashierUserName.Text;
                email = TBACashierEmail.Text;
                password = TBACashierPassword.Text;
                address = TBACashierAddress.Text;
                DTPickerDOB = dateTimePickerDOB.Value;

                gender = "";
                if (RBMale.Checked) gender = "Male";
                else if (RBFemale.Checked) gender = "Female";

                if (string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(address) ||
                    string.IsNullOrWhiteSpace(gender))
                {
                    MessageBox.Show("Please fill all fields and select gender.");
                    return;
                }


                if (password != TBACashierConfirmPassword.Text)
                {
                    MessageBox.Show("Password and Confirm Password do not match!");
                    return;
                }
                Update();
                Show();
                ClearFields();
                MessageBox.Show("Chef Updated Successfully!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void Insert()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=UTSAB-PC\SQLEXPRESS;Initial Catalog=CMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
            conn.Open();

            string query = "INSERT INTO Chef (Name,Email,Gender,Address,DateOfBirth,Password) " +
                           "VALUES ('" + name + "','" + email + "','" + gender + "','" + address + "','" + DTPickerDOB.ToString("yyyy-MM-dd") + "','" + password + "')";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void BckBtn_Click(object sender, EventArgs e)
        {
            AdminPanel ad = new AdminPanel();
            ad.Show();
            this.Hide();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadRowToForm(e);
        }

        private void Chef_Load(object sender, EventArgs e)
        {

        }

        private new void Update()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=UTSAB-PC\SQLEXPRESS;Initial Catalog=CMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "UPDATE Chef SET Name='" + name + "',Email='" + email + "',Gender='" + gender +
                           "',Address='" + address + "',DateOfBirth='" + DTPickerDOB.ToString("yyyy-MM-dd") +
                           "',Password='" + password + "' WHERE ChefID=" + selectedChefId;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedChefId == 0)
                {
                    MessageBox.Show("Select a chef first!");
                    return;
                }

                SqlConnection conn = new SqlConnection(@"Data Source=UTSAB-PC\SQLEXPRESS;Initial Catalog=CMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
                conn.Open();
                string query = "DELETE FROM Chef WHERE ChefID=" + selectedChefId;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                Show();
                ClearFields();
                MessageBox.Show("Chef Deleted Successfully!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void ClearFields()
        {
            TBACashierUserName.Clear();
            TBACashierEmail.Clear();
            TBACashierPassword.Clear();
            TBACashierAddress.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            RBMale.Checked = false;
            RBFemale.Checked = false;
            selectedChefId = 0;
        }
        private void ShowBtn_Click(object sender, EventArgs e)
        {
            Show();
        }
    }
}
