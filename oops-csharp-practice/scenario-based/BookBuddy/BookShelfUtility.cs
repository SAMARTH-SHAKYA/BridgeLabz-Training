using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.BookBuddy
{
    internal class BookShelfUtility : IBookShelf
    {
        public string[] DatabaseFetch()
        {
            string[] books = {
                    "The Silent Forest - Arjun Mehta",
                    "Wings of Dreams - Riya Sharma",
                    "Beyond the Horizon - Amit Verma",
                    "Mystery of the Old House - Neha Kapoor",
                    "Code of Life - Rahul Singh",
                    "The Last Sunset - Ananya Roy",
                    "Journey to Nowhere - Karan Malhotra"
                };

            return books;
        }


        public void AddBook(ref string[] books, string bookFromUser)
        {
            try
            {
                if (!bookFromUser.Contains(" - "))
                    throw new FormatException("Invalid format! Use: Title - Author");

                string[] parts = bookFromUser.Split(" - ");
                if (parts.Length != 2 || string.IsNullOrWhiteSpace(parts[0]) || string.IsNullOrWhiteSpace(parts[1]))
                    throw new FormatException("Invalid format! Title or Author missing.");

                int newSize = books.Length + 1;
                string[] newBooks = new string[newSize];

                for (int i = 0; i < books.Length; i++)
                    newBooks[i] = books[i];

                newBooks[newSize - 1] = bookFromUser;
                books = newBooks;

                Console.WriteLine("Book added successfully!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void SortBooks(ref string[] books)
        {
            int n = books.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    string title1 = books[j].Split(" - ")[0];
                    string title2 = books[j + 1].Split(" - ")[0];

                    if (string.Compare(title1, title2) > 0)
                    {
                        string temp = books[j];
                        books[j] = books[j + 1];
                        books[j + 1] = temp;
                    }
                }
            }
        }



        public void SearchByAuthor(string[] books, string author)
        {
            bool found = false;

            for (int i = 0; i < books.Length; i++)
            {
                string[] parts = books[i].Split(" - ");
                if (parts.Length == 2 && parts[1].ToLower() == author.ToLower())
                {
                    Console.WriteLine(books[i]);
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No books found for this author.");
        }



        public void ShowBooks(string[] books)
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i]);
            }
        }

    }
}
