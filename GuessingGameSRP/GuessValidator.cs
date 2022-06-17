namespace GuessingGameSRP;

public class GuessValidator
{
    public static bool Validate(string? guess)
    {
        bool validInt = int.TryParse(guess, out int guessInt);

        if (validInt == true && !string.IsNullOrEmpty(guess))
        {
            return ValidateRange(guessInt);
        }
        return validInt;
    }

    public static bool ValidateRange(int guessInt)
    {
        if (guessInt < 0 || guessInt > 100)
        {
            return false;
        }

        return true;
    }
}