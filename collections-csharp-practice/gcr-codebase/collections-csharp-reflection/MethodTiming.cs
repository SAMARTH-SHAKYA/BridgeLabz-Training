
using System;
using System.Diagnostics;
using System.Reflection;

namespace BridgeLabzTraining.csharp_collections.assignment.reflection
{
    class TestClass
    {
        public void SlowMethod() => System.Threading.Thread.Sleep(1000);
    }

    class MethodTiming
    {
        static void Main()
        {
            TestClass obj = new TestClass();
            MethodInfo method = typeof(TestClass).GetMethod("SlowMethod");

            Stopwatch sw = Stopwatch.StartNew();
            method.Invoke(obj, null);
            sw.Stop();

            Console.WriteLine("Execution Time: " + sw.ElapsedMilliseconds + " ms");
        }
    }
}
