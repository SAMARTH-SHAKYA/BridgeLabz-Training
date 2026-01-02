using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
//Phone contact search name first number 
namespace BridgeLabzTraining.Review
{
    internal class PhoneContactSearch
    {
        string[,] phoneData =   {
                                    {"Samarth","Shakya","8272836517","Agra" },
                                    {"Pritam","Singh","8272837897","Lucknow" },
                                    {"Arun","Kumar","9783836517","Mathura" },
                                    {"Sambhav","Tiwari","9856237412","Mumbai" },
                                    {"Arpit","Tiwari","7981521582","Banglore" },
                                    {"Priyansh","Srivastava","7845123698","Lucknow" },
                                    {"","","","" },
                                    {"","","","" },
                                    {"","","","" },
                                    {"","","","" },
                            };

        int pointer = 5;

        public void GetDetailsByName()
        {
            Console.WriteLine("Enter your name");
            string toCheck = (Console.ReadLine()).ToLower();

            for (int i = 0; i < phoneData.GetLength(0); i++)
            {
                string name = phoneData[i,0].ToLower();
                if (name.Contains(toCheck))
                {
                    Console.Write($"FirstName : {phoneData[i,0]}, LastName : {phoneData[i, 1]}, PhoneNumber : {phoneData[i, 2]} , City : {phoneData[i,3]}");
                    Console.WriteLine();
                }
                
            }
        }


        public void GetDetailsByCity()
        {
            Console.WriteLine("Enter your city");
            string toCheck = (Console.ReadLine()).ToLower();

            for (int i = 0; i < phoneData.GetLength(0); i++)
            {
                string city = phoneData[i, 3].ToLower();
                if (city.Contains(toCheck))
                {
                    Console.Write($"FirstName : {phoneData[i, 0]}, LastName : {phoneData[i, 1]}, PhoneNumber : {phoneData[i, 2]} , City : {phoneData[i, 3]}");
                    Console.WriteLine();
                }

            }
        }

        public void GetDetailsByPhoneNumber()
        {
            Console.WriteLine("Enter your number");
            string toCheck = (Console.ReadLine()).ToLower();

            for (int i = 0; i < phoneData.GetLength(0); i++)
            {
                string number = phoneData[i, 2].ToLower();
                if (number.Contains(toCheck))
                {
                    Console.Write($"FirstName : {phoneData[i, 0]}, LastName : {phoneData[i, 1]}, PhoneNumber : {phoneData[i, 2]} , City : {phoneData[i, 3]}");
                    Console.WriteLine();
                }

            }
        }
        

        public void AddDetails()
        {
            if(pointer >= phoneData.GetLength(0) - 1)
            {
                Console.WriteLine("Space Not available");
            }
            Console.WriteLine("Enter Your first Name");
            phoneData[pointer+1, 0] = Console.ReadLine();
            Console.WriteLine("Enter Your last Name");
            phoneData[pointer + 1, 1] = Console.ReadLine();
            Console.WriteLine("Enter Your phone number");
            phoneData[pointer + 1, 2] = Console.ReadLine();
            Console.WriteLine("Enter Your city");
            phoneData[pointer + 1, 3] = Console.ReadLine();

            pointer++;


            
        }

        public void DisplayAll()
        {
            for (int i = 0; i <= pointer; i++)
            {
                Console.Write($"FirstName : {phoneData[i, 0]}, LastName : {phoneData[i, 1]}, PhoneNumber : {phoneData[i, 2]} , City : {phoneData[i, 3]}");
                Console.WriteLine();
            }
        }

        public static void Main()
        {
            PhoneContactSearch obj = new PhoneContactSearch();
            //obj.GetDetailsByName();
            //obj.GetDetailsByCity();
            //obj.GetDetailsByPhoneNumber();

            obj.Menu();
        }



        public void Menu()
        {
            Console.WriteLine("------------------------ Welcome to the number directory ----------------------------");
            bool isTrue = false;

            while (isTrue == false)
            {
                Console.WriteLine("Press 1 : For searching by name");
                Console.WriteLine("Press 2 : For searching by city");
                Console.WriteLine("Press 3 : For searching by phone number");
                Console.WriteLine("Press 4 : For adding details");
                Console.WriteLine("Press 5 : For showing all Details");
                Console.WriteLine("Press 6 : For exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        GetDetailsByName();
                        break;
                    case 2:
                        GetDetailsByCity();
                        break;
                    case 3:
                        GetDetailsByPhoneNumber();
                        break;
                    case 4:
                        AddDetails();
                        break;
                    case 5:
                        DisplayAll();
                        break;
                    case 6:
                        isTrue = true;
                        Console.WriteLine("------ Exit ------");
                        break;
                    default:
                        Console.WriteLine("Invalid input/ Some error occured");
                        break;
                }
            }
        }
    }


}
