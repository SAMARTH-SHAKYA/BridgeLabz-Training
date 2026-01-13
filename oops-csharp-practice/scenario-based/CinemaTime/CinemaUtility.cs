using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.CinemaTime
{
    internal class CinemaUtility : ICinema
    {
        public string[] DatabaseFetchTitles()
        {
            return new string[]
            {
                "Interstellar",
                "Inception",
                "Avengers",
                "Titanic",
                "Joker"
            };
        }

        public string[] DatabaseFetchTimes()
        {
            return new string[]
            {
                "18:30",
                "21:00",
                "15:45",
                "20:15",
                "17:00"
            };
        }

        public void AddMovie(ref string[] titles, ref string[] times, string title, string time)
        {
            try
            {
                ValidateTime(time);

                int newSize = titles.Length + 1;

                string[] newTitles = new string[newSize];
                string[] newTimes = new string[newSize];

                for (int i = 0; i < titles.Length; i++)
                {
                    newTitles[i] = titles[i];
                    newTimes[i] = times[i];
                }

                newTitles[newSize - 1] = title;
                newTimes[newSize - 1] = time;

                titles = newTitles;
                times = newTimes;

                Console.WriteLine("Movie added successfully!");
            }
            catch (InvalidTimeFormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ValidateTime(string time)
        {
            string[] parts = time.Split(':');

            if (parts.Length != 2)
                throw new InvalidTimeFormatException("Invalid time format! Use HH:MM");

            int hour = Convert.ToInt32(parts[0]);
            int minute = Convert.ToInt32(parts[1]);

            if (hour < 0 || hour > 23 || minute < 0 || minute > 59)
                throw new InvalidTimeFormatException("Invalid time value! Example: 18:30");
        }

        public void SearchMovie(string[] titles, string[] times, string keyword)
        {
            bool found = false;

            for (int i = 0; i < titles.Length; i++)
            {
                if (titles[i].ToLower().Contains(keyword.ToLower()))
                {
                    Console.WriteLine(titles[i] + " at " + times[i]);
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No movie found!");
        }

        public void DisplayAllMovies(string[] titles, string[] times)
        {
            for (int i = 0; i < titles.Length; i++)
            {
                Console.WriteLine(titles[i] + " - " + times[i]);
            }
        }

        public void GenerateReport(string[] titles, string[] times)
        {
            Console.WriteLine("=== Printable Report ===");

            string[] titleArray = titles;
            string[] timeArray = times;

            for (int i = 0; i < titleArray.Length; i++)
            {
                Console.WriteLine(titleArray[i] + " at " + timeArray[i]);
            }
        }
    }
}
