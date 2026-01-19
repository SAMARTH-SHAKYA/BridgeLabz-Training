using System;

public class Book
{

    // duplicate book check 
    // binary search 
    // sorting
    public string BookName { get; private set; }
    public string AuthorName { get; private set; }

    public int BookId {get; private set;}
    public Book(string name, string author,int id)
    {
        this.BookName = name;
        this.AuthorName = author;
        this.BookId = id;
    }

    public override string ToString()
    {
        return $"Book Id : {BookId} , Book name : {BookName} , Author name: {AuthorName}";
    }
}