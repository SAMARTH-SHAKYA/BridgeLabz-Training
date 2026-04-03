using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.csharp_collections.assignment.MSTest
{
    public class PasswordValidator
    {
        public bool IsValid(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            return password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsDigit);
        }
    }
}
