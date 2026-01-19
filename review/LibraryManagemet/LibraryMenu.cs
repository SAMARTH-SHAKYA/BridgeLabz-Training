using System;
// using System.Threading.Tasks.Dataflow;

public class LibraryMenu
{
    private ILibrary utility;

    public void Menu()
    {
        utility = new LibraryUtilityIMPL();

        Book[] databaseLibrary = new Book[10];
        int databaseIdx = 0;

        Console.WriteLine("Welcome to library manager");

        bool isTrue = true;

        while (isTrue)
        {
            Console.WriteLine("Press 0 : To exit");
            Console.WriteLine("Press 1 : To add a new Book");
            Console.WriteLine("Press 2 : To sort by book name");
            Console.WriteLine("Press 3 : To search a book by its id");


            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    isTrue = false;
                    Console.WriteLine("Exiting the library manager ----- thank you ");
                    break;
                
                case 1:
                    Console.WriteLine("Enter you book name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter you author name");
                    string author = Console.ReadLine();
                    Console.WriteLine("Enter your book id");
                    int id = Convert.ToInt32(Console.ReadLine());
                    utility.AddBook(ref databaseLibrary, ref databaseIdx, name, author, id);
                    break;

                case 2:
                    utility.SortBookByName(ref databaseLibrary,databaseIdx);
                    for(int i = 0; i < databaseIdx; i++)
                    {
                        Console.WriteLine(databaseLibrary[i].ToString());
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter the book id you want to search");
                    int idTosearch = Convert.ToInt32(Console.ReadLine());

                    if(utility.SearchById != null)
                    {
                        Book foundBook = utility.SearchById(databaseLibrary,databaseIdx,idTosearch);
                        Console.WriteLine($"Deatils of the book {foundBook.ToString()}");
                        break;
                    }
                    Console.WriteLine("Book not found");
                    break;
                
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
        }
    }
}