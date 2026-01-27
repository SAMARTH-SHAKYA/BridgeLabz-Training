using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.csharp_collections.assignment.MSTest
{
    public class CalculatorOperations
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot Divide By Zero");
            return a / b;
        }
    }
}
