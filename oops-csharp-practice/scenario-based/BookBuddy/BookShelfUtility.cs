using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.BookBuddy
{
    internal class BookShelfUtility : IBookShelf
    {
        public ArrayList DatabaseFetch()
        {
            ArrayList books = new ArrayList();

            books.Add("The Silent Forest - Arjun Mehta");
            books.Add("Wings of Dreams - Riya Sharma");
            books.Add("Beyond the Horizon - Amit Verma");
            books.Add("Mystery of the Old House - Neha Kapoor");
            books.Add("Code of Life - Rahul Singh");
            books.Add("The Last Sunset - Ananya Roy");
            books.Add("Journey to Nowhere - Karan Malhotra");


            return books;
        }


        public void AddBook(ArrayList books, string bookFromUser)
        {
            try
            {
                //check if format is correct
                if (!bookFromUser.Contains(" - "))
                {
                    throw new FormatException("Invalid format! Use: Title - Author");
                }

                string[] parts = bookFromUser.Split(" - ");

                if (parts.Length != 2 || string.IsNullOrWhiteSpace(parts[0]) || string.IsNullOrWhiteSpace(parts[1]))
                {
                    throw new FormatException("Invalid format! Title or Author is missing.");
                }

                books.Add(bookFromUser);
                Console.WriteLine("Successfully added book to the database");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SortBooks(ArrayList books)
        {
            string[] booksArray = (string[])books.ToArray(typeof(string));

            int n = booksArray.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    string title1 = booksArray[j].Split(" - ")[0];
                    string title2 = booksArray[j + 1].Split(" - ")[0];

                    if (string.Compare(title1, title2) > 0)
                    {
                        // Swap
                        string temp = booksArray[j];
                        booksArray[j] = booksArray[j + 1];
                        booksArray[j + 1] = temp;
                    }
                }
            }

            books.Clear();


            for (int i = 0; i < n; i++)
            {
                books.Add(booksArray[i]);
            }
        }


        public void SearchByAuthor(ArrayList books, string author)
        {

            foreach (string book in books)
            {
                string[] parts = book.Split(" - ");

                if (parts.Length == 2)
                {
                    string bookAuthor = parts[1];

                    if (bookAuthor.ToLower() == author.ToLower())
                    {
                        Console.WriteLine("book founded for this author.");
                        Console.WriteLine(book);
                        return;
                    }
                }
            }
            Console.WriteLine("No books found for this author.");
        }


        public void ShowBooks(ArrayList books) 
        {
            foreach (string book in books) 
            {
                Console.WriteLine(book);
            }
        }
    }
}
