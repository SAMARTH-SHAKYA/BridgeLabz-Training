using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.library_management_system
{
    internal class LibraryMenu
    {
        private IReservable reservationUtility;

        public void Menu()
        {
            reservationUtility = new ReservationUtility();

            LibraryItem item =
                new Book("B101", "Clean Code", "Robert C. Martin");

            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("Press 1 : Show item details");
                Console.WriteLine("Press 2 : Check availability");
                Console.WriteLine("Press 3 : Reserve item");
                Console.WriteLine("Press 4 : Loan duration");
                Console.WriteLine("Press 5 : Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        item.GetItemDetails();
                        break;

                    case 2:
                        Console.WriteLine(reservationUtility.CheckAvailability(item));
                        break;

                    case 3:
                        reservationUtility.ReserveItem(item);
                        break;

                    case 4:
                        Console.WriteLine(item.GetLoanDuration());
                        break;

                    case 5:
                        isTrue = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
