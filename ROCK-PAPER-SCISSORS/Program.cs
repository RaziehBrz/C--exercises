using System.Runtime.Intrinsics.Arm;

internal class Program
{
    static void Main(string[] args)
    {
        var playAgain = false;

        do
        {
            Console.Clear();

            Console.Write("Enter ROCK , PAPER or SCISSORS: ");
            var player = Console.ReadLine().ToUpper();
            var computer = computerRound();

            Console.WriteLine("Player: " + player);
            Console.WriteLine("Computer: " + computer);
            WinnerIdentifier(computer, player);

            Console.WriteLine("Would you like to play again? (Y/N)");
            var response = char.ToUpper(Convert.ToChar(Console.ReadLine()));
            playAgain = response == 'Y';

        } while (playAgain);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Thanks for playing ... ^_^");
        Console.ResetColor();

    }
    static string computerRound()
    {
        string result = null;
        var random = new Random();
        var computer = random.Next(1, 4);

        switch (computer)
        {
            case 1:
                result = "ROCK";
                break;
            case 2:
                result = "PAPER";
                break;
            case 3:
                result = "SCISSORS";
                break;
        }
        return result;
    }

    static void WinnerIdentifier(string computer, string player)
    {
        switch (computer)
        {
            case "ROCK":
                if (player == "ROCK") Console.WriteLine("It's a draw!");
                else if (player == "PAPER") Console.WriteLine("You win!");
                else if (player == "SCISSORS") Console.WriteLine("You lose!");
                break;
            case "PAPER":
                if (player == "PAPER") Console.WriteLine("It's a draw!");
                else if (player == "ROCK") Console.WriteLine("You lose!");
                else if (player == "SCISSORS") Console.WriteLine("You win!");
                break;
            case "SCISSORS":
                if (player == "SCISSORS") Console.WriteLine("It's a draw!");
                else if (player == "PAPER") Console.WriteLine("You lose!");
                else if (player == "ROCK") Console.WriteLine("You win!");
                break;
        }
    }
}