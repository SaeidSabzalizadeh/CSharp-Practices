using Problems.LeetCode.Easy;
using Xunit;

namespace Problems.LeetCode.Tests.Easy
{
    public class N0290_WordPatternTests
    {
        [Theory]
        [InlineData("abba","dog cat cat dog", true)]
        [InlineData("abba", "dog cat cat fish", false)]
        [InlineData("aaaa", "dog cat cat dog", false)]
        [InlineData("abbcbc", "whatever sea sea here sea here", true)]
        [InlineData("abbcbc", "whatever sea sea here whatever here", false)]
        [InlineData("abba", "dog dog dog dog", false)]
        [InlineData("aaa", "aa aa aa aa", false)]
        public void Test1(string pattern, string str, bool expectedResult)
        {
            bool result = N0290_WordPattern.Solution(pattern, str);
            Assert.True(result == expectedResult, $"result is not as expected. Actual: {result} - Expected: {expectedResult}");
        }

    }
}
