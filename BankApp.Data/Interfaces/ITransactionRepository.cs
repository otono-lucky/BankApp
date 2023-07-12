using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Data.Interfaces
{
    public interface ITransactRepository
    {
        public Transact AddTransaction(string Acct, Decimal Amount, string TransactionType, DateTime date, string Note);
        public Transact RetrieveTransaction(string Acct, Decimal Amount, DateTime date, string Note);
    }
}
