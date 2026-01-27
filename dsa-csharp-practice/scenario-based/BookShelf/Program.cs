using System;

class Program
{
    static void Main()
    {
        IBookShelf shelf = new BookShelfImpl();
        int choice;

        do
        {
            BookShelfUtility.PrintMenu();
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Genre: ");
                    string genre = Console.ReadLine();

                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();

                    shelf.AddBook(genre, title, author);
                    break;

                case 2:
                    Console.Write("Enter Genre: ");
                    genre = Console.ReadLine();

                    Console.Write("Enter Title: ");
                    title = Console.ReadLine();

                    shelf.RemoveBook(genre, title);
                    break;

                case 3:
                    Console.Write("Enter Genre: ");
                    genre = Console.ReadLine();

                    shelf.DisplayByGenre(genre);
                    break;

                case 4:
                    shelf.DisplayAll();
                    break;

                case 5:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 5);
    }
}
