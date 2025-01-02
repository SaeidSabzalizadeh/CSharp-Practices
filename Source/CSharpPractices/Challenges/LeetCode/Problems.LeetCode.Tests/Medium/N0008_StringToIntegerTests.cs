using Problems.LeetCode.Medium;
using Xunit;

namespace Problems.LeetCode.Tests.Medium
{
    public class N0008_StringToIntegerTests
    {
        [Theory]
        [InlineData("42", 42)]
        [InlineData("-042", -42)]
        [InlineData("1337c0d3", 1337)]
        [InlineData("0-1", 0)]
        [InlineData("words and 987", 0)]
        [InlineData("-91283472332", -2147483648)]
        [InlineData("+-12", 0)]
        [InlineData("2147483648", 2147483647)]
        [InlineData("2147483646", 2147483646)]
        [InlineData("-1010023630o4", -1010023630)]
        public void TestBruteForceSolution(string input, int expectedResult)
        {
            int result = N0008_StringToInteger.BruteForceSolution(input);
            AssertAll(input, result, expectedResult);
        }

        [Theory]
        [InlineData("42", 42)]
        [InlineData("-042", -42)]
        [InlineData("1337c0d3", 1337)]
        [InlineData("0-1", 0)]
        [InlineData("words and 987", 0)]
        [InlineData("-91283472332", -2147483648)]
        [InlineData("+-12", 0)]
        [InlineData("2147483648", 2147483647)]
        [InlineData("2147483646", 2147483646)]
        [InlineData("-1010023630o4", -1010023630)]
        public void TestSimpleSolution(string input, int expectedResult)
        {
            int result = N0008_StringToInteger.SimpleSolution(input);
            AssertAll(input, result, expectedResult);
        }

        private void AssertAll(string input, int result, int expectedResult)
        {
            Assert.True(result == expectedResult, $"Result is not as expected for: '{input}' | Actual: '{result}' - Expected: '{expectedResult}'");
        }
    }
}
