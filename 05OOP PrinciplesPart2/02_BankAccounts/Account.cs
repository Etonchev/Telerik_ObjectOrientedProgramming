using System;

namespace _02_BankAccounts
{
    public enum Customer { Individual, Company};

    abstract class Account
    {
        public Customer CustomerType { get; set; }
        public decimal Balance { get; set; }
        public double InterestRate { get; set; }

        public Account(Customer customerType, decimal balance, int interestRate)
        {
            CustomerType = customerType;
            Balance = balance;
            InterestRate = interestRate;
        }

        public virtual decimal CalculateInterestRate(int numberOfMonths)
        {
            if (numberOfMonths > 0)
            {
                InterestRate = 1;
                return (decimal)InterestRate * numberOfMonths * Balance;
            }
            else
            {
                throw new System.ArgumentException("Number of months must be a positive number !");
            }
        }
    }
}
