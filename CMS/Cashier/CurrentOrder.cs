using System;
using System.Data;
using System.Data.SqlClient;
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
            if (gvAllPay.SelectedRows.Count == 0)
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
                MessageBox.Show("Select an order first.");
                return;
            }

            int orderId = Convert.ToInt32(
                gvAllPay.SelectedRows[0].Cells["OrderId"].Value);

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this order?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(
                @"Data Source=UTSAB-PC\SQLEXPRESS;
          Initial Catalog=CMSDb;
          Integrated Security=True;
          Encrypt=True;
          TrustServerCertificate=True;"))
            {
                conn.Open();

                
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM PaymentHistory WHERE OrderId = @oid", conn);
                checkCmd.Parameters.AddWithValue("@oid", orderId);

                int paymentCount = (int)checkCmd.ExecuteScalar();

                if (paymentCount > 0)
                {
                    MessageBox.Show("This order is already paid and cannot be deleted.");
                    return;
                }

               
                SqlCommand deleteCmd = new SqlCommand(
                    "DELETE FROM Orders WHERE OrderId = @oid", conn);
                deleteCmd.Parameters.AddWithValue("@oid", orderId);

                deleteCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Order deleted successfully.");
            btnPaymentHistoryShow_Click(null, null); 
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

        private void gvAllPay_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
