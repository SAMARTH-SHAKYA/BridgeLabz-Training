using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.library_management_system
{
    internal class ReservationUtility : IReservable
    {
        private string BorrowerId = "BR-7788";
        private bool isAvailable = true;

        public void ReserveItem(LibraryItem item)
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"Item reserved by {BorrowerId}");
            }
            else
            {
                Console.WriteLine("Item already reserved");
            }
        }

        public bool CheckAvailability(LibraryItem item)
        {
            return isAvailable;
        }
    }
}
