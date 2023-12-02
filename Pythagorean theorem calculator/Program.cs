internal class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Enter side A:");
        var sideA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter side B:");
        var sideB = Convert.ToDouble(Console.ReadLine());

        var result = calculator(sideA, sideB);
        Console.WriteLine($"The result is: {result}");

    }
    static double calculator(double a, double b)
    {
        return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
    }
}