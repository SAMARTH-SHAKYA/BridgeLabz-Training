public interface IBookShelf
{
    void AddBook(string genre, string title, string author);
    void RemoveBook(string genre, string title);
    void DisplayByGenre(string genre);
    void DisplayAll();
}
