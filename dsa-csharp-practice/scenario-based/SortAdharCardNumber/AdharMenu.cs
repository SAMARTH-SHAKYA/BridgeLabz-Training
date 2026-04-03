using System;
public class AdharMenu
{
    //creating a private reference for the utility
    private ISortAdhar utility;

    public void Menu()
    {
        //instantiating the utility
        utility = new SortAdharIMPL();

        Console.WriteLine("------------ Welcome to adhar card site ----------------");

        bool isTrue = true;
        

        //creating a databse to store values
        AdharCard[] adharDatabase = new AdharCard[10];
        int dbIndex = 0;

        //creating menu using switch case
        while (isTrue)
        {
            Console.WriteLine("Press 0 : To exit");
            Console.WriteLine("Press 1 : To Add details of a person");
            Console.WriteLine("Press 2 : To Sort the recors and Print");



            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                //to exit
                case 0:
                    isTrue = false;
                    Console.WriteLine("Exiting the menu");
                    break;

                //to add details from the user
                case 1:
                    Console.WriteLine("Enter your name;");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Enter your number");
                    string number = Console.ReadLine();
                    if (number.Length != 12)
                    {
                        Console.WriteLine("Adhar card number length not equal to 12");
                        break;
                    }
                    else
                    {
                        long userNumber = Convert.ToInt64(number);
                        utility.AddDetails(ref adharDatabase, ref dbIndex, userName, userNumber);
                    }
                    break;


                //use radix sort to sort the details by number
                case 2:
                    utility.RadixSortAdhar(ref adharDatabase, ref dbIndex);
                    utility.PrintDatabase(adharDatabase, dbIndex);
                    break;


                //for invalid input
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}