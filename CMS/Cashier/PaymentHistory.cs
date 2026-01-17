using CMS.Assets;
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

namespace CMS.Cashier
{
    public partial class PaymentHistory : Form
    {
        public PaymentHistory()
        {
            InitializeComponent();
        }

        private void PaymentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CurrentOrder_Click(object sender, EventArgs e)
        {
            CurrentOrder currentOrder = new CurrentOrder();
            currentOrder.Show();
            this.Hide();
        }

        private void btnPaymentHistoryShow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=UTSAB-PC\SQLEXPRESS;Initial Catalog=CMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
            {
                string query = @"
        SELECT 
            PaymentID,
            OrderId,
            Name,
            Phone,
            PaymentAmount,
            PaymentMethod
        FROM PaymentHistory
        ORDER BY PaymentID DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                try
                {
                    adapter.Fill(dt);

                    // Bind data
                    gvAllPay.DataSource = dt;

                    // UI settings (ADD HERE)
                    gvAllPay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    gvAllPay.ReadOnly = true;
                    gvAllPay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    gvAllPay.MultiSelect = false;
                    gvAllPay.AllowUserToAddRows = false;
                    gvAllPay.AllowUserToDeleteRows = false;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Database Error");
                }
            }
        }

        private void gvAllPay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvAllPay.Rows[e.RowIndex];

                tbName.Text = row.Cells["Name"].Value.ToString();
                tbPhone.Text = row.Cells["Phone"].Value.ToString();
            }
        }

        private void PaymentHistory_Load(object sender, EventArgs e)
        {
            btnPaymentHistoryShow_Click(null, null);
        }

        private void btnPayDelete_Click(object sender, EventArgs e)
        {
            if (gvAllPay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a payment to delete.");
                return;
            }

            int paymentId = Convert.ToInt32(
                gvAllPay.SelectedRows[0].Cells["PaymentID"].Value);

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this payment?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(
                @"Data Source=UTSAB-PC\SQLEXPRESS;
          Initial Catalog=CMSDb;
          Integrated Security=True;
          Encrypt=True;
          TrustServerCertificate=True;"))
            {
                string query = "DELETE FROM PaymentHistory WHERE PaymentID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", paymentId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Payment deleted.");
            btnPaymentHistoryShow_Click(null, null);
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            if (gvAllPay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a payment to update.");
                return;
            }

            int paymentId = Convert.ToInt32(
                gvAllPay.SelectedRows[0].Cells["PaymentID"].Value);

            using (SqlConnection conn = new SqlConnection(
                @"Data Source=UTSAB-PC\SQLEXPRESS;
          Initial Catalog=CMSDb;
          Integrated Security=True;
          Encrypt=True;
          TrustServerCertificate=True;"))
            {
                string query = @"
        UPDATE PaymentHistory
        SET Name=@name, Phone=@phone
        WHERE PaymentID=@id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", tbName.Text);
                cmd.Parameters.AddWithValue("@phone", tbPhone.Text);
                cmd.Parameters.AddWithValue("@id", paymentId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbPhone.Clear();
            gvAllPay.ClearSelection();
        }

        private void btnPaymentHistoryBack_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }
    }
}
