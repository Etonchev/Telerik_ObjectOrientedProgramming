using System;

namespace _02_BankAccounts
{
    class Mortgage : Account
    {
        public Mortgage(Customer customerType, decimal balance)
            : base(customerType, balance, 0)
        {
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override decimal CalculateInterestRate(int numberOfMonths)
        {
            if (CustomerType == Customer.Individual && numberOfMonths <= 6)
            {
                return 0;
            }

            if (CustomerType == Customer.Company && numberOfMonths < 12)
            {
                InterestRate = 0.5;
                return (decimal)InterestRate * numberOfMonths * Balance;
            }

            return base.CalculateInterestRate(numberOfMonths);
        }
    }
}
