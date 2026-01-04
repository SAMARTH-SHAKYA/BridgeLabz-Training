using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Inheritance
{
 
    //main class book showing single level inheritance
    class Book
    {
        public string Title { get; set; }
        public int PublicationYear { get; set; }
    }

    //child class author
    class Author : Book
    {
        public string Name { get; set; }
        public string Bio { get; set; }

        //method to display the inforamation
        public void DisplayInfo()
        {
            Console.WriteLine($"{Title} ({PublicationYear}) by {Name}");
        }
    }

}
