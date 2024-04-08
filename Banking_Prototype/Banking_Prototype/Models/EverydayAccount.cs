using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Prototype.Models
{
    public class EverydayAccount : Account
    {
        // Properties
        public bool NoInterest {  get; set; }
        public bool NoOverdraft { get; set; }
        public bool NoTransactionFees { get; set; }

        // Constructor
        public EverydayAccount (int uniqueID, decimal balance, bool noInterest, bool noOverdraft, bool noTransactionFees)
            : base (uniqueID, balance)
        {
            NoInterest = noInterest;
            NoOverdraft = noOverdraft;
            NoTransactionFees = noTransactionFees;
        }
    }
}
