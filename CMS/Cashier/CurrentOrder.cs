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
    public partial class CurrentOrder : Form
    {
        public CurrentOrder()
        {
            InitializeComponent();
        }

        private void btnTakePayment_Click(object sender, EventArgs e)
        {
            if (gvAllPay.SelectedRows.Count == 1)
            {
                MessageBox.Show("Select an order first.");
                return;
            }

            int orderId = Convert.ToInt32(
                gvAllPay.SelectedRows[0].Cells["OrderId"].Value);

            decimal amount = Convert.ToDecimal(
                gvAllPay.SelectedRows[0].Cells["TotalPrice"].Value);

            Payment p = new Payment(orderId, amount);
            p.Show();
            this.Hide();
        }


        private void btnPaymentHistoryBack_Click(object sender, EventArgs e)
        {
            PaymentHistory paymentHistory = new PaymentHistory();
            paymentHistory.Show();
            this.Hide();
        }


        private void btnPayDelete_Click(object sender, EventArgs e)
        {
            if (gvAllPay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a payment first.");
                return;
            }

            int paymentId = Convert.ToInt32(
                gvAllPay.SelectedRows[0].Cells["PaymentID"].Value
            );

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this payment?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes) return;

            try
            {
                SqlConnection conn = new SqlConnection(
                    @"Data Source=UTSAB-PC\SQLEXPRESS;
              Initial Catalog=CMSDb;
              Integrated Security=True;
              Encrypt=True;
              TrustServerCertificate=True;");

                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM PaymentHistory WHERE PaymentID = @id", conn);

                cmd.Parameters.AddWithValue("@id", paymentId);
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Payment deleted successfully.");

                
                btnPaymentHistoryShow_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private new void Show(string query, DataGridView grid)
        {
            try
            {
                SqlConnection conn = new SqlConnection(
                    @"Data Source=UTSAB-PC\SQLEXPRESS;
              Initial Catalog=CMSDb;
              Integrated Security=True;
              Encrypt=True;
              TrustServerCertificate=True;");

                conn.Open();
                SqlDataAdapter adp = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                grid.AutoGenerateColumns = true;
                grid.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnPaymentHistoryShow_Click(object sender, EventArgs e)
        {

            string query = @"
        SELECT 
            o.OrderId,
            o.Items,
            o.TotalPrice
        FROM Orders o
        LEFT JOIN PaymentHistory p ON p.OrderID = o.OrderId
        WHERE p.OrderID IS NULL
        ORDER BY o.OrderId DESC";

            Show(query, gvAllPay);
        }

        private void gvAllPay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                gvAllPay.ClearSelection();
                gvAllPay.Rows[e.RowIndex].Selected = true;
            }
        }

        private void PaymentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPaymentHistory_Click(object sender, EventArgs e)
        {

        }

        private void gvAllPay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                gvAllPay.ClearSelection();
                gvAllPay.Rows[e.RowIndex].Selected = true;
            }
        }

        private void CurrentOrder_Load(object sender, EventArgs e)
        {
            btnPaymentHistoryShow_Click(null, null);
        }
    }
}
