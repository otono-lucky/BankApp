using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Core.IService
{
    public interface ITransactionService
    {
        public Transact AddTransaction(string Acct, Decimal Amount, string TransactionType, DateTime date, string Note);

        public Transact RetrieveTransaction(string Acct, Decimal Amount, DateTime date, string Note);
    }
}
