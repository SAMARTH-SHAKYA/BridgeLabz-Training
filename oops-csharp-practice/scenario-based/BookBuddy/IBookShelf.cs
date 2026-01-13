using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.BookBuddy
{
    internal interface IBookShelf
    {
        public void AddBook(ArrayList books, string bookFromUser);
        public ArrayList DatabaseFetch();

        public void SortBooks(ArrayList books);

        public void SearchByAuthor(ArrayList books, string author);

        public void ShowBooks(ArrayList books);
    }
}
