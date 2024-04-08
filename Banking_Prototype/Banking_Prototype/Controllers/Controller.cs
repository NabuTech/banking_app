using Banking_Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Prototype.Controllers
{
    public class Controller
    {
        // Properties
        private List<Customer> customers;
        private List<Account> accounts;

        // Constructor
        public Controller()
        {
            customers = new List<Customer>();
            accounts = new List<Account>();
        }

        // Methods
        // Add methods to manage customers and accounts
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        // Add additional methods as needed
    }
}
