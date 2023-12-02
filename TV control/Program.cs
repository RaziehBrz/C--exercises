internal class Program
{
    static void Main(string[] args)
    {
        var isLove = false;
        int i = 0;

        do
        {
            i++;
            Console.Clear();
            Console.WriteLine($"**CHANNEL {i}**");
            Console.WriteLine("Do you love this channel? (yes/no)");

            var response = Console.ReadLine().ToLower();
            isLove = response == "yes";
        } while (!isLove);

        Console.WriteLine("Enjoy watching CHANNEL " + i);
        Console.WriteLine("^_^");
    }
}