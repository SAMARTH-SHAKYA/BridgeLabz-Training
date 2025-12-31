using System;

namespace BankSystem
{
    internal class Manager
    {
        public void ManagerMenu(string[,] users)
        {
            int choice;
            do
            {
                Console.WriteLine("\n1. Add User");
                Console.WriteLine("2. Modify User");
                Console.WriteLine("3. Delete User");
                Console.WriteLine("4. View Users");
                Console.WriteLine("0. Logout");
                Console.Write("Choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1) AddUser(users);
                else if (choice == 2) ModifyUser(users);
                else if (choice == 3) DeleteUser(users);
                else if (choice == 4) ViewUsers(users);

            } while (choice != 0);
        }

        void AddUser(string[,] users)
        {
            for (int i = 0; i < users.GetLength(0); i++)
            {
                if (users[i, 0] == "")
                {
                    Console.Write("Acc No: ");
                    users[i, 0] = Console.ReadLine();
                    Console.Write("Name: ");
                    users[i, 1] = Console.ReadLine();
                    Console.Write("PIN: ");
                    users[i, 2] = Console.ReadLine();
                    Console.Write("Balance: ");
                    users[i, 3] = Console.ReadLine();
                    Console.Write("Account Type: ");
                    users[i, 4] = Console.ReadLine();
                    users[i, 5] = "Active";
                    Console.WriteLine("User Added");
                    return;
                }
            }
            Console.WriteLine("User Limit Reached");
        }

        void ModifyUser(string[,] users)
        {
            Console.Write("Enter Acc No: ");
            string acc = Console.ReadLine();

            for (int i = 0; i < users.GetLength(0); i++)
            {
                if (users[i, 0] == acc)
                {
                    Console.Write("New Name: ");
                    users[i, 1] = Console.ReadLine();
                    Console.Write("New PIN: ");
                    users[i, 2] = Console.ReadLine();
                    Console.WriteLine("User Updated");
                    return;
                }
            }
            Console.WriteLine("User Not Found");
        }

        void DeleteUser(string[,] users)
        {
            Console.Write("Enter Acc No: ");
            string acc = Console.ReadLine();

            for (int i = 0; i < users.GetLength(0); i++)
            {
                if (users[i, 0] == acc)
                {
                    for (int j = 0; j < users.GetLength(1); j++)
                        users[i, j] = "";

                    Console.WriteLine("User Deleted");
                    return;
                }
            }
            Console.WriteLine("User Not Found");
        }

        void ViewUsers(string[,] users)
        {
            Console.WriteLine("\nAccNo  Name   Balance  Type  Status");
            for (int i = 0; i < users.GetLength(0); i++)
            {
                if (users[i, 0] != "")
                {
                    Console.WriteLine($"{users[i, 0]}  {users[i, 1]}  {users[i, 3]}  {users[i, 4]}  {users[i, 5]}");
                }
            }
        }
    }
}
