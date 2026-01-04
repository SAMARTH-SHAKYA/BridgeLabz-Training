using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Sealed
{
    
    //class book
    class Book
    {
        //satic global variables
        public static string LibraryName = "City Library";

        //non static global variables
        public string ISBN { get; private set; }
        public string Title { get; set; }
        public string Author { get; set; }


        //class book
        public Book(string isbn, string title, string author)
        {
            this.ISBN = isbn;
            this.Title = title;
            this.Author = author;
        }

        //method to display library name
        public static void DisplayLibraryName()
        {
            Console.WriteLine("Library Name: " + LibraryName);
        }

        //method to check instance of the object
        public void Display(object obj)
        {
            if (obj is Book)
            {
                Console.WriteLine($"ISBN: {ISBN}, Title: {Title}, Author: {Author}");
            }
        }
    }

}
