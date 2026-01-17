using CMS.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Barista
{
    public partial class BaristaInventory : Form
    {
        

        public BaristaInventory()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BaristaInventory_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[]
    {
        "Instant Coffee",
        "Latte",
        "Americano",
        "Mocca",
        "Cappuccino",
        "Blue Mountain",
        "Caramel",
        "Black Coffee"
    });

            comboBox1.SelectedIndex = 0;
            LoadInventory();
        }
        private void LoadInventory()
        {
            SqlConnection conn = new SqlConnection(
              @"Data Source=UTSAB-PC\SQLEXPRESS;
              Initial Catalog=CMSDb;
              Integrated Security=True;
              Encrypt=True;
              TrustServerCertificate=True;");

                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT ItemName, Quantity FROM BaristaInventory", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

        }



        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(
              @"Data Source=UTSAB-PC\SQLEXPRESS;
              Initial Catalog=CMSDb;
              Integrated Security=True;
              Encrypt=True;
              TrustServerCertificate=True;");
            string item = comboBox1.Text;
            int qty = (int)numericUpDownQty.Value;

            if (string.IsNullOrWhiteSpace(item)) return;

            
                conn.Open();

                string query = @"
IF EXISTS (SELECT 1 FROM BaristaInventory WHERE ItemName = @item)
    UPDATE BaristaInventory
    SET Quantity = @qty
    WHERE ItemName = @item
ELSE
    INSERT INTO BaristaInventory (ItemName, Quantity)
    VALUES (@item, @qty)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@item", item);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Inventory Saved");
                LoadInventory();
            
        }





        private void btnupdate_Click(object sender, EventArgs e)
        {
            
                SqlConnection conn = new SqlConnection(
              @"Data Source=UTSAB-PC\SQLEXPRESS;
              Initial Catalog=CMSDb;
              Integrated Security=True;
              Encrypt=True;
              TrustServerCertificate=True;");
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE BaristaInventory SET Quantity = @qty WHERE ItemName = @item",
                    conn);

                cmd.Parameters.AddWithValue("@item", comboBox1.Text);
                cmd.Parameters.AddWithValue("@qty", numericUpDownQty.Value);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Item Updated");
                LoadInventory();
            
        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            string item =
                dataGridView1.SelectedRows[0].Cells["ItemName"].Value.ToString();

            
              SqlConnection conn = new SqlConnection(
              @"Data Source=UTSAB-PC\SQLEXPRESS;
              Initial Catalog=CMSDb;
              Integrated Security=True;
              Encrypt=True;
              TrustServerCertificate=True;");
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM BaristaInventory WHERE ItemName = @item", conn);
                cmd.Parameters.AddWithValue("@item", item);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Item Deleted");
                LoadInventory();
            
            
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            LoadInventory();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InstantCoffeeUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BlackcoffeeUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                SqlConnection conn = new SqlConnection(
              @"Data Source=UTSAB-PC\SQLEXPRESS;
              Initial Catalog=CMSDb;
              Integrated Security=True;
              Encrypt=True;
              TrustServerCertificate=True;");
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT Quantity FROM BaristaInventory WHERE ItemName = @item", conn);
                cmd.Parameters.AddWithValue("@item", comboBox1.Text);

                object result = cmd.ExecuteScalar();
                numericUpDownQty.Value = result != null ? Convert.ToInt32(result) : 0;
            
            
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Homepage homePage = new Homepage();
            homePage.Show();
            this.Hide();
        }
    }
}
