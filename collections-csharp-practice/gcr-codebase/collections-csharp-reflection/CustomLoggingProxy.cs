using System;
using System.Reflection;

namespace BridgeLabzTraining.csharp_collections.assignment.reflection
{
    public interface IGreeting
    {
        void SayHello();
    }

    public class Greeting : IGreeting
    {
        public void SayHello()
        {
            Console.WriteLine("Hello from Greeting class");
        }
    }

    public class LoggingProxy : DispatchProxy
    {
        private IGreeting _target;

        public static IGreeting Create(IGreeting target)
        {
            object proxy = Create<IGreeting, LoggingProxy>();
            ((LoggingProxy)proxy)._target = target;
            return (IGreeting)proxy;
        }

        protected override object Invoke(
            MethodInfo targetMethod, object[] args)
        {
            Console.WriteLine("Invoking Method: " + targetMethod.Name);
            return targetMethod.Invoke(_target, args);
        }
    }

    class CustomLoggingProxy
    {
        static void Main()
        {
            IGreeting greeting =
                LoggingProxy.Create(new Greeting());

            greeting.SayHello();
        }
    }
}
