using BankApp.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BankApp.Models
{
    public class Account
    {
        public decimal MinBalance;
        [Key]
        public int AccountId { get; set; }
        public string AccNumber { get; set; }
        public Decimal AcctBalance { get; set; }
        public string AcctType { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<Transact> Transactions { get; set; }

        // Constructor for Account
        public Account(decimal minBalance)
        {
            this.MinBalance = minBalance;
            AccNumber = AccountNumberGenerator.AccNumGenerator();
        }
        public Account()
        {
            AccNumber = AccountNumberGenerator.AccNumGenerator();
        }
    }
}
