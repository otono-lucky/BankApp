using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BankApp.Models
{
    public class Transact
    {
        [Key]
        public int TransactionId { get; set; }
        public string TransactionType { get; set; }
        public string AcctNumber { get; set; }
        public string BeneficiaryAcct { get; set; }
        public Decimal Amount { get; set; }
        public string Note { get; set; }
        public DateTime TransactDate { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
