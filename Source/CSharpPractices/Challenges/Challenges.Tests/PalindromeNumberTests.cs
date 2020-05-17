using Xunit;

namespace Challenges.Tests
{
    public class PalindromeNumberTests
    {
        [Theory]
        [InlineData(5, true)]
        [InlineData(33, true)]
        [InlineData(242, true)]
        [InlineData(2332, true)]
        [InlineData(0, true)]
        [InlineData(32, false)]
        [InlineData(233, false)]
        [InlineData(2331, false)]
        [InlineData(2322, false)]
        public void ValidPalindromeNumber(int number, bool expectedResult)
        {
            var result = Library.PalindromeNumber.IsPalindrome(number);
            Assert.True(result == expectedResult, $"PalindromeNumber does not meet the expected. Solution result is {result} but expected is {expectedResult} for: {number}");
        }
    }
}
