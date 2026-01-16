public class GenreEntry
{
    public string Genre;
    public BookNode Head;

    public GenreEntry(string genre)
    {
        Genre = genre;
        Head = null;
    }
}
