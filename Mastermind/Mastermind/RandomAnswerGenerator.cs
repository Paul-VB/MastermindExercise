using System.Text;

namespace Mastermind
{
    public class RandomAnswerGenerator
    {
        public int AnswerLength { get; private set; } = 4;
        public List<char> PossibleChars { get; private set; } = ['1', '2', '3', '4', '5', '6'];

        public string Generate()
        {
            var random = new Random();

            var newAnswer = new StringBuilder();
            for (int i = 0; i < AnswerLength; i++)
            {
                var newAnswerChar = PossibleChars[random.Next(0, PossibleChars.Count)];
                newAnswer.Append(newAnswerChar);
            }

            return newAnswer.ToString();
        }
    }
}
