using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class FormCustomer : Form
    {
        private MySqlConnection conn;
        private string conStr;
        public FormCustomer()
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

        private void CheckDatabse() { 
        try { conn.Open();
                //MessageBox.Show("Data base connected");
                conn.Close();
            }
            
            catch (MySqlException ex){
            MessageBox.Show(ex.Message);
            }
        }

        private void ClearFields()
        {
            txtcode.Text = string.Empty;
            txtname.Text = string.Empty;
            txtnumber.Text = string.Empty;
            txtemail.Text = string.Empty;
        }

        private void SaveData(string name, string code, string number, string email) 
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Customer (code, name, number, email) VALUES (@code, @CustomerName, @PhoneNumber, @Email)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@code", code);
                command.Parameters.AddWithValue("@CustomerName", name);
                command.Parameters.AddWithValue("@PhoneNumber", number);
                command.Parameters.AddWithValue("@Email", email);
                int i = command.ExecuteNonQuery();

                if(i != null)
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
            string name = txtname.Text;
            string code = txtcode.Text;
            string number = txtnumber.Text; 
            string email = txtemail.Text;

            SaveData(name, code, number, email);

           //MessageBox.Show(name, code);
        }
    }
}
