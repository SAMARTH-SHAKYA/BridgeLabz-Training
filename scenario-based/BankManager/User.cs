using System;

namespace BankSystem
{
    internal class User
    {
        public int ValidateUser(string[,] users, string acc, string pin)
        {
            for (int i = 0; i < users.GetLength(0); i++)
            {
                if (users[i, 0] == acc && users[i, 2] == pin)
                    return i;
            }
            return -1;
        }

        public void UserMenu(string[,] users, int index)
        {
            int choice;
            do
            {
                Console.WriteLine("\n1. View Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("0. Logout");
                Console.Write("Choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1) ViewBalance(users, index);
                else if (choice == 2) Deposit(users, index);
                else if (choice == 3) Withdraw(users, index);

            } while (choice != 0);
        }

        void ViewBalance(string[,] users, int index)
        {
            Console.WriteLine("Balance: " + users[index, 3]);
        }

        void Deposit(string[,] users, int index)
        {
            Console.Write("Amount: ");
            int amt = int.Parse(Console.ReadLine());
            int bal = int.Parse(users[index, 3]);
            users[index, 3] = (bal + amt).ToString();
            Console.WriteLine("Deposited");
        }

        void Withdraw(string[,] users, int index)
        {
            Console.Write("Amount: ");
            int amt = int.Parse(Console.ReadLine());
            int bal = int.Parse(users[index, 3]);

            if (bal - amt < 0)
            {
                Console.WriteLine("Insufficient Balance");
                return;
            }

            bal -= amt;

            if (bal < 2000)
            {
                Console.WriteLine("Low Balance Charge Applied: 100");
                bal -= 100;
            }

            users[index, 3] = bal.ToString();
            Console.WriteLine("Withdrawal Successful");
        }
    }
}
