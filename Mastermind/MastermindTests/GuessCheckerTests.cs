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

        [Fact]
        public void TestMethod1()
        {
            // Arrange
            string userGuess = "1234";
            string actualAnswer = "1234";
            // Act
            string result = checker.CheckGuess(userGuess, actualAnswer);
            // Assert
            Assert.Equal("++++", result);
        }
    }
}
