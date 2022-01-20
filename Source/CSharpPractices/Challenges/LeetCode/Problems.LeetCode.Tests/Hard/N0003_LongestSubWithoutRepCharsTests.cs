using Problems.LeetCode.Hard;
using Xunit;

namespace Problems.LeetCode.Tests.Hard
{
    public class N0003_LongestSubWithoutRepCharsTests
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("", 0)]
        [InlineData("aab", 2)]
        [InlineData("dvdf", 3)]
        public void Test1(string input, int expectedResult)
        {

            int result = N0003_LongestSubWithoutRepChars.LengthOfLongestSubstring(input);

            Assert.True(result == expectedResult, $"result is not as expected. Actual: {result} - Expected: {expectedResult}");

        }
    }
}
