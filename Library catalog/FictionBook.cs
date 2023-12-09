public class FictionBook : Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public string Genre { get; set; }
    public FictionBook(string title, string author, int pages, string genre)
    : base(title, author, pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
        Genre = genre;
    }
    public override void DisplayAdditionalInfo()
    {
        Console.WriteLine("Genre: " + Genre);
    }
}