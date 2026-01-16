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

            string method = rbtnCashPay.Checked ? "Cash" : "Card";

            
            if (method == "Card")
            {
                if (string.IsNullOrWhiteSpace(tbCard.Text))
                {
                    MessageBox.Show("Enter card number.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbPin.Text))
                {
                    MessageBox.Show("Enter PIN number.");
                    return;
                }
            }

            
            SqlConnection conn = new SqlConnection(
                @"Data Source=UTSAB-PC\SQLEXPRESS;
          Initial Catalog=CMSDb;
          Integrated Security=True;
          Encrypt=True;
          TrustServerCertificate=True;");

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO PaymentHistory
              (OrderID, PaymentAmount, PaymentMethod, PaymentStatus)
              VALUES (@oid, @amt, @method, 'Paid')", conn);

                cmd.Parameters.AddWithValue("@oid", _orderId);
                cmd.Parameters.AddWithValue("@amt", _amount);
                cmd.Parameters.AddWithValue("@method", method);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Payment successful!");

                PaymentHistory ph = new PaymentHistory();
                ph.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
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
