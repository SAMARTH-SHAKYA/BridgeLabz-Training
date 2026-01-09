using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.FitnessTracker
{
    //interface for the application
    internal interface ITrackable
    {
        public Workout CreateCardio();

        public Workout CreateStrenght();

        public Workout CreateBalance();

        public void UpdateUserCalories(Workout workout, int index, UserProfile user);



        
    }
}
