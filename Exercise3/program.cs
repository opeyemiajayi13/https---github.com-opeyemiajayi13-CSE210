Random randomGenerator = new Random();

string playAgain = "yes";

while (playAgain.ToLower() == "yes")
{
    int magicNumber = randomGenerator.Next(1, 101);
    int guess = -1;
    int guessCount = 0;

    Console.WriteLine("Welcome to Guess My Number!");

    while (guess != magicNumber)
    {
        Console.Write("What is your guess? ");
        string answer = Console.ReadLine() ?? "0";

        guess = int.Parse(answer);
        guessCount++;

        if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }

    Console.WriteLine($"You guessed {guessCount} times.");

    Console.Write("Do you want to play again? ");
    playAgain = Console.ReadLine() ?? "no";
}

Console.WriteLine("Thanks for playing!");