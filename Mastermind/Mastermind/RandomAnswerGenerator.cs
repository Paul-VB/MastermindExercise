using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class RandomAnswerGenerator
    {
        private const int answerLength = 4;
        private readonly char[] possibleChars = ['1', '2', '3', '4', '5', '6'];
        public string Generate()
        {
            var random = new Random();

            var newAnswer = new StringBuilder();
            for (int i = 0; i < answerLength; i++)
            {
                var newAnswerChar = possibleChars[random.Next(0, possibleChars.Length)];
                newAnswer.Append(newAnswerChar);
            }

            return newAnswer.ToString();
        }
    }
}
