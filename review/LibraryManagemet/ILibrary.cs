using System;
public interface ILibrary
{
     public void AddBook(ref Book[] books,ref int index,string name,string author,int id);

      public void SortBookByName(ref Book[] books,int index);

      public Book SearchById(Book[] books, int index, int searchId);
}