using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class LibraryBooking
    {
        
        string Title;
        string Author;
        string Price;
        string Availability;

        //parameterised constructor
        public LibraryBooking(string title, string author, string price, string availability)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
            this.Availability = availability;
        }
        
        //method to borrow book
        public void BorrowBook()
        {
            if(Availability == "yes")
            {
                Console.WriteLine("Book is available to borrow Press 1 to borrow");
                int choice = Convert.ToInt32(Console.ReadLine());

                if(choice == 1)
                {
                    Console.WriteLine("Book have been issued to you");
                    Availability = "no";
                }

                Console.WriteLine("Thank you for visiting your store");

            }
        }
    }
}
