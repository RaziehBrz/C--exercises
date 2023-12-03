internal class Program
{
    static void Main(string[] args)
    {
        var playAgain = false;
        int min = 1, max = 100;
        do
        {
            Console.Clear();
            int round = 0;
            var youWin = false;
            var random = new Random();
            var randomNumber = random.Next(min, max + 1);

            while (!youWin)
            {
                round++;
                Console.WriteLine("Guess a number between 1 - 100 :");
                var guess = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Guess: {guess}");
                if (guess > randomNumber) Console.WriteLine($"{guess} is too high!");
                else if (guess < randomNumber) Console.WriteLine($"{guess} is too low!");
                else
                {
                    Console.Clear();
                    Console.WriteLine("Number: " + guess);
                    Console.WriteLine("YOU WIN!");
                    Console.WriteLine("Round:" + round);
                    Console.WriteLine("Would you like to play again? (Y/N):");

                    var response = Convert.ToChar(Console.ReadLine());
                    playAgain = char.ToUpper(response) == 'Y';
                    youWin = true;
                }
            }
        } while (playAgain);

        Console.Clear();
        Console.WriteLine("Thanks for playing ... ^_^");
    }
}