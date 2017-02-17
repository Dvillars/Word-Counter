using Xunit;

namespace WordCounterApp
{
    public class WordCounterTests
    {
        [Fact]
        public void GetBoth_BothWithComma_BothInput()
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

        [Fact]
        public void doContains_aBool_true()
        {
            //Arrange
            string inputOne = "this is an example";
            string inputTwo = "example";
            bool resultTest = true;

            //Act
            WordCounter testWordCounter = new WordCounter(inputOne, inputTwo);
            bool result = testWordCounter.doContains();

            //Assert
            Assert.Equal(resultTest, result);
        }

        
    }
}
