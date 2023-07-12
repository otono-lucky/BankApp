using System;

namespace BankApp.Commons
{
    public static class AccountNumberGenerator
    {
        public static string AccNumGenerator()
        {
            var random = new Random();
            return $"23{random.Next(1000, 9999)}{random.Next(1000, 9999)}";
        }
    }
}
