using Problems.LeetCode.Medium;
using Xunit;

namespace Problems.LeetCode.Tests.Medium
{
    public class N0005_LongestPalindromicSubstringTests
    {
        [Theory]
        [InlineData("babad", "bab")]
        [InlineData("cbbd", "bb")]
        [InlineData("a", "a")]
        [InlineData("bacabab", "bacab")]
        public void TestBruteForceSolution(string input, string expectedResult)
        {
            var result = N0005_LongestPalindromicSubstring.BruteForceSolution(input);

            AssertAll(input, result, expectedResult);
        }

        [Theory]
        [InlineData("babad", "bab")]
        [InlineData("cbbd", "bb")]
        [InlineData("a", "a")]
        [InlineData("bacabab", "bacab")]
        public void TestRecursiveSolution(string input, string expectedResult)
        {
            var result = N0005_LongestPalindromicSubstring.RecursiveSolution(input);

            AssertAll(input, result, expectedResult);
        }

        [Theory]
        [InlineData("babad", "bab")]
        [InlineData("cbbd", "bb")]
        [InlineData("a", "a")]
        [InlineData("bacabab", "bacab")]
        public void TestManachersAlgorithmSolution(string input, string expectedResult)
        {
            var result = N0005_LongestPalindromicSubstring.ManachersAlgorithmSolution(input);

            AssertAll(input, result, expectedResult);
        }

        private void AssertAll(string input, string result, string expectedResult)
        {
            Assert.True(result == expectedResult, $"Result is not as expected for '{input}'. Actual: '{result}' - Expected: '{expectedResult}'");
        }
    }
}
