using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.BookBuddy
{
    internal class BookShelfMenu
    {
        private IBookShelf bookShelf;

        public void Menu()
        {
            bookShelf = new BookShelfUtility();

            bool isTrue = true;

            string[] books = bookShelf.DatabaseFetch();



            while (isTrue)
            {
                Console.WriteLine("Press 1 : To add books");
                Console.WriteLine("Press 2 : To Sort Books");
                Console.WriteLine("Press 3 : To search a book with author name");
                Console.WriteLine("Press 4 : Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter book in the format title - author ");
                        string book = Console.ReadLine();
                        bookShelf.AddBook(ref books, book);
                        bookShelf.ShowBooks(books);
                        break;

                    case 2:
                        bookShelf.SortBooks(ref books);
                        bookShelf.ShowBooks(books);
                        break;

                    case 3:
                        Console.WriteLine("Enter the name of the author");
                        string author = Console.ReadLine();
                        bookShelf.SearchByAuthor(books, author);
                        break;

                    case 4:
                        isTrue = false;
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            }
        }
    }
}
