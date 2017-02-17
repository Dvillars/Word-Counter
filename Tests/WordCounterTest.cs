using Xunit;

namespace WordCounterApp
{
    public class WordCounterTests
    {
        [Fact]
        public void WinChecker_ReturnTieRock_NoWin()
        {
            //Arrange
            string inputOne = "this is an example";
            string inputTwo = "example";
            string resultTest = "this is an example, example";

            //Act
            WordCounter testWordCounter = new WordCounter(inputOne, inputTwo);
            string result = testWordCounter.GetBoth();

            //Assert
            Assert.Equal(resultTest, result);
        }
    }
}
