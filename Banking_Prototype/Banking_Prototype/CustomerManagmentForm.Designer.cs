namespace Banking_Prototype
{
    partial class CustomerManagmentForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCustomerEdit = new System.Windows.Forms.Button();
            this.BtnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.txtCustomerContactDetails = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCustomerEdit);
            this.panel2.Controls.Add(this.BtnDeleteCustomer);
            this.panel2.Controls.Add(this.btnAddCustomer);
            this.panel2.Controls.Add(this.listBoxCustomers);
            this.panel2.Controls.Add(this.txtCustomerContactDetails);
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCustomerID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(27, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 408);
            this.panel2.TabIndex = 7;
            // 
            // BtnCustomerEdit
            // 
            this.BtnCustomerEdit.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnCustomerEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomerEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomerEdit.ForeColor = System.Drawing.Color.GhostWhite;
            this.BtnCustomerEdit.Location = new System.Drawing.Point(567, 213);
            this.BtnCustomerEdit.Margin = new System.Windows.Forms.Padding(20);
            this.BtnCustomerEdit.Name = "BtnCustomerEdit";
            this.BtnCustomerEdit.Size = new System.Drawing.Size(66, 32);
            this.BtnCustomerEdit.TabIndex = 16;
            this.BtnCustomerEdit.Text = "Edit";
            this.BtnCustomerEdit.UseVisualStyleBackColor = false;
            this.BtnCustomerEdit.Click += new System.EventHandler(this.BtnCustomerEdit_Click);
            // 
            // BtnDeleteCustomer
            // 
            this.BtnDeleteCustomer.BackColor = System.Drawing.Color.DarkRed;
            this.BtnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteCustomer.ForeColor = System.Drawing.Color.GhostWhite;
            this.BtnDeleteCustomer.Location = new System.Drawing.Point(648, 213);
            this.BtnDeleteCustomer.Margin = new System.Windows.Forms.Padding(20);
            this.BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            this.BtnDeleteCustomer.Size = new System.Drawing.Size(66, 32);
            this.BtnDeleteCustomer.TabIndex = 15;
            this.BtnDeleteCustomer.Text = "Delete";
            this.BtnDeleteCustomer.UseVisualStyleBackColor = false;
            this.BtnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAddCustomer.Location = new System.Drawing.Point(71, 356);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(20);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(139, 32);
            this.btnAddCustomer.TabIndex = 13;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.Location = new System.Drawing.Point(17, 60);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(273, 277);
            this.listBoxCustomers.TabIndex = 12;
            this.listBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.listBoxCustomers_SelectedIndexChanged);
            // 
            // txtCustomerContactDetails
            // 
            this.txtCustomerContactDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerContactDetails.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCustomerContactDetails.Location = new System.Drawing.Point(478, 167);
            this.txtCustomerContactDetails.Margin = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.txtCustomerContactDetails.Name = "txtCustomerContactDetails";
            this.txtCustomerContactDetails.ReadOnly = true;
            this.txtCustomerContactDetails.Size = new System.Drawing.Size(155, 26);
            this.txtCustomerContactDetails.TabIndex = 11;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCustomerName.Location = new System.Drawing.Point(478, 129);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(251, 26);
            this.txtCustomerName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(325, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contact Details:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(325, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(325, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer ID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCustomerID.Location = new System.Drawing.Point(478, 91);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(100, 26);
            this.txtCustomerID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Management";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(1, -2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20);
            this.label1.Size = new System.Drawing.Size(780, 100);
            this.label1.TabIndex = 6;
            this.label1.Text = "myBank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerManagmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerManagmentForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCustomerContactDetails;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.Button BtnDeleteCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button BtnCustomerEdit;
    }
}