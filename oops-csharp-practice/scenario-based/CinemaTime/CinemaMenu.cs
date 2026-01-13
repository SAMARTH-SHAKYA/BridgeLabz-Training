using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.CinemaTime
{
    internal class CinemaMenu
    {
        private ICinema cinema;

        public void Menu()
        {
            cinema = new CinemaUtility();

            bool isTrue = true;

            string[] titles = cinema.DatabaseFetchTitles();
            string[] times = cinema.DatabaseFetchTimes();

            while (isTrue)
            {
                Console.WriteLine("Press 1 : Add Movie");
                Console.WriteLine("Press 2 : Search Movie");
                Console.WriteLine("Press 3 : Display All Movies");
                Console.WriteLine("Press 4 : Generate Report");
                Console.WriteLine("Press 5 : Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Movie Title:");
                        string title = Console.ReadLine();

                        Console.WriteLine("Enter Time (HH:MM):");
                        string time = Console.ReadLine();

                        cinema.AddMovie(ref titles, ref times, title, time);
                        break;

                    case 2:
                        Console.WriteLine("Enter keyword:");
                        string keyword = Console.ReadLine();
                        cinema.SearchMovie(titles, times, keyword);
                        break;

                    case 3:
                        cinema.DisplayAllMovies(titles, times);
                        break;

                    case 4:
                        cinema.GenerateReport(titles, times);
                        break;

                    case 5:
                        isTrue = false;
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
