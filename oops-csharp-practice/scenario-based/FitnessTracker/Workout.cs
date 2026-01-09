using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.FitnessTracker
{
    //class for workout
    internal class Workout
    {
        //fields for workout
        public string WorkoutName { get; private set; }

        public string[] WorkoutExercises { get; private set; }

        public int[] WorkoutCalories { get; private set; }
        

        //contructor for workout
        public Workout(string workoutName, string[] workoutExercises, int[] workoutCalories) 
        {
            this.WorkoutName = workoutName;
            this.WorkoutExercises = workoutExercises;
            this.WorkoutCalories= workoutCalories;
        }

        
    }
}
