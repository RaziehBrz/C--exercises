public static class Library
{
    static public void DisplayBooks(Book[] Books)
    {
        foreach (var book in Books)
        {
            Console.WriteLine("----------");
            book.DisplayInfo();
            book.DisplayAdditionalInfo();
            Console.WriteLine("----------");
        }
    }
}