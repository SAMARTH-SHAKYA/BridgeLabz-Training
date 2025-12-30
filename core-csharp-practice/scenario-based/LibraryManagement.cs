/*
 * This program simulates a simple Library Management System where predefined book records (title, author, availability) are stored in a 2D string array. 
 * The user can search for books by name, view matching results with serial numbers, select a book to see full details, 
 * check its availability, and if available, issue the book which updates its status to “Not Available.”
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BridgeLabzTraining.Senario_based
{
    internal class LibraryManagement
    {
        //method to call admin functionality
        public void Admin()
        {

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("------------------ Admin Menu --------------------");
                Console.WriteLine("Press 1 : Show all records");
                Console.WriteLine("Press 2 : Add a book");
                Console.WriteLine("Press 3 : Delete a book");
                Console.WriteLine("Press 4 : Exit");

                int choice = Convert.ToInt32(Console.ReadLine());


                //taking operation of admin they wan to perform
                switch (choice)
                {
                    case 1:
                        ShowAllRecords(books);
                        break;

                    case 2:
                        books = AddBookAdmin(books);
                        ShowAllRecords(books);
                        break;

                    case 3:
                        books = DeleteBook(books);
                        ShowAllRecords(books);
                        break;

                    case 4:
                        isRunning = false;
                        Console.WriteLine("Exiting admin menu...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }



        }


        //method to show all records
        public void ShowAllRecords(string[,] books)
        {
            for (int i = 0; i < books.GetLength(0); i++)
            { 
                for(int j = 0; j < books.GetLength(1); j++)
                {
                    Console.Write(books[i, j]+"  ");
                }
                Console.WriteLine();
            }
        }

        //method to add book to the record
        public string[,] AddBookAdmin(string[,] books)
        {
            int oldSize = books.GetLength(0);
            int cols = books.GetLength(1);
            string[,] temp = new string[oldSize + 1, cols];
            for (int i = 0; i < oldSize; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    temp[i, j] = books[i, j];
                }
            }

            Console.Write("Enter Book Name: ");
            temp[oldSize, 0] = Console.ReadLine();
            Console.Write("Enter Author Name: ");
            temp[oldSize, 1] = Console.ReadLine();
            Console.Write("Enter Status (Available / Not Available): ");
            temp[oldSize, 2] = Console.ReadLine();

            Console.WriteLine("Book added successfully");

            return temp; 
        }

        //method to delete the record 
        public string[,] DeleteBook(string[,] books)
        {
            Console.Write("Enter book name to delete: ");
            string name = Console.ReadLine().ToLower();

            int rows = books.GetLength(0);
            int cols = books.GetLength(1);

            
            string[,] temp = new string[rows - 1, cols];

            int newRow = 0;
            bool found = false;

            for (int i = 0; i < rows; i++)
            {
                if (books[i, 0].ToLower() != name)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        temp[newRow, j] = books[i, j];
                    }
                    newRow++;
                }
                else
                {
                    found = true; 
                }
            }

            if (!found)
            {
                Console.WriteLine("Book not found!");
                return books; 
            }

            Console.WriteLine("Book deleted successfully");
            return temp; 
        }

        //defining a array so that it is accesible and can modify at any stage
        internal string[,] books ={
                                    { "Atomic Habits", "James Clear", "Available" },
                                    { "Clean Code", "Robert Martin", "Not Available" },
                                    { "Deep Work", "Cal Newport", "Available" },
                                    { "The Alchemist", "Paulo Coelho", "Available" },
                                    { "Ikigai", "Hector Garcia", "Not Available" },
                                    { "Rich Dad Poor Dad", "Robert Kiyosaki", "Available" },
                                    { "Think and Grow Rich", "Napoleon Hill", "Not Available" },
                                    { "The Psychology of Money", "Morgan Housel", "Available" },
                                    { "Zero to One", "Peter Thiel", "Available" },
                                    { "The Power of Habit", "Charles Duhigg", "Not Available" }
                            };

        //method which will be called by main 
        public void ManageLibrary()
        {
            Console.WriteLine("----------- Login page --------------");
            Console.WriteLine("Type user for userLogin                         Type admin for adminLogin");
            string person = Console.ReadLine().ToLower();

            if (person == "admin")
            {
                Console.WriteLine("Enter your password");
                string pass = Console.ReadLine();
                if (pass == "1234") 
                {
                    Admin();
                }
                else
                {
                    Console.WriteLine("Invalid password");
                }
            }
            else
            {
                Console.WriteLine("------------------ Welcome to the Samarth book store ----------------------");
                User();
            }
            

        }

        public void User()
        {
            Console.WriteLine("Enter book you want to search");
            string bookToSearch = Console.ReadLine();
            SearchBook(bookToSearch, books);
        }
        
        //method to search books provided by the user
        public void SearchBook(string bookToSearch, string[,] books)
        {
            Console.WriteLine("The books realted to your search are with their serial number");
            for (int i = 0; i < books.GetLength(0); i++)
            {
                if(books[i, 0].Contains(bookToSearch)){
                    Console.WriteLine($"{books[i, 0]} : {i}");
                }
            }
            Console.WriteLine("Enter serial number for full status");
            int serialNum = Convert.ToInt32(Console.ReadLine());
            DisplayBook(serialNum,books);

        }

        //method to display the full status and issuing the book to the user
        public void DisplayBook(int serialNum, string[,] books)
        {
            Console.WriteLine($"The description of the book is: {books[serialNum, 0]},written by {books[serialNum, 1]}");

            if(books[serialNum, 2] == "Available"){
                Console.WriteLine($"Press 1 for checking out with {books[serialNum, 0]}");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 1) 
                {
                    UpdateBookByUser(serialNum, books);
                    Console.WriteLine("Thank you book have been issued to you");
                }
                else
                {
                    Console.WriteLine("Thank you ");
                }
            }
            else
            {
                Console.WriteLine("Book not Available");
            }
        }

        //method to update the book record in the database
        public void UpdateBookByUser(int serialNum, string[,] books)
        {
            books[serialNum, 2] = "Not Available";
        }

    }
}
