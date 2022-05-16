using Palindromes;
using Xunit;

namespace TestPalindromes
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("girafarig")]
        [InlineData("dvd")]
        [InlineData("lol")]
        [InlineData("mom")]
        [InlineData("anna-susanna")]
        public void IsPalindrome(string InputString)
        {
            // Act
            var result = PalindromeChecker.IsPalindrome(InputString);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void NotIsAPalindrome()
        {
            // Arrange
            var input = "random";

            // Act
            var result = PalindromeChecker.IsPalindrome(input);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPalindromeHasCapital()
        {
            // Arrange
            var input = "Taco Cat";

            // Act
            var result = PalindromeChecker.IsPalindrome(input);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindromeHasSpecial()
        {
            // Arrange
            var input = "A0ibo*h()ph#!ob$^ia";

            // Act
            var result = PalindromeChecker.IsPalindrome(input);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("Yo, banana boy!")]
        [InlineData("A man, a plan, a canal – Panama")]
        [InlineData("Cigar? Toss it in a can. It is so tragic.")]
        [InlineData("Dog, as a devil deified, lived as a god.")]
        public void IsPalindromeSentence(string InputString)
        {
            // Act
            var result = PalindromeChecker.IsPalindrome(InputString);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void NotIsPalindromeSentence()
        {
            // Arrange
            var input = "People die when they are killed.";

            // Act
            var result = PalindromeChecker.IsPalindrome(input);

            // Assert
            Assert.False(result);
        }
    }
}
