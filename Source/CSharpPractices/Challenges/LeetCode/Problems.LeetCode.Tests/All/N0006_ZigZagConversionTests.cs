using Problems.LeetCode.Medium;
using Xunit;

namespace Problems.LeetCode.Tests.All
{
    public class N0006_ZigZagConversionTests
    {
        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [InlineData("A", 1, "A")]
        public void Test1(string inputStr, int numRows, string expectedResult)
        {
            string result = N0006_ZigZagConversion.Solution(inputStr, numRows);
            bool isExpected = result == expectedResult;
            Assert.True(isExpected, $"result is not as expected. Actual: {result} - Expected: {expectedResult}");

        }
    }
}
