using BridgeLabzTraining.Scenario_oops.;
using System;

namespace BankSystem
{
    internal class Program
    {
        static void Main()
        {
            
            string[,] users = new string[,]
            {
                {"101","Ravi","1111","5000","Savings","Active"},
                {"102","Amit","2222","1500","Savings","Active"},
                {"103","Neha","3333","8000","Current","Active"},
                {"","","","","",""},
                {"","","","","",""}
            };

            string managerId = "admin";
            string managerPass = "admin123";

            Console.WriteLine("1. Manager Login");
            Console.WriteLine("2. User Login");
            Console.Write("Choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Manager ID: ");
                string id = Console.ReadLine();
                Console.Write("Password: ");
                string pass = Console.ReadLine();

                if (id == managerId && pass == managerPass)
                {
                    Manager manager = new Manager();
                    manager.ManagerMenu(users);
                }
                else
                {
                    Console.WriteLine("Invalid Manager Login");
                }
            }
            else if (choice == 2)
            {
                Console.Write("Account No: ");
                string acc = Console.ReadLine();
                Console.Write("PIN: ");
                string pin = Console.ReadLine();

                User user = new User();
                int index = user.ValidateUser(users, acc, pin);

                if (index != -1)
                {
                    user.UserMenu(users, index);
                }
                else
                {
                    Console.WriteLine("Invalid User Login");
                }
            }
        }
    }
}
