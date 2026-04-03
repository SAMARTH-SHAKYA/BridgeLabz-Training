using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_linked_list
{
    public class Ticket
    {
        public int TicketID;
        public string CustomerName;
        public string MovieName;
        public string SeatNumber;
        public string BookingTime;
        public Ticket Next;

        public Ticket(int id, string name, string movie, string seat, string time)
        {
            TicketID = id;
            CustomerName = name;
            MovieName = movie;
            SeatNumber = seat;
            BookingTime = time;
            Next = null;
        }
    }



    public class TicketReservationSystem
    {
        private Ticket head = null;
        private Ticket tail = null;

        public void AddTicket(int id, string name, string movie, string seat, string time)
        {
            Ticket newTicket = new Ticket(id, name, movie, seat, time);

            if (head == null)
            {
                head = newTicket;
                tail = newTicket;
                newTicket.Next = head;
            }
            else
            {
                tail.Next = newTicket;
                tail = newTicket;
                tail.Next = head;
            }
        }

        public void RemoveTicket(int id)
        {
            if (head == null) return;

            Ticket current = head;
            Ticket previous = tail;

            do
            {
                if (current.TicketID == id)
                {
                    if (current == head && current == tail)
                    {
                        head = null;
                        tail = null;
                    }
                    else
                    {
                        previous.Next = current.Next;
                        if (current == head) head = previous.Next;
                        if (current == tail) tail = previous;
                    }
                    Console.WriteLine($"Ticket {id} removed.");
                    return;
                }
                previous = current;
                current = current.Next;
            } while (current != head);

            Console.WriteLine("Ticket ID not found.");
        }

        public void DisplayTickets()
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            Ticket temp = head;
            Console.WriteLine(" Current Booked Tickets ");
            do
            {
                Console.WriteLine($"ID: {temp.TicketID} | Customer: {temp.CustomerName} | Movie: {temp.MovieName} | Seat: {temp.SeatNumber} | Time: {temp.BookingTime}");
                temp = temp.Next;
            } while (temp != head);
        }

        public void Search(string query)
        {
            if (head == null) return;

            bool found = false;
            Ticket temp = head;
            do
            {
                if (temp.CustomerName.Equals(query, StringComparison.OrdinalIgnoreCase) ||
                    temp.MovieName.Equals(query, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Found: Ticket {temp.TicketID} for {temp.CustomerName} - {temp.MovieName}");
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found) Console.WriteLine($"No records found for: {query}");
        }

        public int GetTotalTickets()
        {
            if (head == null) return 0;

            int count = 0;
            Ticket temp = head;
            do
            {
                count++;
                temp = temp.Next;
            } while (temp != head);

            return count;
        }

        public static void Main()
        {
            TicketReservationSystem system = new TicketReservationSystem();

            system.AddTicket(101, "John Doe", "Avatar 2", "A12", "14:30");
            system.AddTicket(102, "Jane Smith", "Inception", "B05", "18:00");
            system.AddTicket(103, "Sam Wilson", "Avatar 2", "A13", "14:30");

            system.DisplayTickets();

            Console.WriteLine($"Total Booked Tickets: {system.GetTotalTickets()}");

            Console.WriteLine("Searching for 'Avatar 2':");
            system.Search("Avatar 2");

            Console.WriteLine("Removing Ticket 102...");
            system.RemoveTicket(102);
            system.DisplayTickets();
        }
    }
}
