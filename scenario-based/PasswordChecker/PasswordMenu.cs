using System;

public class Menu
{
    private IPasswordCracker cracker = new PasswordCracker();

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("\n==== Password Cracker Simulator ====");
            Console.WriteLine("1. Generate All Combinations");
            Console.WriteLine("2. Crack a Password");
            Console.WriteLine("3. Exit");
            Console.Write("Choose option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter length (max 5): ");
                    int len = Convert.ToInt32(Console.ReadLine());
                    if (len > 5) len = 5;
                    cracker.GenerateAll(len);
                    break;

                case 2:
                    Console.Write("Enter password (alphabets only, max 5): ");
                    string pwd = Console.ReadLine();
                    if (pwd.Length > 5) pwd = pwd.Substring(0, 5);
                    cracker.CrackPassword(pwd);
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
