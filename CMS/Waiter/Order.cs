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

namespace CMS.Waiter
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        private void Show()
        {
            SqlConnection conn = new SqlConnection(
            @"Data Source=UTSAB-PC\SQLEXPRESS;Initial Catalog=CMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");

            conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Orders", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridOrders.DataSource = dt;
            conn.Close();
        }

        private List<(string, int)> GetSelectedItems()
        {
            var list = new List<(string, int)>();

            if (cbInstantCoffee.Checked) list.Add(("Instant Coffee", 8));
            if (cbLatte.Checked) list.Add(("Latte", 6));
            if (cbAmericano.Checked) list.Add(("Americano", 9));
            if (CBMocca.Checked) list.Add(("Mocca", 6));
            if (cbCappuccino.Checked) list.Add(("Cappuccino", 7));
            if (cbBlueMountain.Checked) list.Add(("Blue Mountain", 4));
            if (cbCaramel.Checked) list.Add(("Caramel", 7));
            if (cbBlackCoffee.Checked) list.Add(("Black Coffee", 5));

            return list;
        }


        private void cbInstantCoffee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbLatte_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBMocca_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbAmericano_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbBlueMountain_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbCaramel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbBlackCoffee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOrderShow_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            if (dataGridOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to delete.");
                return;
            }

            int id = Convert.ToInt32(dataGridOrders.SelectedRows[0].Cells["OrderId"].Value);

            SqlConnection conn = new SqlConnection(
            @"Data Source=UTSAB-PC\SQLEXPRESS;Initial Catalog=CMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Orders WHERE OrderId=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Order deleted");
            Show();
        }

        private void btnOrderUpdate_Click(object sender, EventArgs e)
        {

            if (dataGridOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to update.");
                return;
            }

            int id = Convert.ToInt32(dataGridOrders.SelectedRows[0].Cells["OrderId"].Value);
            string items = dataGridOrders.SelectedRows[0].Cells["Items"].Value.ToString();
            int price = Convert.ToInt32(dataGridOrders.SelectedRows[0].Cells["TotalPrice"].Value);

            SqlConnection conn = new SqlConnection(
            @"Data Source=UTSAB-PC\SQLEXPRESS;Initial Catalog=CMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "UPDATE Orders SET Items=@i, TotalPrice=@p WHERE OrderId=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@i", items);
            cmd.Parameters.AddWithValue("@p", price);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Order updated");
            Show();

        }

        private void btnOrderNext_Click(object sender, EventArgs e)
        {
            var items = GetSelectedItems();

            if (items.Count == 0)
            {
                MessageBox.Show("Select at least one coffee item.");
                return;
            }

            string itemNames = string.Join(", ", items.Select(i => i.Item1));
            int totalPrice = items.Sum(i => i.Item2);

            SqlConnection conn = new SqlConnection(
                @"Data Source=UTSAB-PC\SQLEXPRESS;
          Initial Catalog=CMSDb;
          Integrated Security=True;
          Encrypt=True;
          TrustServerCertificate=True;");

            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Orders (Items, TotalPrice) VALUES (@items, @price)", conn);

            cmd.Parameters.AddWithValue("@items", itemNames);
            cmd.Parameters.AddWithValue("@price", totalPrice);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Order placed!");

            ClearCheckBoxes(this);
            Show();
        }

        private void btnOrderBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage h = new Homepage();
            h.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dataGridOrders.Rows[e.RowIndex].Selected = true;
        }

        private void PaymentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clrBtn_Click(object sender, EventArgs e)
        {

            ClearCheckBoxes(this);
            dataGridOrders.ClearSelection();
            
        }
        private void ClearCheckBoxes(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is CheckBox) ((CheckBox)c).Checked = false;
                if (c.HasChildren) ClearCheckBoxes(c);
            }
        }
    }
}
