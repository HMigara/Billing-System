using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace Billing_System
{
    public partial class Formitems : Form
    {
        private MySqlConnection conn;
        private string conStr;
        public Formitems()
        {
            InitializeComponent();
            getDatabse();
            CheckDatabse();
        }

        private void getDatabse()
        {
            conStr = "server=localhost;user id=root;password=;database=testerp";
            conn = new MySqlConnection(conStr);
        }

        private void CheckDatabse()
        {
            try
            {
                conn.Open();
               // MessageBox.Show("Data base connected");
                conn.Close();
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearFields()
        {
            txtitemcode.Text = string.Empty;
            txtitemname.Text = string.Empty;
            txtitemDiscription.Text = string.Empty;
            txtitemCost.Text = string.Empty;
            txtsellingPrice.Text = string.Empty;
        }

        private void SaveItemData(string itemCode, string itemName, string discription, double itemCost, double sellingPrice)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO items (code, name, description, cost, sellingPrice) VALUES (@Itemcode, @ItemName, @ItemDiscription, @ItemCost, @sellinPrice)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Itemcode", itemCode);
                command.Parameters.AddWithValue("@ItemName", itemName);
                command.Parameters.AddWithValue("@ItemDiscription", discription);
                command.Parameters.AddWithValue("@ItemCost", itemCost);
                command.Parameters.AddWithValue("@sellinPrice", sellingPrice);
                int i = command.ExecuteNonQuery();

                if (i != null)
                {
                    MessageBox.Show("data Saved");
                    ClearFields();
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string itemCode = txtitemcode.Text;
            string itemName = txtitemname.Text;
            string discription = txtitemDiscription.Text;
            double itemCost = double.Parse( txtitemCost.Text);
            double sellingPrice =double.Parse( txtsellingPrice.Text);

            SaveItemData(itemCode, itemName, discription, itemCost, sellingPrice);
        }
    }
}
