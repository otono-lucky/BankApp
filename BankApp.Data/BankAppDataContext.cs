using BankApp.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BankApp.Data
{
    public class BankAppDataContext: DbContext
    {
        public BankAppDataContext() {
            this.Database.EnsureCreated();
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transact> Transactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Filename=./BankApp.db");
            //options.UseInMemoryDatabase("Ahdghfgekhgeh");
        }
    }
}
