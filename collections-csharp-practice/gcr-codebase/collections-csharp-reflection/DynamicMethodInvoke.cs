
using System;
using System.Reflection;

namespace BridgeLabzTraining.csharp_collections.assignment.reflection
{
    class MathOperations
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
    }

    class DynamicMethodInvoke
    {
        static void Main()
        {
            MathOperations obj = new MathOperations();
            Type type = typeof(MathOperations);

            MethodInfo method = type.GetMethod("Multiply");
            Console.WriteLine(method.Invoke(obj, new object[] { 6, 7 }));
        }
    }
}
