namespace Billing_System
{
    partial class FormCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer code";
            // 
            // txtcode
            // 
            this.txtcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Location = new System.Drawing.Point(212, 42);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(219, 27);
            this.txtcode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "customer name";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(212, 94);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(219, 27);
            this.txtname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = " phone numbers";
            // 
            // txtnumber
            // 
            this.txtnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumber.Location = new System.Drawing.Point(212, 146);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(219, 27);
            this.txtnumber.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "email";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(212, 207);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(219, 27);
            this.txtemail.TabIndex = 1;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(301, 263);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(130, 37);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label1);
            this.Name = "FormCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnsave;
    }
}