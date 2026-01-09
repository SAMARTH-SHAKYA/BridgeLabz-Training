using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.FitnessTracker
{
    
    //menu for the application
    internal class GymMenu
    {
        private ITrackable trackable;

        public void GymUserMenu()
        {
            trackable = new TrackableUtility();
            Workout Cardio = trackable.CreateCardio();
            Workout Strenth = trackable.CreateCardio();
            Workout Balance = trackable.CreateBalance();

            UserProfile user = TakeUserInput();

            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("Press 1 : To do cardio");
                Console.WriteLine("Press 2 : To do strenght training");
                Console.WriteLine("Press 3 : To do balance training");
                Console.WriteLine("Press 4 : To view remaining calories");
                Console.WriteLine("Press 5 : Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) 
                {
                    case 1:
                        Console.WriteLine("Press 1 : Running");
                        Console.WriteLine("Press 2 : Skipping");
                        Console.WriteLine("Press 3 : Cycling");
                        Console.WriteLine("Press 4 : Jumping Jacks");
                        Console.WriteLine("Press 5 : StairClimbing");
                        int choiceExe = Convert.ToInt32(Console.ReadLine());
                        if (choiceExe > 6)
                        {
                            Console.WriteLine("Entered wrong choice");
                            continue;
                        }
                        trackable.UpdateUserCalories(Cardio,choiceExe - 1,user);
                        break;

                    case 2:
                        Console.WriteLine("Press 1 : Push-ups");
                        Console.WriteLine("Press 2 : Squats");
                        Console.WriteLine("Press 3 : DeadLifts");
                        Console.WriteLine("Press 4 : Plank");
                        Console.WriteLine("Press 5 : Lunges");
                        int choiceExe1 = Convert.ToInt32(Console.ReadLine());
                        if (choiceExe1 > 6)
                        {
                            Console.WriteLine("Entered wrong choice");
                            continue;
                        }
                        trackable.UpdateUserCalories(Strenth, choiceExe1 - 1, user);
                        break;

                    case 3:
                        Console.WriteLine("Press 1 : Single leg stand");
                        Console.WriteLine("Press 2 : Tree pose");
                        Console.WriteLine("Press 3 : Heel to toe walk");
                        Console.WriteLine("Press 4 : Bosu Ball Squats");
                        Console.WriteLine("Press 5 : SideLegRaises");
                        int choiceExe2 = Convert.ToInt32(Console.ReadLine());
                        if (choiceExe2 > 6)
                        {
                            Console.WriteLine("Entered wrong choice");
                            continue;
                        }
                        trackable.UpdateUserCalories(Cardio, choiceExe2 - 1, user);
                        break;

                    case 4:
                        if(user.CaloriesGoal < 0)
                        {
                            Console.WriteLine("You have completed your goal you can exit ");
                            break;
                        }
                        Console.WriteLine($"Your remaning calories are {user.CaloriesGoal}");
                        break;

                    case 5:
                        isTrue = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
            }

            

        }

        public UserProfile TakeUserInput()
        {
            Console.WriteLine("Enter your user id");
            string userId = Console.ReadLine();
            Console.WriteLine("Enter your name");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your gender");
            string userGender = Console.ReadLine();
            Console.WriteLine("Enter your calories goal :");
            int userCaloriesGoal = Convert.ToInt32(Console.ReadLine());

            UserProfile user = new UserProfile(userId, userName, userAge, userGender, userCaloriesGoal);
            return user;
        }
        


    }
}
