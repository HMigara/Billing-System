namespace Billing_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnitem = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncustomer
            // 
            this.btncustomer.Location = new System.Drawing.Point(118, 183);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(168, 68);
            this.btncustomer.TabIndex = 0;
            this.btncustomer.Text = "create Customer";
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnitem
            // 
            this.btnitem.Location = new System.Drawing.Point(118, 87);
            this.btnitem.Name = "btnitem";
            this.btnitem.Size = new System.Drawing.Size(168, 68);
            this.btnitem.TabIndex = 0;
            this.btnitem.Text = "Create Item";
            this.btnitem.UseVisualStyleBackColor = true;
            this.btnitem.Click += new System.EventHandler(this.btnitem_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(118, 282);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(168, 65);
            this.btnInvoice.TabIndex = 1;
            this.btnInvoice.Text = "Create Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 446);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnitem);
            this.Controls.Add(this.btncustomer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnitem;
        private System.Windows.Forms.Button btnInvoice;
    }
}

