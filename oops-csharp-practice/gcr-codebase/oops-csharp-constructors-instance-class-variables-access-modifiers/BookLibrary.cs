using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class BookLibrary
    {
        //global varibales
        public string ISBN;
        protected string title;
        private string author;

        //calling the constructor
        public BookLibrary(string isbn, string title, string author)
        {
            ISBN = isbn;
            this.title = title;
            this.author = author;
        }


        //method to get author
        public string GetAuthor()
        {
            return author;
        }

        //method to set author
        public void SetAuthor(string author)
        {
            this.author = author;
        }
    }


    //making subclass
    class EBook : BookLibrary
    {
        public EBook(string isbn, string title, string author)
            : base(isbn, title, author) { }

        public void Display()
        {
            Console.WriteLine($"ISBN: {ISBN}, Title: {title}");
        }
    }


}
