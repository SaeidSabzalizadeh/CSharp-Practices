using Xunit;

namespace Challenges.Tests
{
    public class PalindromeStringTests
    {
        [Theory]
        [InlineData("5", true)]
        [InlineData("33", true)]
        [InlineData("242", true)]
        [InlineData("2332", true)]
        [InlineData("0", true)]
        [InlineData("32", false)]
        [InlineData("233", false)]
        [InlineData("2331", false)]
        [InlineData("2322", false)]
        [InlineData("abXba", true)]
        [InlineData("abbbba", true)]
        [InlineData("abSbba", false)]
        public void ValidPalindromeString(string input, bool expectedResult)
        {
            var result = Library.PalindromeString.IsPalindrome(input);
            Assert.True(result == expectedResult, $"PalindromeString does not meet the expected. Solution result is {result} but expected is {expectedResult} for: {input}");
        }


        [Theory]
        [InlineData("5", true)]
        [InlineData("33", true)]
        [InlineData("242", true)]
        [InlineData("2332", true)]
        [InlineData("0", true)]
        [InlineData("32", false)]
        [InlineData("233", false)]
        [InlineData("2331", false)]
        [InlineData("2322", false)]
        [InlineData("abXba", true)]
        [InlineData("abbbba", true)]
        [InlineData("abSbba", false)]
        public void ValidRecursivePalindromeString(string input, bool expectedResult)
        {
            var result = Library.PalindromeString.IsPalindromeRecursive(input);
            Assert.True(result == expectedResult, $"PalindromeString does not meet the expected. Solution result is {result} but expected is {expectedResult} for: {input}");
        }
    }
}
