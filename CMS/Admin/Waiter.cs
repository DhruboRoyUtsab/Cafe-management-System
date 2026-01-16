using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMS.Admin
{
    public partial class Waiter : Form
    {
        string name, email, password, address, gender;
        DateTime DTPickerDOB;
        int selectedWaiterId;
        public Waiter()
        {
            InitializeComponent();
        }
        private new void Show()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=UTSAB-PC\SQLEXPRESS;Initial Catalog=CMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
                conn.Open();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Waiter", conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void Insert()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=UTSAB-PC\SQLEXPRESS;Initial Catalog=CMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
            conn.Open();

            string query = "INSERT INTO Waiter (Name,Email,Gender,Address,DateOfBirth,Password) " +
                           "VALUES ('" + name + "','" + email + "','" + gender + "','" + address + "','" + DTPickerDOB.ToString("yyyy-MM-dd") + "','" + password + "')";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private new void Update()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=UTSAB-PC\SQLEXPRESS;Initial Catalog=CMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
                conn.Open();
                string q = "UPDATE Waiter SET Name='" + name + "',Email='" + email + "',Gender='" + gender +
                           "',Address='" + address + "',DateOfBirth='" + DTPickerDOB.ToString("yyyy-MM-dd") +
                           "',Password='" + password + "' WHERE ID=" + selectedWaiterId;
                new SqlCommand(q, conn).ExecuteNonQuery();
                conn.Close();
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
            selectedWaiterId = 0;
        }
        private void Waiter_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadRowToForm(e);
        }

        private void LoadRowToForm(DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                selectedWaiterId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value);
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
                MessageBox.Show("Waiter Added Successfully!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            AdminPanel ad = new AdminPanel();
            ad.Show();
            this.Hide();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadRowToForm(e);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("Waiter Updated Successfully!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedWaiterId == 0)
                {
                    MessageBox.Show("Select a Waiter first!");
                    return;
                }

                SqlConnection conn = new SqlConnection(@"Data Source=UTSAB-PC\SQLEXPRESS;Initial Catalog=CMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
                conn.Open();
                new SqlCommand("DELETE FROM Waiter WHERE Id=" + selectedWaiterId, conn).ExecuteNonQuery();
                conn.Close();

                Show();
                ClearFields();
                MessageBox.Show("Waiter Deleted Successfully!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            Show();
        }
    }
}
