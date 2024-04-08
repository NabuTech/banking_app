using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Prototype.Models
{
    public class Customer
    {
        // Properties
        public int CustomerNumber { get; set; }
        public string Name { get; set; }
        public string ContactDetails { get; set; }
        public bool IsBankStaff { get; set; }

        // Constructors
        public Customer() { }

            public Customer(int customerNumber, string name, string contactDetails, bool isBankStaff)
            {
                CustomerNumber = customerNumber;
                Name = name;
                ContactDetails = contactDetails;
                IsBankStaff = isBankStaff;

            }
    }
}