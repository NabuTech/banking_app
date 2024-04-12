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
        private readonly List<Customer> customers;

        public CustomerManagmentForm()
        {
            InitializeComponent();

            controller = new Controller();
            customers = LoadCustomers();
            DisplayCustomers();
        }

        private List<Customer> LoadCustomers()
        {
            List<Customer> loadedCustomers = new List<Customer>();

            try
            {
                string startupPath = Application.StartupPath;
                Console.WriteLine($"Application startup path: {startupPath}");

                string folderPath = Path.Combine(startupPath, "Data");
                Console.WriteLine($"Data folder path: {folderPath}");

                string filePath = Path.Combine(folderPath, "customers.json");
                Console.WriteLine($"JSON file path: {filePath}");

                if (File.Exists(filePath))
                {
                    string jsonContent = File.ReadAllText(filePath);
                    loadedCustomers = JsonSerializer.Deserialize<List<Customer>>(jsonContent);
                }
                else
                {
                    MessageBox.Show("JSON file not found at the specified path.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return loadedCustomers;
        }


        private void DisplayCustomers()
        {
            foreach (Customer customer in customers)
            {
                listBoxCustomers.Items.Add($"{customer.CustomerNumber} - {customer.Name} - {customer.ContactDetails}");
            }
        }

        private void CustomerManagmentForm_Load(object sender, EventArgs e)
        {

        }

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedIndex != -1)
            {
                // Get the selected customer from the list box
                Customer selectedCustomer = customers[listBoxCustomers.SelectedIndex];

                // Display the customer data in the text boxes
                txtCustomerID.Text = selectedCustomer.CustomerNumber.ToString();
                txtCustomerName.Text = selectedCustomer.Name;
                txtCustomerContactDetails.Text = selectedCustomer.ContactDetails;
            }
        }
    }
}

