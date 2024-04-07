Customer
---------
- CustomerNumber: int
- Name: string
- ContactDetails: string
- IsBankStaff: bool

+ Customer()
+ Customer(customerNumber: int, name: string, contactDetails: string, isBankStaff: bool)
+ GetCustomerNumber(): int
+ GetName(): string
+ GetContactDetails(): string
+ IsBankStaff(): bool
+ SetIsBankStaff(isBankStaff: bool): void

Account
---------
- UniqueID: int
- Balance: decimal

+ Account()
+ Account(uniqueID: int, balance: decimal)
+ GetUniqueID(): int
+ GetBalance(): decimal
+ Deposit(amount: decimal): void
+ Withdraw(amount: decimal): void

EverydayAccount
----------------
- NoInterest: bool
- NoOverdraft: bool
- NoTransactionFees: bool

+ EverydayAccount()
+ EverydayAccount(uniqueID: int, balance: decimal, noInterest: bool, noOverdraft: bool, noTransactionFees: bool)
+ CalculateInterest(): decimal
+ ApplyTransactionFee(): void

InvestmentAccount
------------------
- VariableInterestRate: decimal
- IncursFeeForFailedTransactions: bool

+ InvestmentAccount()
+ InvestmentAccount(uniqueID: int, balance: decimal, variableInterestRate: decimal, incursFeeForFailedTransactions: bool)
+ CalculateInterest(): decimal
+ ApplyTransactionFee(): void

OmniAccount
-------------
- InterestRatesAppliedOnlyOnBalancesOver1000: bool
- SpecifiedOverdraftPermitted: bool
- FeeIncurredForFailedTransactions: decimal

+ OmniAccount()
+ OmniAccount(uniqueID: int, balance: decimal, interestRatesAppliedOnlyOnBalancesOver1000: bool, specifiedOverdraftPermitted: bool, feeIncurredForFailedTransactions: decimal)
+ CalculateInterest(): decimal
+ ApplyTransactionFee(): void
