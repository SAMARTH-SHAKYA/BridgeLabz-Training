using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.assignment.annotations
{
    // Attribute Definition
    [AttributeUsage(AttributeTargets.Method)]
    public class LogExecutionTimeAttribute : Attribute { }

    // Applying the Attribute
    public class Calculator
    {
        [LogExecutionTime]
        public void HeavyOperation()
        {
            Thread.Sleep(500);
        }
    }

    // Reflection Logic
    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            MethodInfo method = typeof(Calculator).GetMethod("HeavyOperation");

            Stopwatch sw = Stopwatch.StartNew();
            method.Invoke(calc, null);
            sw.Stop();

            Console.WriteLine($"Execution Time: {sw.ElapsedMilliseconds} ms");
        }
    }
}
