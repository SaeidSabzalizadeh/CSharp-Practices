using Problems.LeetCode.Medium;
using Xunit;

namespace Problems.LeetCode.Tests.Medium
{
    public class N0007_ReverseIntegerTests
    {

        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(1534236469, 0)]
        [InlineData(-2147483648, 0)]
        public void TestBruteForceSolution(int input, int expectedResult)
        {
            var result = N0007_ReverseInteger.BruteForceSolution(input);
            AssertAll(input, result, expectedResult);
        }

        private void AssertAll(int input, int result, int expectedResult)
        {
            Assert.True(result == expectedResult, $"Result is not as expected for: '{input}' | Actual: '{result}' - Expected: '{expectedResult}'");
        }
    }
}
