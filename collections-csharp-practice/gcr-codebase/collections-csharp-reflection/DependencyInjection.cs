
using System;
using System.Reflection;

namespace BridgeLabzTraining.csharp_collections.assignment.reflection
{
    [AttributeUsage(AttributeTargets.Field)]
    class InjectAttribute : Attribute { }

    class EmailService
    {
        public void Send()
        {
            Console.WriteLine("Email Sent");
        }
    }

    class Notification
    {
        [Inject]
        public EmailService service;
    }

    class SimpleDIContainer
    {
        public static void InjectDependencies(object obj)
        {
            foreach (var field in obj.GetType().GetFields())
            {
                if (field.GetCustomAttribute<InjectAttribute>() != null)
                {
                    object dependency =
                        Activator.CreateInstance(field.FieldType);
                    field.SetValue(obj, dependency);
                }
            }
        }
    }

    class DependencyInjection
    {
        static void Main()
        {
            Notification notify = new Notification();
            SimpleDIContainer.InjectDependencies(notify);
            notify.service.Send();
        }
    }
}
