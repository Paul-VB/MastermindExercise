using Mastermind;
using Xunit;

namespace MastermindTests
{
    public class GuessCheckerTests
    {
        private readonly GuessChecker checker;
        public GuessCheckerTests()
        {
            checker = new GuessChecker();
        }

        [Theory]
        [InlineData("1234", "4233", "++-")]
        [InlineData("1234" , "1234", "++++")]
        [InlineData("1234" , "4321", "----")]
        [InlineData("1234" , "4231", "++--")]
        [InlineData("1234" , "5555", "")]
        [InlineData("1234" , "5255", "+")]
        [InlineData("1234" , "2555", "-")]

        public void TestMethod(string actualAnswer, string userGuess, string expectedResult)
        {
            string result = checker.CheckGuess(userGuess, actualAnswer);
            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
