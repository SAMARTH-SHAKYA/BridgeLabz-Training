using System;

public class BookShelfImpl : IBookShelf
{
    private GenreEntry[] genres = new GenreEntry[10];
    private int genreCount = 0;

    public void AddBook(string genre, string title, string author)
    {
        int index = FindGenreIndex(genre);

        if (index == -1)
        {
            genres[genreCount] = new GenreEntry(genre);
            index = genreCount;
            genreCount++;
        }

        // Duplicate check
        if (IsDuplicate(index, title))
        {
            Console.WriteLine("Book already exists!");
            return;
        }

        BookNode newNode = new BookNode(new Book(title, author));

        if (genres[index].Head == null)
        {
            genres[index].Head = newNode;
        }
        else
        {
            BookNode temp = genres[index].Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        Console.WriteLine("Book added successfully!");
    }

    public void RemoveBook(string genre, string title)
    {
        int index = FindGenreIndex(genre);
        if (index == -1)
        {
            Console.WriteLine("Genre not found!");
            return;
        }

        BookNode temp = genres[index].Head;
        BookNode prev = null;

        while (temp != null)
        {
            if (temp.Data.Title == title)
            {
                if (prev == null)
                    genres[index].Head = temp.Next;
                else
                    prev.Next = temp.Next;

                Console.WriteLine("Book removed!");
                return;
            }
            prev = temp;
            temp = temp.Next;
        }

        Console.WriteLine("Book not found!");
    }

    public void DisplayByGenre(string genre)
    {
        int index = FindGenreIndex(genre);
        if (index == -1)
        {
            Console.WriteLine("Genre not found!");
            return;
        }

        BookNode temp = genres[index].Head;
        if (temp == null)
        {
            Console.WriteLine("No books in this genre.");
            return;
        }

        while (temp != null)
        {
            Console.WriteLine($"{temp.Data.Title} by {temp.Data.Author}");
            temp = temp.Next;
        }
    }

    public void DisplayAll()
    {
        for (int i = 0; i < genreCount; i++)
        {
            Console.WriteLine("\nGenre: " + genres[i].Genre);
            BookNode temp = genres[i].Head;
            while (temp != null)
            {
                Console.WriteLine($"  {temp.Data.Title} by {temp.Data.Author}");
                temp = temp.Next;
            }
        }
    }

    private int FindGenreIndex(string genre)
    {
        for (int i = 0; i < genreCount; i++)
        {
            if (genres[i].Genre == genre)
                return i;
        }
        return -1;
    }

    private bool IsDuplicate(int index, string title)
    {
        BookNode temp = genres[index].Head;
        while (temp != null)
        {
            if (temp.Data.Title == title)
                return true;
            temp = temp.Next;
        }
        return false;
    }
}
