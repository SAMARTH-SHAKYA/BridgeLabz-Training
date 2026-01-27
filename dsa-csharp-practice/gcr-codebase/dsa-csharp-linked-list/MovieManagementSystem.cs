using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_linked_list
{
    public class Movie
    {
        public string Title;
        public string Director;
        public int Year;
        public double Rating;
        public Movie Next;
        public Movie Prev;

        public Movie(string title, string director, int year, double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Rating = rating;
            Next = null;
            Prev = null;
        }
    }



    public class MovieManagementSystem
    {
        private Movie head;
        private Movie tail;

        public void Add(string title, string director, int year, double rating, int position)
        {
            Movie newNode = new Movie(title, director, year, rating);

            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            if (position <= 0)
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
                return;
            }

            Movie current = head;
            int index = 0;
            while (current.Next != null && index < position - 1)
            {
                current = current.Next;
                index++;
            }

            if (current.Next == null && index < position)
            {
                current.Next = newNode;
                newNode.Prev = current;
                tail = newNode;
            }
            else
            {
                newNode.Next = current.Next;
                newNode.Prev = current;
                if (current.Next != null)
                    current.Next.Prev = newNode;
                current.Next = newNode;
            }
        }

        public void Remove(string title)
        {
            Movie current = head;
            while (current != null)
            {
                if (current.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    if (current.Prev != null)
                        current.Prev.Next = current.Next;
                    else
                        head = current.Next;

                    if (current.Next != null)
                        current.Next.Prev = current.Prev;
                    else
                        tail = current.Prev;

                    return;
                }
                current = current.Next;
            }
        }

        public void Search(string director = null, double? rating = null)
        {
            Movie current = head;
            bool found = false;
            while (current != null)
            {
                if ((director != null && current.Director.Equals(director, StringComparison.OrdinalIgnoreCase)) ||
                    (rating != null && Math.Abs(current.Rating - rating.Value) < 0.1))
                {
                    Console.WriteLine($"Found: {current.Title} ({current.Year}) - Dir: {current.Director}, Rating: {current.Rating}");
                    found = true;
                }
                current = current.Next;
            }
            if (!found) Console.WriteLine("No matching movies found.");
        }

        public void UpdateRating(string title, double newRating)
        {
            Movie current = head;
            while (current != null)
            {
                if (current.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    current.Rating = newRating;
                    return;
                }
                current = current.Next;
            }
        }

        public void DisplayForward()
        {
            Movie current = head;
            while (current != null)
            {
                Console.WriteLine($"{current.Title} | {current.Director} | {current.Year} | {current.Rating}");
                current = current.Next;
            }
        }

        public void DisplayReverse()
        {
            Movie current = tail;
            while (current != null)
            {
                Console.WriteLine($"{current.Title} | {current.Director} | {current.Year} | {current.Rating}");
                current = current.Prev;
            }
        }

        public static void Main()
        {
            MovieManagementSystem mms = new MovieManagementSystem();
            mms.Add("Inception", "Nolan", 2010, 8.8, 0);
            mms.Add("The Matrix", "Wachowskis", 1999, 8.7, 1);
            mms.Add("Interstellar", "Nolan", 2014, 8.6, 2);

            
            mms.DisplayForward();

            
            mms.Search(director: "Nolan");

            
            mms.UpdateRating("Inception", 9.0);
            mms.Remove("The Matrix");


            mms.DisplayReverse();
        }
    }
}
