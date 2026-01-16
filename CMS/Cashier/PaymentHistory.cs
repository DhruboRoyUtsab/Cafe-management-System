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

        private void btnTakePayment_Click(object sender, EventArgs e)
        {
            Payment paymentForm = new Payment();
            paymentForm.Show();      
            this.Hide();
        }


        private void btnPaymentHistoryBack_Click(object sender, EventArgs e)
        {
            Homepage signInForm = new Homepage();
            signInForm.Show();
            this.Hide();
        }


        private void btnPayDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnPaymentHistoryShow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(
            @"Data Source=UTSAB-PC\SQLEXPRESS;
          Initial Catalog=CMSDb;
          Integrated Security=True;
          Encrypt=True;");
            
           
            
            string query = @"
        SELECT 
            p.PaymentID,
            o.OrderId,
            p.PaymentAmount,
            ISNULL(p.PaymentMethod, 'Not Paid') AS PaymentMethod,
            p.PaymentStatus
        FROM Table_1 p
        INNER JOIN Orders o ON p.OrderID = o.OrderId
        ORDER BY o.OrderId DESC
    ";

            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            gvAllPay.AutoGenerateColumns = true;
            gvAllPay.DataSource = dt;
        }

        private void gvAllPay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
