using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.csharp_collections.assignment.MSTest
{
    public class StringUtils
    {
        public string Reverse(string s) => new string(s.Reverse().ToArray());

        public bool IsPalindrome(string s) => s.SequenceEqual(s.Reverse());

        public string ToUpper(string s) => s.ToUpper();
    }
}
