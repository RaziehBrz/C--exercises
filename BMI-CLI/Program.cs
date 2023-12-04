internal class Program
{
    static void Main(string[] args)
    {
        validation(args);
        execute(args);
    }
    static void validation(string[] args)
    {
        if (args.Length == 0 || args[0] != "bmi") BadCommand();
        else if (args[1] == "--helps") showHelp();
        else if (args[1] == "--version") showCurrentVersion();
    }
    static void execute(string[] args)
    {
        double weight, height;
        var firstSwitch = args[1];
        var secondSwitch = args[3];

        switch (firstSwitch)
        {
            case "--height":
                if (secondSwitch == "--weight")
                {
                    height = Convert.ToDouble(args[2]);
                    weight = Convert.ToDouble(args[4]);
                    bmiCalculator(weight, height);
                }
                else BadCommand();
                break;
            case "--weight":
                if (secondSwitch == "--height")
                {
                    height = Convert.ToDouble(args[4]);
                    weight = Convert.ToDouble(args[2]);
                    bmiCalculator(weight, height);
                }
                else BadCommand();
                break;
            default:
                BadCommand();
                break;
        }

    }

    static void BadCommand()
    {
        Console.WriteLine("\nInvalid command :(");
        Console.WriteLine("Use --helps to show help\n");
    }
    static void showHelp()
    {
        Console.WriteLine("\n Use these switch to run program:");
        Console.WriteLine("--height\tYour height (centimeters)");
        Console.WriteLine("--weight\tYour weight (kilograms)");
        Console.WriteLine("--version\tShow current version");
        Console.WriteLine("--helps\t\tShow command list\n");
    }
    static void showCurrentVersion()
    {
        Console.WriteLine("\nCurrent version: 1.0\n");
    }
    static void bmiCalculator(double weight, double height)
    {

        var bmi = weight / Math.Round(Math.Pow(height, 2));
        Console.WriteLine("\nYour BMI Score is:\n" + bmi);

        var status = "Underweight";
        if (bmi < 18.5) status = "Underweight";
        else if (bmi >= 18.5 && bmi <= 24.9) status = "Healthy Weight";
        else if (bmi >= 25 && bmi <= 29.9) status = "Overweight";
        else if (bmi > 29.9) status = "Obese";

        Console.WriteLine($"Your status is : {status}\n");
    }
}