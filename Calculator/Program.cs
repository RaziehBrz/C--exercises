internal class Program
{
    static void Main(string[] args)
    {
        var calculator = new Calculator();
        bool runAgain = false;

        do
        {
            Console.Clear();
            Console.WriteLine("------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("------------------");

            try
            {
                getNumbers(calculator);
                calculator.PrintMenu();
                calculator.CalculateResult();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Would you like to continue? (Y = yes/N = no)");
            var response = Console.ReadLine();
            runAgain = response.ToUpper() == "Y";

        } while (runAgain);

        Console.WriteLine("Bye :)");
    }
    static void getNumbers(Calculator calculator)
    {
        Console.Write("Enter number 1: ");
        calculator.FirstNumber = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter number 2: ");
        calculator.SecondNumber = Convert.ToDouble(Console.ReadLine());
    }
}