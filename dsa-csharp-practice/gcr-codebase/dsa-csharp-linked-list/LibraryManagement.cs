using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_linked_list
{
    public class Book
    {
        public string Title;
        public string Author;
        public string Genre;
        public int BookID;
        public bool IsAvailable;
        public Book Next;
        public Book Prev;

        public Book(string title, string author, string genre, int id, bool status)
        {
            Title = title;
            Author = author;
            Genre = genre;
            BookID = id;
            IsAvailable = status;
            Next = null;
            Prev = null;
        }
    }



    public class LibraryManagementSystem
    {
        private Book head = null;
        private Book tail = null;

        public void AddBook(string title, string author, string genre, int id, bool status, int position)
        {
            Book newNode = new Book(title, author, genre, id, status);

            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            if (position <= 0)
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
                return;
            }

            Book current = head;
            int index = 0;
            while (current.Next != null && index < position - 1)
            {
                current = current.Next;
                index++;
            }

            if (current.Next == null && index < position)
            {
                current.Next = newNode;
                newNode.Prev = current;
                tail = newNode;
            }
            else
            {
                newNode.Next = current.Next;
                newNode.Prev = current;
                if (current.Next != null)
                    current.Next.Prev = newNode;
                current.Next = newNode;
            }
        }

        public void RemoveBook(int id)
        {
            Book current = head;
            while (current != null)
            {
                if (current.BookID == id)
                {
                    if (current.Prev != null)
                        current.Prev.Next = current.Next;
                    else
                        head = current.Next;

                    if (current.Next != null)
                        current.Next.Prev = current.Prev;
                    else
                        tail = current.Prev;

                    return;
                }
                current = current.Next;
            }
        }

        public void Search(string title = null, string author = null)
        {
            Book current = head;
            bool found = false;
            while (current != null)
            {
                if ((title != null && current.Title.Equals(title, StringComparison.OrdinalIgnoreCase)) ||
                    (author != null && current.Author.Equals(author, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"Found ID {current.BookID}: {current.Title} by {current.Author} [{current.Genre}] - Available: {current.IsAvailable}");
                    found = true;
                }
                current = current.Next;
            }
            if (!found) Console.WriteLine("No matching books found.");
        }

        public void UpdateStatus(int id, bool status)
        {
            Book current = head;
            while (current != null)
            {
                if (current.BookID == id)
                {
                    current.IsAvailable = status;
                    return;
                }
                current = current.Next;
            }
        }

        public void DisplayForward()
        {
            Book current = head;
            while (current != null)
            {
                Console.WriteLine($"ID: {current.BookID} | {current.Title} | {current.Author} | Status: {current.IsAvailable}");
                current = current.Next;
            }
        }

        public void DisplayReverse()
        {
            Book current = tail;
            while (current != null)
            {
                Console.WriteLine($"ID: {current.BookID} | {current.Title} | {current.Author} | Status: {current.IsAvailable}");
                current = current.Prev;
            }
        }

        public int CountBooks()
        {
            int count = 0;
            Book current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public static void Main()
        {
            LibraryManagementSystem library = new LibraryManagementSystem();
            library.AddBook("The Hobbit", "Tolkien", "Fantasy", 501, true, 0);
            library.AddBook("1984", "Orwell", "Dystopian", 502, true, 1);
            library.AddBook("Dracula", "Stoker", "Horror", 503, false, 1);

            Console.WriteLine("Forward Order:");
            library.DisplayForward();

            Console.WriteLine($"Total books: {library.CountBooks()}");

            Console.WriteLine("Searching for 'Orwell':");
            library.Search(author: "Orwell");

            Console.WriteLine("Updating status of ID 503 and removing ID 501...");
            library.UpdateStatus(503, true);
            library.RemoveBook(501);

            Console.WriteLine("Reverse Order:");
            library.DisplayReverse();
        }
    }
}
