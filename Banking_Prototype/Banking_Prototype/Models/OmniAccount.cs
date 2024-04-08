using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Prototype.Models
{
    public class OmniAccount : Account
    {
        // Additional properties specific to OmniAccount
        public bool InterestRatesAppliedOnlyOnBalancesOver1000 { get; set; }
        public bool SpecifiedOverdraftPermitted { get; set; }
        public decimal FeeIncurredForFailedTransactions { get; set; }

        // Constructor
        public OmniAccount(int uniqueID, decimal balance, bool interestRatesAppliedOnlyOnBalancesOver1000, bool specifiedOverdraftPermitted, decimal feeIncurredForFailedTransactions)
            : base(uniqueID, balance)
        {
            InterestRatesAppliedOnlyOnBalancesOver1000 = interestRatesAppliedOnlyOnBalancesOver1000;
            SpecifiedOverdraftPermitted = specifiedOverdraftPermitted;
            FeeIncurredForFailedTransactions = feeIncurredForFailedTransactions;
        }
    }
}
