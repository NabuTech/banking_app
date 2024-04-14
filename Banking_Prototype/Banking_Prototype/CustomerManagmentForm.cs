using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking_Prototype.Models;
using Banking_Prototype.Controllers;
using System.Xml.Linq;

namespace Banking_Prototype
{
    public partial class CustomerManagmentForm : Form
    {
        private readonly Controller controller;
        private List<Customer> customers;

        public CustomerManagmentForm()
        {
            InitializeComponent();
            string filePath = Path.Combine(Application.StartupPath, "Data", "customers.json");
            controller = new Controller(filePath);
            DisplayCustomers();
        }

        private void DisplayCustomers()
        {
            listBoxCustomers.Items.Clear(); // Clear existing items before repopulating
            foreach (Customer customer in controller.GetCustomers())
            {
                listBoxCustomers.Items.Add($"{customer.CustomerNumber} - {customer.Name} - {customer.ContactDetails}");
            }

            // Log display of customers
            Console.WriteLine($"Displayed {listBoxCustomers.Items.Count} customers.");
        }

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedIndex != -1)
            {
                // Get the selected customer from the list box
                Customer selectedCustomer = controller.GetCustomers()[listBoxCustomers.SelectedIndex];

                // Display the customer data in the text boxes
                txtCustomerID.Text = selectedCustomer.CustomerNumber.ToString();
                txtCustomerName.Text = selectedCustomer.Name;
                txtCustomerContactDetails.Text = selectedCustomer.ContactDetails;
            }
        }

        private void BtnCustomerEdit_Click(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedItem != null)
            {
                // Get the selected customer from the list box
                int selectedIndex = listBoxCustomers.SelectedIndex;
                Customer selectedCustomer = controller.GetCustomers()[selectedIndex];

                // Open the edit customer form
                EditCustomerForm editCustomerForm = new EditCustomerForm(controller, selectedIndex);
                // Show the form
                DialogResult result = editCustomerForm.ShowDialog();

                // If the user confirms the edit
                if (result == DialogResult.OK)
                {
                    // Update the display
                    DisplayCustomers();

                    // Save the updated customer list to the JSON file
                    controller.SaveCustomersToFile();
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.", "No Customer selected.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // Create an instance of the AddCustomerForm
            AddCustomerForm addCustomerForm = new AddCustomerForm(controller);

            // Show the AddCustomerForm as a dialog
            DialogResult result = addCustomerForm.ShowDialog();

            // Check if the dialog result is OK (meaning the user added a customer successfully)
            if (result == DialogResult.OK)
            {
                // Reload customers from the JSON file
                DisplayCustomers();

                // No need to update the display again, as it's already updated after adding the customer
            }
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedItem != null)
            {
                // Get the selected customer from the list box
                int selectedIndex = listBoxCustomers.SelectedIndex;
                Customer selectedCustomer = controller.GetCustomers()[selectedIndex];

                // Prompt the user to confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    // Delete the customer
                    if (controller.DeleteCustomer(selectedCustomer.CustomerNumber))
                    {
                        // Update the display
                        DisplayCustomers();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.", "No Customer selected.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
