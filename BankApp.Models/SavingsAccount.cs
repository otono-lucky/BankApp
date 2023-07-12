using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Models
{
    public class SavingsAccount: Account
    {
        public SavingsAccount(decimal balance = 0.0m) : base(1000.00m)
        {
            base.AcctBalance = balance;
            AcctType = "Savings";
        }
        public decimal Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Amount cannot be zero ");
            }
            if (base.AcctBalance - amount < base.MinBalance)
            {
                throw new InvalidOperationException(message: "Insufficient Funds");
            }
            this.AcctBalance -= amount;
            return this.AcctBalance;
        }
    }
}
