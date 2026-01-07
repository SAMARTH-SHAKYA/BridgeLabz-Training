using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.library_management_system
{
    internal interface IReservable
    {
        void ReserveItem(LibraryItem item);
        bool CheckAvailability(LibraryItem item);
    }
}
