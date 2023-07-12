using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Core.IService
{
    public interface ICustomerService
    {
        public Customer Create(string FirstName, string LastName, string Email, string Password, decimal initialDeposit, string accountType);
        Customer RetrieveCustomer(string email);
        bool Login(string email, string password);
    }
}
