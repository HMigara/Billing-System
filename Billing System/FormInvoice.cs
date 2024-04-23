using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Billing_System
{
    public partial class FormInvoice : Form
    {
        public FormInvoice()
        {
            InitializeComponent();
        }

        private void CleanFields()
        {
            txtItemPrice.Text = string.Empty;
            txtName.Text = string.Empty;
            txtQuantity.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double Price = double.Parse( txtItemPrice.Text);
            int Quantiti = int.Parse(txtQuantity.Text);

            double Total = Price * Quantiti;

            dataGridView1.Rows.Add(txtCusName.Text,txtItemPrice.Text,txtName.Text,txtQuantity.Text, Total);
            CleanFields();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Invoie";
            printer.SubTitle = string.Format("products", printer.SubTitleColor = Color.Black, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.Footer = "List of products";
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dataGridView1);
            
        }
    }
}
