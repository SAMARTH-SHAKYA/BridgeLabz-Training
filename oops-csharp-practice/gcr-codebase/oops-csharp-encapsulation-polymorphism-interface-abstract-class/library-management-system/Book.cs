using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.library_management_system
{
    internal class Book : LibraryItem
    {
        public Book(string id, string title, string author)
            : base(id, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 14;
        }
    }
}
