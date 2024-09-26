# Simple Bank Account Unit Testing in C#

## Project Overview
This project demonstrates unit testing for a simple Bank Account class in C#. The class simulates basic banking operations such as creating an account, depositing, and withdrawing money, with unit tests to validate different scenarios.
## Features
1. Create a bank account with an initial balance. <br />
2. Deposit money into the account, with validation for positive amounts.<br />
3. Withdraw money from the account, including checks for negative amounts and overdrafts.<br />

*Unit tests for scenarios:* <br />
1. Successful account creation.<br />
2. Depositing positive amounts.<br />
3. Handling negative deposit attempts.<br />
4. Withdrawing valid amounts.<br />
5. Handling invalid withdrawals (negative amounts or exceeding balance).<br />


## Tech Stack
*Language:* C#<br />
*Testing Framework:*  NUnit<br />
*IDE:* Visual Studio<br />

## How It Works
The Bank Account class allows basic operations such as adding and withdrawing money. Each method has been unit tested to ensure proper functionality and error handling.<br />
Key Methods in BankAccount Class:<br />
1. **BankAccount (double amount)**: Constructor for creating account<br />
2. **Deposit (double amount)**: Adds money to the account if the amount is positive.<br />
3. **Withdraw (double amount)**: Removes money from the account, ensuring the amount is valid and doesn’t exceed the current balance.<br />


## Test Cases<br />
**Account Creation Test**: Asserts that a new bank account can be created with a valid initial balance.<br />
**Positive Deposit Test**: Tests depositing a positive amount.<br />
**Negative Deposit Test**: Ensures the system rejects negative deposits.<br />
**Valid Withdrawal Test**: Tests withdrawing an amount that is less than to the account balance.<br />
**Negative Withdrawal Test**: Ensures that attempting to withdraw a negative amount raises an error.<br />
**Exceeding Withdrawal Test**: Ensures that attempting to withdraw more than the available balance raises an error.
