# UML Design

## Identify Classes

- **Customer Class**
  - Represents Individual Customers of the bank
  - Store customer Information:
    - Customer Number
    - Name
    - Contact Details
    - Differentiate between customers and bank staff

- **Accounts**
  - Represents different types of bank accounts
    - Everyday
    - Investment
    - Omni
  - Store account-specific information such as:
    - Unique ID,
    - Balance
    - Interest Rate,
    - Overdraft Limit,
    - Fee for failed withdrawals
  - Implement methods for:
    - Depositing and Withdrawing
    - Calculating Interest
    - Handling Failed Transactions
  - Differentiate between account types based on specific features and behaviors

- **Controller Class**
  - Act as central controller for managing customer and account data
  - Coordinate interactions between:
    - User Interface
    - Customer Data
    - Account Data
  - Implement business logic for operations such as:
    - Depositing and Withdrawing money
    - Transferring funds between accounts
    - Calculating Interest

  
