using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Data.Interfaces
{
    public interface ICustomerRepository
    {
        public bool Create(Customer newCus);
        Customer RetrieveCustomer(string email);
        bool AuthCustomer(string Email, string password);
        bool Exist(string email);
    }
}
