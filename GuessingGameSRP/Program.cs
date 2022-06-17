using GuessingGameSRP;

// Welcome Message
StandardMessaging.WelcomeMessage();

// Game Setup
Random rnd = new Random();
int rndNum = rnd.Next(1, 101);
bool success = false;
int guessCount = 0;

while (success == false)
{
    // User Guess
    var guess = Console.ReadLine();
    guessCount++;

    // Guess Validation
    bool validGuess = GuessValidator.Validate(guess);

    if (validGuess == true && !string.IsNullOrEmpty(guess))
    {
        // Status of User Guess
        success = GuessProcessor.Process(int.Parse(guess), rndNum, guessCount);
    }

    else
    {
        // Invalid Guess Message
        StandardMessaging.InvalidGuess(guessCount);
    }
}