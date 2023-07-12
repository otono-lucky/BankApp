using BankApp.Data.Interfaces;
using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Core
{
    class TransactionService: ITransactRepository
    {
        private readonly ITransactRepository _transactRepo;
        public TransactionService(ITransactRepository transact)
        {
            _transactRepo = transact;
        }

        public Transact AddTransaction(string Acct, decimal Amount, string TransactionType, DateTime date, string Note)
        {
            Transact transaction = new Transact()
            {
                TransactionType = TransactionType,
                AcctNumber = Acct,
                Amount = Amount,
                TransactDate = date,
                Note = Note
            };
            _transactRepo.AddTransaction(Acct, Amount, TransactionType, date, Note);
            return transaction;
        }
        public Transact RetrieveTransaction(string Acct, decimal Amount, DateTime date, string Note)
        {
            Transact transaction = new Transact()
            {
                TransactionType = "Withdrawal",
                AcctNumber = Acct,
                Amount = Amount,
                TransactDate = date,
                Note = Note
            };
            return transaction;
        }
    }
}
