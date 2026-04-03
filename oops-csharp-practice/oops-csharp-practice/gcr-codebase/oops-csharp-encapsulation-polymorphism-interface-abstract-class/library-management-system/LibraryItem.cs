using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.library_management_system
{
    internal abstract class LibraryItem
    {
        public string ItemId { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }

        protected LibraryItem(string itemId, string title, string author)
        {
            this.ItemId = itemId;
            this.Title = title;
            this.Author = author;
        }

        public void GetItemDetails()
        {
            Console.WriteLine($"ID : {ItemId}");
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Author : {Author}");
        }

        public abstract int GetLoanDuration();
    }
}
