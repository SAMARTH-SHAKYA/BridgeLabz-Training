using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.ClassAndObject
{
    class execute
    {
        public static void Main()
        {


            Book book = new Book("Day and Night", "Tony Stark", 3242);
            //only read possible not write due to implemenation on read only
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);
            Console.WriteLine(book.Price);


        }
    }
    

    //making the book class
    internal class Book
        {
            //applying only get for private fields
            public string Author { get; }
            public string Title { get; }
            public double Price { get; }

            //calling contructor
            public Book(string title, string author, double price)
            {
                this.Title = title;
                this.Author = author;
                this.Price = price;
            }
        }

}
    