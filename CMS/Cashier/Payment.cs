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
using System.Xml.Linq;

namespace CMS.Cashier
{
    public partial class Payment : Form
    {
        int _orderId;
        decimal _amount;
        public Payment(int orderId, decimal amount)
        {
            InitializeComponent();
            _orderId = orderId;
            _amount = amount;

            tbOrderId.Text = orderId.ToString();
            tbAmount.Text = amount.ToString("0.00");

            tbOrderId.ReadOnly = true;
            tbAmount.ReadOnly = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPaymentNext_Click(object sender, EventArgs e)
        {
            if (_orderId <= 0 || _amount <= 0)
            {
                MessageBox.Show("Invalid order data.");
                return;
            }

            
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Enter customer name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("Enter phone number.");
                return;
            }

            
            if (!rbtnCashPay.Checked && !rbtnCardPay.Checked)
            {
                MessageBox.Show("Select payment method.");
                return;
            }

            string paidBy = rbtnCashPay.Checked ? "Cash" : "Card";

            if (paidBy == "Card")
            {
                if (string.IsNullOrWhiteSpace(tbCard.Text))
                {
                    MessageBox.Show("Enter card number.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbPin.Text))
                {
                    MessageBox.Show("Enter PIN.");
                    return;
                }
            }


            SqlConnection conn = new SqlConnection(
                @"Data Source=UTSAB-PC\SQLEXPRESS;
          Initial Catalog=CMSDb;
          Integrated Security=True;
          Encrypt=True;
          TrustServerCertificate=True;");
            {
                string query = @"
        INSERT INTO PaymentHistory
        (OrderId, Name, Phone, PaymentAmount, PaymentMethod)
        SELECT
            OrderId,
            @Name,
            @Phone,
            TotalPrice,
            @PaymentMethod
        FROM Orders
        WHERE OrderId = @OrderId";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add("@OrderId", SqlDbType.Int).Value = _orderId;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = tbName.Text;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Value = tbPhone.Text;
                cmd.Parameters.Add("@PaymentMethod", SqlDbType.NVarChar, 20).Value = paidBy;

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows == 0)
                    {
                        MessageBox.Show("Invalid Order ID. Payment failed.");
                    }
                    else
                    {
                        MessageBox.Show("Payment successful.");
                        
                        PaymentHistory paymentHistory = new PaymentHistory();
                        paymentHistory.Show();
                        this.Hide();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Database Error");
                }
            }
        }

        


        private void btnPaymentBack_Click(object sender, EventArgs e)
        {
            CurrentOrder co = new CurrentOrder();
            co.Show();
            this.Close();
        }

        private void PaymentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOrderId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCard_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
