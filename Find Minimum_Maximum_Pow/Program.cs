using System.Runtime.Intrinsics.Arm;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        var numbersArray = new string[] { };

        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine("\n\t\t\tWelcome to the program\n");
        Console.ResetColor();
        Console.WriteLine("1) Find minimum of numbers");
        Console.WriteLine("2) Find maximum of numbers");
        Console.WriteLine("3) Power calculation");

        Console.WriteLine("Enter a number to execute:");
        Console.WriteLine("--> ");
        try
        {
            var inputOption = Console.ReadLine();

            switch (inputOption)
            {
                case "1":
                    Console.WriteLine("Enter a list of numbers :");
                    var numbers = Console.ReadLine();
                    numbersArray = numbers.Split(" ");
                    var min = FindMin(numbersArray);
                    Console.WriteLine("Result: " + min);
                    break;
                case "2":
                    Console.WriteLine("Enter a list of numbers :");
                    numbers = Console.ReadLine();
                    numbersArray = numbers.Split(" ");
                    var max = FindMax(numbersArray);
                    Console.WriteLine("Result: " + max);
                    break;
                case "3":
                    Console.Write("Enter x and y to continue : Y^X\nX :");
                    var x = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Y :");
                    var y = Convert.ToInt32(Console.ReadLine());
                    var result = CalculatePow(x, y);
                    Console.WriteLine("Result: " + result);
                    break;
                default:
                    throw new Exception("You entered wrong item!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static double FindMax(string[] numbers)
    {
        var max = Convert.ToDouble(numbers[0]);
        double n = 0;

        foreach (var number in numbers)
        {
            n = Convert.ToDouble(number);
            if (max < n) max = n;
        }
        return max;
    }

    static double FindMin(string[] numbers)
    {
        var min = Convert.ToDouble(numbers[0]);
        double n = 0;

        foreach (var number in numbers)
        {
            n = Convert.ToDouble(number);
            if (min > n) min = n;
        }
        return min;
    }
    static int CalculatePow(int x, int y)
    {
        if (y == 0) return 1;

        //This variable stores the initial value of x
        var temp = x;

        for (int i = 0; i < y - 1; i++)
        {
            x *= temp;
        }
        return x;
    }
}