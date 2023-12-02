internal class Prigram
{
    static void Main(string[] args)
    {
        var Exit = false;

        do
        {
            try
            {
                var inputNumber = printMenu();

                switch (inputNumber)
                {
                    case "1":
                        try
                        {
                            var result = numberToAlphabetConverter();
                            Console.WriteLine($"--> Result: {result}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "2":
                        try
                        {
                            var result = numberToDayOfWeekConverter();
                            Console.WriteLine($"--> Today is {result} :)");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Good Bye :)");
                        Exit = true;
                        Environment.Exit(0);
                        break;
                    case "5":
                        Console.Clear();
                        throw new Exception("You entered wrong item.\n Try again");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        } while (!Exit);
    }
    static string printMenu()
    {
        Console.Clear();
        Console.WriteLine("WELCOME");
        Console.WriteLine("Enter a number to execute :");
        Console.WriteLine("1) Convert number to alphabet");
        Console.WriteLine("2) Convert number to day of week");
        Console.WriteLine("3) Exit");
        Console.Write("--> ");
        return Console.ReadLine();
    }
    static string numberToAlphabetConverter()
    {
        Console.Clear();
        Console.WriteLine("Enter a number between 1 to 10 :");
        var number = Convert.ToInt32(Console.ReadLine());

        switch (number)
        {
            case 1:
                return "One";
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            case 5:
                return "Five";
            case 6:
                return "Six";
            case 7:
                return "Seven";
            case 8:
                return "Eight";
            case 9:
                return "Nine";
            case 10:
                return "Ten";
            default:
                throw new Exception("You entered out of range");
        }
    }
    static string numberToDayOfWeekConverter()
    {
        Console.Clear();
        Console.WriteLine("Enter a number between 1 to 7 for days of the week:");
        var inputNumber = Convert.ToInt32(Console.ReadLine());

        switch (inputNumber)
        {
            case 1:
                return "Saturday";
            case 2:
                return "Sunday";
            case 3:
                return "Monday";
            case 4:
                return "Tuesday";
            case 5:
                return "Wednesday";
            case 6:
                return "Thursday";
            case 7:
                return "Friday";
            default:
                throw new Exception("You entered out of range");
        }


    }
}