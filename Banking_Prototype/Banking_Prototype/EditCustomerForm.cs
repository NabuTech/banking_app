using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking_Prototype.Controllers;
using Banking_Prototype.Models;
using System.Text.Json;

namespace Banking_Prototype
{
    public partial class EditCustomerForm : Form
    {

        private Customer selectedCustomer;
        private readonly Controller controller;

        public EditCustomerForm(Controller controller, int selectedIndex)
        {
            InitializeComponent();

            this.controller = controller;
            this.selectedCustomer = controller.GetCustomers()[selectedIndex];

            // Display the selected customer's details
            txtCustomerID.Text = selectedCustomer.CustomerNumber.ToString();
            txtCustomerName.Text = selectedCustomer.Name;
            txtContactDetails.Text = selectedCustomer.ContactDetails;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnConfirmEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the edited customer details from the text boxes
                int customerNumber = int.Parse(txtCustomerID.Text);
                string newName = txtCustomerName.Text;
                string newContactDetails = txtContactDetails.Text;

                // Log the edited customer details
                Console.WriteLine($"Editing customer with number {customerNumber}: Name={newName}, ContactDetails={newContactDetails}");

                // Update the customer in the controller and save changes
                controller.EditCustomer(customerNumber, newName, newContactDetails);
                controller.SaveCustomersToFile(); // Save changes to the JSON file

                // Log that the customer has been updated
                Console.WriteLine("Customer details updated successfully.");

                // Close the form after successful save
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving customer details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
