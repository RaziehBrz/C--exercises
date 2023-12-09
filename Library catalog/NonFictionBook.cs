public class NonFictionBook : Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public string Topic { get; set; }
    public NonFictionBook(string title, string author, int pages, string topic)
    : base(title, author, pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
        Topic = topic;
    }
    public override void DisplayAdditionalInfo()
    {
        Console.WriteLine("Topic: " + Topic);
    }
}