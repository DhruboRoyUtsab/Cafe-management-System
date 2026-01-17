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
            inventoryTable.Columns.Add("item");
            inventoryTable.Columns.Add("quantity");

            inventoryTable.Rows.Add("Instant Coffee", InstantCoffeeUpDown1.Value);
            inventoryTable.Rows.Add("Latte", LatteUpDown2.Value);
            inventoryTable.Rows.Add("Americano", AmericanoUpDown3.Value);
            inventoryTable.Rows.Add("Mocca", MoccaUpDown4.Value);
            inventoryTable.Rows.Add("Cappuccino", CappuccinoUpDown5.Value);
            inventoryTable.Rows.Add("Blue Mountain", BluemountainUpDown6.Value);
            inventoryTable.Rows.Add("Caramel", CaramelUpDown7.Value);
            inventoryTable.Rows.Add("Black Coffee", BlackcoffeeUpDown8.Value);

            dataGridView1.DataSource = inventoryTable;
        }



        private void btnadd_Click(object sender, EventArgs e)
        {
            inventoryTable.Rows.Add("Instant Coffee", InstantCoffeeUpDown1.Value);
            inventoryTable.Rows.Add("Latte", LatteUpDown2.Value);
            inventoryTable.Rows.Add("Americano", AmericanoUpDown3.Value);
            inventoryTable.Rows.Add("Mocca", MoccaUpDown4.Value);
            inventoryTable.Rows.Add("Cappuccino", CappuccinoUpDown5.Value);
            inventoryTable.Rows.Add("Blue Mountain", BluemountainUpDown6.Value);
            inventoryTable.Rows.Add("Caramel", CaramelUpDown7.Value);
            inventoryTable.Rows.Add("Black Coffee", BlackcoffeeUpDown8.Value);

            MessageBox.Show("Inventory Added Successfully");
        }





        private void btnupdate_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in inventoryTable.Rows)
            {
                if (row["item"].ToString() == "Instant Coffee")
                    row["quantity"] = InstantCoffeeUpDown1.Value;

                else if (row["item"].ToString() == "Latte")
                    row["quantity"] = LatteUpDown2.Value;

                else if (row["item"].ToString() == "Americano")
                    row["quantity"] = AmericanoUpDown3.Value;

                else if (row["item"].ToString() == "Mocca")
                    row["quantity"] = MoccaUpDown4.Value;

                else if (row["item"].ToString() == "Cappuccino")
                    row["quantity"] = CappuccinoUpDown5.Value;

                else if (row["item"].ToString() == "Blue Mountain")
                    row["quantity"] = BluemountainUpDown6.Value;

                else if (row["item"].ToString() == "Caramel")
                    row["quantity"] = CaramelUpDown7.Value;

                else if (row["item"].ToString() == "Black Coffee")
                    row["quantity"] = BlackcoffeeUpDown8.Value;
            }

            MessageBox.Show("Inventory Updated Successfully");
        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Deleted Successfully");
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            InstantCoffeeUpDown1.Value = 0;
            LatteUpDown2.Value = 0;
            AmericanoUpDown3.Value = 0;
            MoccaUpDown4.Value = 0;
            CappuccinoUpDown5.Value = 0;
            BluemountainUpDown6.Value = 0;
            CaramelUpDown7.Value = 0;
            BlackcoffeeUpDown8.Value = 0;
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
               
        }
    }
}
