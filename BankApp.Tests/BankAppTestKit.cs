using BankApp.Core;
using BankApp.Data;
using BankApp.Data.Repositories;
using BankApp.Models;
using System;
using Xunit;

namespace BankApp.Tests
{
    public class BankAppTestKit
    {
        [Fact]
        public void ValidCustomerTest()
        {
            // Arrange
            var customerRepo = new CustomerRepository(new BankAppDataContext());
            var customer = new Customer()
            {
                FirstName = "Chuks",
                LastName = "Onuh",
                Email = "chuksonuh@gmail.com",
                Password = "1234",
            };
            // Act
            var actual = customerRepo.Create(customer);
            var expected = true;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void InValidCustomerTest()
        {
            // Arrange
            var customerRepo = new CustomerRepository(new BankAppDataContext());
            var customer = new Customer()
            {
                FirstName = "Chuks",
                LastName = "Onuh",
                Email = "chuksonuh@gmail.com",
                Password = "1234345",
            };
            // Act
            var actual = customerRepo.Create(customer);
            var expected = true;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CustomerExixtenceTest()
        {
            // Arrange
            var customerRepo = new CustomerRepository(new BankAppDataContext());
            var customer = new Customer();
            // Act
            var actual = customerRepo.Exist("chuksonuh@gmail.com");
            var expected = true;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void InvalidCustomerExistenceTest()
        {
            // Arrange
            var customerRepo = new CustomerRepository(new BankAppDataContext());
            var customer = new Customer();
            // Act
            var actual = customerRepo.Exist("");
            var expected = false;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AuthenticateUserWithCorrectLoginDetails()
        {
            // Arrange
            CustomerRepository customerRepo = new CustomerRepository(new BankAppDataContext());
            CustomerService customerService = new CustomerService(new CustomerRepository(new BankAppDataContext()), new AccountService(new AccountRepository(new BankAppDataContext())));
            // Act
           
            var actual = customerService.Login("chuksonuh@gmail.com", "1234");
            var expected = true;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AuthenticateUserWithInCorrectLoginDetails()
        {
            // Arrange
            CustomerRepository customerRepo = new CustomerRepository(new BankAppDataContext());
            CustomerService customerService = new CustomerService(new CustomerRepository(new BankAppDataContext()), new AccountService(new AccountRepository(new BankAppDataContext())));
            // Act

            var actual = customerService.Login("chuksonuh@gmail.com", "1234567");
            var expected = false;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ValidCreateAccountTest()
        {
            // Arrange
            var accountRepo = new AccountRepository(new BankAppDataContext());
            var account = new Account()
            {
                AccNumber = "7378493038",
                AcctBalance = 2000.00m,
                AcctType = "Savings",
                CustomerId = 1
            };
            // Act
            var actual = accountRepo.CreateAccount(account);
            var expected = true;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void InValidCreateAccountTest()
        {
            // Arrange
            var accountRepo = new AccountRepository(new BankAppDataContext());
            var account = new Account()
            {
                AccNumber = "2378493038",
                AcctBalance = 2000.00m,
                AcctType = "FixedAccount",
                CustomerId = 2
                
            };
            // Act
            var actual = accountRepo.CreateAccount(account);
            var expected = true;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ValidDepositTest()
        {
            // Assert
            var accountRepo = new AccountRepository(new BankAppDataContext());
            var account = new Account();
            var accNumber = "2378493038";
            decimal amount = 200000.00m;
            // Act
            var actual = accountRepo.Deposit(accNumber, account.AcctBalance += amount);
            var expected = true;
            // Assert
            Assert.Equal(expected, actual);
        } 
        [Fact]
        public void InValidDepositTest()
        {
            // Assert
            var accountRepo = new AccountRepository(new BankAppDataContext());
            var account = new Account();
            var accNumber = "2378493038";
            decimal amount = 2000.00m;
            // Act
            var actual = accountRepo.Deposit(accNumber, account.AcctBalance);
            var expected = true;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ValidWithdrawalTest()
        {
            // Arrange
            var accountRepo = new AccountRepository(new BankAppDataContext());
            var account = new Account();
            var accNumber = "2378493038";
            decimal amount = 2000.00m;
            // Act
            var actual = accountRepo.Withdrawal(accNumber, account.AcctBalance -= amount);
            var expected = true;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void InvalidValidWithdrawalTest()
        {
            // Arrange
            var accountRepo = new AccountRepository(new BankAppDataContext());
            var account = new Account();
            var accNumber = "2378493038";
            decimal amount = 2000.00m;
            // Act
            var actual = accountRepo.Withdrawal(accNumber, account.AcctBalance);
            var expected = true;
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ValidTransferTest()
        {
            // Arrange
            var accountRepo = new AccountRepository(new BankAppDataContext());
            var account = new Account();
            var accSender = "2378493038";
            var accReceiver = "7378493038";
            var description = "School fees";
            var amount = 1000.00m;
            var balance = accountRepo.GetAccountBalane(accSender);
            var expected = balance-amount;
            // Act
            accountRepo.Transfer(accSender, accReceiver, amount, description);
            var actual = accountRepo.GetAccountBalane(accSender);
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InvalidTransferTest()
        {
            // Arrange
            var accountRepo = new AccountRepository(new BankAppDataContext());
            var account = new Account();
            var accSender = "2378493038";
            var accReceiver = "7378493038";
            var description = "School fees";
            var amount = -1000.00m;
            
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(()=>accountRepo.Transfer(accSender, accReceiver, amount, description));

        }
    }
}
