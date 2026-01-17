using CMS.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.Barista
{
    public partial class BaristaInventory : Form
    {
        DataTable inventoryTable = new DataTable();

        public BaristaInventory()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BaristaInventory_Load(object sender, EventArgs e)
        {
            inventoryTable.Columns.Add("item", typeof(string));
            inventoryTable.Columns.Add("quantity", typeof(int));

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
            dataGridView1.DataSource = inventoryTable;
        }



        private void btnadd_Click(object sender, EventArgs e)
        {
            string item = comboBox1.Text;
            int qty = (int)numericUpDownQty.Value;

            if (string.IsNullOrEmpty(item))
                return;

            DataRow row = inventoryTable.AsEnumerable()
                .FirstOrDefault(r => r.Field<string>("item") == item);

            if (row == null)
            {
                inventoryTable.Rows.Add(item, qty);
                MessageBox.Show("Item Added");
            }
            else
            {
                MessageBox.Show("Item already exists. Use Update.");
            }
        }





        private void btnupdate_Click(object sender, EventArgs e)
        {
            string item = comboBox1.Text;
            int qty = (int)numericUpDownQty.Value;

            DataRow row = inventoryTable.AsEnumerable()
                .FirstOrDefault(r => r.Field<string>("item") == item);

            if (row != null)
            {
                row["quantity"] = qty;
                MessageBox.Show("Item Updated");
            }
            else
            {
                MessageBox.Show("Item not found");
            }
        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                inventoryTable.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Item Deleted");
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            numericUpDownQty.Value = 0;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = inventoryTable;

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
            string item = comboBox1.Text;

            DataRow row = inventoryTable.AsEnumerable()
                .FirstOrDefault(r => r.Field<string>("item") == item);

            numericUpDownQty.Value = row != null
                ? Convert.ToInt32(row["quantity"])
                : 0;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Homepage homePage = new Homepage();
            homePage.Show();
            this.Hide();
        }
    }
}
