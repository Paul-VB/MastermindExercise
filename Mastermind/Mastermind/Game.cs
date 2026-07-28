namespace Mastermind
{
    public class Game(RandomAnswerGenerator randomAnswerGenerator, GuessChecker guessChecker)
    {
        private const int chancesRemaining = 10;
        public void Run()
        {
            PrintIntroText();
            var answer = randomAnswerGenerator.Generate();

            while (chancesRemaining > 0)
            {
                Console.WriteLine($"you have {chancesRemaining} more chances.");
                var currentGuess = GetUserInput();
                var guessResult = guessChecker.CheckGuess(currentGuess, answer);
            }
        }

        private string GetUserInput()
        {
            string? input = "";
            while (string.IsNullOrEmpty(input) || input.Length != randomAnswerGenerator.AnswerLength)
            {
                Console.Write($"enter your guess (exactly {randomAnswerGenerator.AnswerLength} long): ");
                input = Console.ReadLine();
            }
            return input;
        }

        private void PrintIntroText()
        {
            Console.WriteLine($"Welcome to Mastermind. Your goal is to guess the correct randomly generated {randomAnswerGenerator.AnswerLength}-digit string");
            Console.WriteLine($"the digits can be any of the following symbols: {string.Join(",", randomAnswerGenerator.PossibleChars)}");
        }

    }
}
