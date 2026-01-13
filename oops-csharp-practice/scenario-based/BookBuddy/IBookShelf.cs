using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.BookBuddy
{
    internal interface IBookShelf
    {
        public void AddBook(ref string[] books, string bookFromUser);
        public string[] DatabaseFetch();
        public void SortBooks(ref string[] books);
        public void SearchByAuthor(string[] books, string author);
        public void ShowBooks(string[] books);
    }
}
