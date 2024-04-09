using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Prototype.Models
{
    public class InvestmentAccount : Account
    {
        public decimal VariableInterestRate { get; set; }
        public bool IncursFeesForFailedTransactions { get; set; }

        // Constructor
        public InvestmentAccount(int uniqueID, decimal balance, decimal variableInterestRate, bool incursFeeForFailedTransactions)
            : base (uniqueID, balance)
        {
            VariableInterestRate = variableInterestRate;
            IncursFeesForFailedTransactions = incursFeeForFailedTransactions;
        }
    }


}
