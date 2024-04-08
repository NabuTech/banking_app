using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Prototype.Models
{
    public class Account
    {
        // Properties
        public int UniqueID { get; set; }
        public decimal Balance { get; set; }

        // Constructors
        public Account () { }

        public Account (int uniqueID, decimal balance)
        {
            UniqueID = uniqueID;
            Balance = balance;

        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
