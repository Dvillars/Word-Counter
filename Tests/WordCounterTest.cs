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
            string inputTwo = "is";
            string resultTest = "this is an example, is";

            //Act
            WordCounter testWordCounter = new WordCounter(inputOne, inputTwo);
            string result = testWordCounter.GetBoth();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void DoContains_aBool_true()
        {
            //Arrange
            string inputOne = "this is an example";
            string inputTwo = "is";
            bool resultTest = true;

            //Act
            WordCounter testWordCounter = new WordCounter(inputOne, inputTwo);
            bool result = testWordCounter.DoContains();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void DoContains_aBool_false()
        {
            //Arrange
            string inputOne = "this is an example";
            string inputTwo = "his";
            bool resultTest = false;

            //Act
            WordCounter testWordCounter = new WordCounter(inputOne, inputTwo);
            bool result = testWordCounter.DoContains();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void HowManyContains_HowMany_1()
        {
            //Arrange
            string inputOne = "this is an example";
            string inputTwo = "is";
            int resultTest = 1;

            //Act
            WordCounter testWordCounter = new WordCounter(inputOne, inputTwo);
            int result = testWordCounter.HowManyContains();

            //Assert
            Assert.Equal(resultTest, result);
        }

        [Fact]
        public void HowManyContains_HowMany_2()
        {
            //Arrange
            string inputOne = "Codein' is super super cool";
            string inputTwo = "super";
            int resultTest = 2;

            //Act
            WordCounter testWordCounter = new WordCounter(inputOne, inputTwo);
            int result = testWordCounter.HowManyContains();

            //Assert
            Assert.Equal(resultTest, result);
        }
    }
}
