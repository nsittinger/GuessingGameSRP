namespace GuessingGameSRP;

public class GuessProcessor
{
    public static bool Process(int guessInt, int rndNum, int guessCount)
    {
        if (guessInt < rndNum)
        {
            StandardMessaging.IncorrectGuess(guessInt, guessCount, "low");
            return false;
        }
        else if (guessInt > rndNum)
        {
            StandardMessaging.IncorrectGuess(guessInt, guessCount, "high");
            return false;
        }
        else
        {
            StandardMessaging.SuccessfulGuess(rndNum, guessCount);
            return true;
        }
    }
}

