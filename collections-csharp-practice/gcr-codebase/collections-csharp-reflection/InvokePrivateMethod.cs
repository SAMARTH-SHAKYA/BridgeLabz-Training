using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.assignment.reflection
{
    class Calculator
    {
        private int Multiply(int a, int b) => a * b;
    }
    internal class InvokePrivateMethod
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            MethodInfo m = typeof(Calculator).GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

            Console.WriteLine(m.Invoke(calc, new object[] { 4, 5 }));
        }
    }
}
