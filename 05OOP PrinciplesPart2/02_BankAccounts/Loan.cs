using System;

namespace _02_BankAccounts
{
    class Loan : Account
    {
        public Loan(Customer customerType, decimal balance)
            : base(customerType, balance, 0)
        {
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override decimal CalculateInterestRate(int numberOfMonths)
        {
            if (CustomerType == Customer.Individual && numberOfMonths <= 3)
            {
                return 0;
            }

            if (CustomerType == Customer.Company && numberOfMonths <= 2)
            {
                return 0;
            }

            return base.CalculateInterestRate(numberOfMonths);
        }
    }
}
