internal class Program
{
    static void Main(string[] args)
    {
        //Create an array of books with different types
        var libraryCatalog = new Book[]
        {
            new FictionBook("The Great Gatsby" ,"F. Scott Fitzgerald" , 180 ,"Classic") ,
            new FictionBook("Dune" , "Frank Herbert" , 412 , "Science Fiction") ,
            new NonFictionBook("Spiens" , "Yuval Noah Harari" , 512 , "History") ,
            new NonFictionBook("Atomics Habits" , "James Clear" , 320 , "Self-Help" )
        };

        //Display information about all the books in the library
        Library.DisplayBooks(libraryCatalog);
    }
}