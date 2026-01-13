using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.CinemaTime
{
    internal interface ICinema
    {
        void AddMovie(ref string[] titles, ref string[] times, string title, string time);
        void SearchMovie(string[] titles, string[] times, string keyword);
        void DisplayAllMovies(string[] titles, string[] times);
        string[] DatabaseFetchTitles();
        string[] DatabaseFetchTimes();
        void GenerateReport(string[] titles, string[] times);
    }
}
