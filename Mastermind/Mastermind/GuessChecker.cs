using System.Text;

namespace Mastermind
{
    public class GuessChecker
    {
        public string CheckGuess(string userGuess, string actualAnswer)
        {
            var userGuessChars = userGuess.ToCharArray();
            var actualAnswerChars = actualAnswer.ToCharArray();

            var result = new StringBuilder();

            //first, loop through and count the number of correctly positioned guessed chars
            for (int i = 0; i < actualAnswerChars.Length; i++)
            {
                if (actualAnswerChars[i] == userGuessChars[i])
                {
                    result.Append('+');
                    //if they got one right, "remove" it from the actualAnswerChars and userGuessChars so it is not double counted when doing the minuses
                    actualAnswerChars[i] = ' ';
                    userGuessChars[i] = '_';
                }
            }

            //next, loop again and cover the chars that are not correctly placed but DO appear in the answer
            for (int i = 0; i < actualAnswerChars.Length; i++)
            {
                var currAnswerChar = actualAnswerChars[i];
                for (int j = 0; j < userGuessChars.Length; j++)
                {
                    var currGuessChar = userGuessChars[j];
                    if (currAnswerChar == currGuessChar)
                    {
                        result.Append('-');
                        actualAnswerChars[i] = '/';
                        userGuessChars[j] = '|';

                    }
                }
            }

            return result.ToString();
        }
    }
}