namespace GuessingGameSRP;

public class StandardMessaging
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("Please guess a number from 1 to 100");
    }

    public static void InvalidGuess(int guessCount)
    {
        Console.WriteLine("You attempted an invalid guess");
        Console.WriteLine($"Current guess count: {guessCount}");
        GuessAgain();
    }

    public static void IncorrectGuess(int guessInt, int guessCount, string fieldValue)
    {
        Console.WriteLine($"Wrong! {guessInt} is too {fieldValue}.");
        Console.WriteLine($"Current guess count: {guessCount}");
        GuessAgain();
    }

    public static void SuccessfulGuess(int rndNum, int guessCount)
    {
        Console.WriteLine($"Congrats you guessed it! The number is {rndNum} and it took you {guessCount} guesses!");
    }

    public static void GuessAgain()
    {
        Console.WriteLine("Please guess again");
    }
}

