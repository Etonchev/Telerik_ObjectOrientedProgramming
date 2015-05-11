using System;
using System.Collections.Generic;

namespace _02_BankAccounts
{
    class ClassTest
    {
        static void Main()
        {
            Account testDepositAccount = new Deposit(Customer.Individual, 100.00M);
            Account testLoanAccount = new Loan(Customer.Company, 1000.00M);
            Account testMortgageAccount = new Mortgage(Customer.Individual, 300.00M);

            List<Account> accounts = new List<Account>();
            accounts.Add(testDepositAccount);
            accounts.Add(testLoanAccount);
            accounts.Add(testMortgageAccount);

            foreach (var account in accounts)
            {
                Console.WriteLine(account.CalculateInterestRate(10));
            }
        }
    }
}
