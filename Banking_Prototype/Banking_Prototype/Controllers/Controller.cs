using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Banking_Prototype.Models;

namespace Banking_Prototype.Controllers
{
    public class Controller
    {
        // Properties
        private Dictionary<int, Customer> customersDictionary;
        private List<Customer> customersList;
        private List<Account> accounts;
        private string filePath;

        // Constructor
        public Controller(string jsonFilePath)
        {
            customersDictionary = new Dictionary<int, Customer>();
            customersList = new List<Customer>();
            accounts = new List<Account>();
            filePath = jsonFilePath;
            LoadCustomersFromFile();
        }

        // Methods

        // Load customers from JSON file
        private void LoadCustomersFromFile()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonContent = File.ReadAllText(filePath);
                    customersList = JsonConvert.DeserializeObject<List<Customer>>(jsonContent);
                }
                else
                {
                    Console.WriteLine("JSON file not found at the specified path.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading customers: {ex.Message}");
            }
        }

        // Save customers to JSON file
        // Save customers to JSON file
        // Save customers to JSON file
        public void SaveCustomersToFile()
        {
            try
            {
                string jsonContent = JsonConvert.SerializeObject(customersList, Formatting.Indented);
                File.WriteAllText(filePath, jsonContent);
                Console.WriteLine("Saving customers to file...");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving customers: {ex.Message}");
            }
        }


        public List<Customer> GetCustomers()
        {
            return customersList;
        }

        public void AddCustomer(Customer customer)
        {
            customersList.Add(customer); // Add the new customer to the list
            SaveCustomersToFile(); // Save customers after addition
        }

        public void EditCustomer(int customerNumber, string newName, string newContactDetails)
        {
            if (customersDictionary.ContainsKey(customerNumber))
            {
                // Update the customer's details
                customersDictionary[customerNumber].Name = newName;
                customersDictionary[customerNumber].ContactDetails = newContactDetails;
                customersList = customersDictionary.Values.ToList(); // Update list from dictionary

                // Save customers after editing
                SaveCustomersToFile();
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }

        // Delete customer
        public bool DeleteCustomer(int customerNumber)
        {
            Customer customerToRemove = customersList.Find(c => c.CustomerNumber == customerNumber);
            if (customerToRemove != null)
            {
                customersList.Remove(customerToRemove);
                SaveCustomersToFile(); // Ensure to save changes after removing the customer
                return true;
            }
            else
            {
                Console.WriteLine("Customer not found.");
                return false;
            }
        }



        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }
    }
}
