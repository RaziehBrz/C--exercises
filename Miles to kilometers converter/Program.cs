internal class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("\nEnter the distance in miles :");
        var miles = Convert.ToDouble(Console.ReadLine());

        var result = milesToKilometersConverter(miles);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n\n --> {miles} miles is equal to {result} kilometers. ");
        Console.ResetColor();
    }
    static double milesToKilometersConverter(double miles)
    {
        //1 mile = 1.60934 kilometers
        const double constValue = 1.60934;
        return miles * constValue;
    }
}