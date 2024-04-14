using Banking_Prototype.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking_Prototype.Controllers;


namespace Banking_Prototype
{
    public partial class AddCustomerForm : Form
    {
        private readonly Controller controller;
        public AddCustomerForm(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtAddCustomerName.Text) || string.IsNullOrWhiteSpace(txtAddContactDetails.Text))
            {
                MessageBox.Show("Please enter both name and contact details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Customer object
            Customer newCustomer = new Customer
            {
                // Assign values from the input fields
                Name = txtAddCustomerName.Text,
                ContactDetails = txtAddContactDetails.Text
            };

            // Add the new customer using the controller
            controller.AddCustomer(newCustomer);

            // Display success message
            MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form and return DialogResult.OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
