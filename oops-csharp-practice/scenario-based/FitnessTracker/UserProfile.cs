using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.FitnessTracker
{
    //user profile
    internal  class UserProfile
    {
        //field for user and some fileds are encapsulate
        public string UserId {  get; private set; }
        public string UserName { get; private set; }

        public int UserAge { get; private set; }

        public int UserCount { get; private set; }

        public string Gender { get; private set; }

        public int CaloriesGoal { get; private set; }

        //constructor for user
        public UserProfile(string id,string name,int age,string gender,int caloriesGoal) 
        {
            this.UserId = id;
            this.UserName = name;
            this.Gender = gender;
            this.CaloriesGoal = caloriesGoal;
            this.UserCount++;
        }

        //overriding the tostring method
        public override string ToString()
        {
            return $"ID : {UserId}, Name : {UserName}, Age : {UserAge}, Gender : {Gender}";
        }


        //method to change the calories of a user
        public void ChangeCalories(int count) 
        { 
            this.CaloriesGoal -= count;
            Console.WriteLine($"Remaining calories to burn {CaloriesGoal}");
        }
    }
}
