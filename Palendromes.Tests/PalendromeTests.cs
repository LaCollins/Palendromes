using System;
using Xunit;

namespace Palendromes.Tests
{
    public class PalendromeTests
    {
        [Fact]
        public void stars_is_not_palendrome()
        {
            //Arrange
            var word = "stars";
            var expectedResult = false;
            var palendromeChecker = new PalendromeChecker();

            //Act
            var actualResult = palendromeChecker.IsPalendrome(word);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void this_gibberishs_is__palendrome()
        {
            //Arrange
            var word = "O, a kak Uwakov lil vo kawu kakao!";
            var expectedResult = true;
            var palendromeChecker = new PalendromeChecker();

            //Act
            var actualResult = palendromeChecker.IsPalendrome(word);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void sentence_is__palendrome()
        {
            //Arrange
            var word = "Some men interpret nine memos";
            var expectedResult = true;
            var palendromeChecker = new PalendromeChecker();

            //Act
            var actualResult = palendromeChecker.IsPalendrome(word);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}