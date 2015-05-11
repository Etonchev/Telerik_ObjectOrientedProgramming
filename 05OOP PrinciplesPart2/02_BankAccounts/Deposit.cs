using System;

namespace _02_BankAccounts
{
    class Deposit : Account
    {
        public Deposit(Customer customerType, decimal balance)
            : base(customerType, balance, 0)
        {
        }

        public void DepositMoney(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance - amount < 0)
            {
                throw new Exception("Not enough money in account !");
            }

            Balance -= amount;
        }

        public override decimal CalculateInterestRate(int numberOfMonths)
        {
            if (Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterestRate(numberOfMonths);
        }
    }
}
