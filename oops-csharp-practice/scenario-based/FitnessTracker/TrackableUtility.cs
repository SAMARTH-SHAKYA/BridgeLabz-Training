using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.FitnessTracker
{
    //utility class to implement methods accros application
    internal class TrackableUtility : ITrackable
    {
        //method to create cardio
        public Workout CreateCardio()
        {
            string[] exercises = { "Running", "Skipping", "Cycling", "Junping Jacks", "Stair Climbing" };
            int[] workoutCalories = { 300, 350, 250, 200, 300 };
            Workout workout = new Workout("Cardiovascular", exercises, workoutCalories);
            return workout;
        }

        // methos to create strength
        public Workout CreateStrenght()
        {
            string[] exercises = { "Push-ups", "Squats", "Deadlifts", "Plank", "Lunges" };
            int[] workoutCalories = { 200, 250, 300, 180, 220 };
            Workout workout = new Workout("Strength Training", exercises, workoutCalories);
            return workout;

        }

        //method to create balance
        public Workout CreateBalance()
        {
            string[] exercises = { "Single-leg stand", "Tree Pose", "Heel-to-toe walk", "Bosu Ball Squats", "Side Leg Raises" };
            int[] workoutCalories = { 100, 120, 90, 150, 110 };
            Workout workout = new Workout("Balance Training",exercises, workoutCalories);
            return workout;

        }

        public void UpdateUserCalories(Workout workout, int index,UserProfile user)
        {


            Console.WriteLine($"Completed exercise {workout.WorkoutExercises[index]}");
            user.ChangeCalories(workout.WorkoutCalories[index]);

            
        }
    }
}
