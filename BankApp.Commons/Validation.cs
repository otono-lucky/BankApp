using System.Text.RegularExpressions;

namespace BankApp.Commons
{
    public static class Validation
    {
        public static string RemoveDigit(string str)
        {
            string output = Regex.Replace(str, @"[\d]", string.Empty);
            return output;
        }
        public static string Capitalize(string str)
        {
            if (str == null)
                return null;

            if (char.IsUpper(str[0]) && str.Length > 1)
                return str;
            var s = char.ToUpper(str[0]) + str.Substring(1);
            return s;
        }
        public static bool EmailValidation(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (regex.Match(email).Success)
                return true;
            return false;
        }
    }
}
