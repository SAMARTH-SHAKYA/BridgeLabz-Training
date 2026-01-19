using System;
public class LibraryUtilityIMPL : ILibrary
{
    public void AddBook(ref Book[] books, ref int index, string name, string author, int id)
    {
        if (index == 0)
        {
            books[index] = new Book(name, author, id);
            Console.WriteLine("Record successfully added to the database");
        }
        for (int i = 0; i < index; i++)
        {
            if (books[i].BookId == id)
            {
                Console.WriteLine("This book id already already exists ");
                return;
            }
            else if (books[i].BookName == name || books[i].AuthorName == author || books[i].BookId == id)
            {
                Console.WriteLine("Already Record Exists of this data");
                return;
            }
            else
            {
                continue;
            }
        }
        books[index] = new Book(name, author, id);
        Console.WriteLine("Record successfully added to the database");
        index++;
    }


    public void SortBookByName(ref Book[] books, int index)
    {
        int n = index;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (string.Compare(books[j].BookName, books[minIndex].BookName) < 0)
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                Book temp = books[i];
                books[i] = books[minIndex];
                books[minIndex] = temp;
            }
        }
    }



    public Book SearchById(Book[] books, int index, int searchId)
    {

        //doing sleection sort on ids
        
        for (int i = 0; i < index - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < index; j++)
            {
                if (books[j].BookId < books[minIndex].BookId)
                {
                    minIndex = j;
                }
            }
            Book temp = books[i];
            books[i] = books[minIndex];
            books[minIndex] = temp;
        }

        
        int low = 0;
        int high = index - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (books[mid].BookId == searchId)
            {
                return books[mid];   
            }
            else if (books[mid].BookId < searchId)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return null;
    }

}