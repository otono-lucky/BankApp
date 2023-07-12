using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Models
{
    public class CurrentAccount: Account
    {
        public CurrentAccount(decimal balance = 0.0m) : base(0.00m)
        {
            base.AcctBalance = balance;
            AcctType = "Current";
        }
        public decimal Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Amount cannot be zero");
            }
            if (base.AcctBalance - amount < MinBalance)
            {
                throw new InvalidOperationException(message: "Insufficient Funds");
            }
            this.AcctBalance -= amount;
            return this.AcctBalance;
        }
    }
}
