using Problems.LeetCode.Hard;
using Xunit;

namespace Problems.LeetCode.Tests.Hard
{
    public class N0166_FractionToRecurringDecimalTests
    {

        [Theory]
        [InlineData(4, 333, "0.(012)")]
        public void Test1(int numerator, int denominator, string expectedResult)
        {

            string result = N0166_FractionToRecurringDecimal.FractionToDecimal(numerator, denominator);

            Assert.True(result == expectedResult, $"result is not as expected. Actual: {result} - Expected: {expectedResult}");

        }

    }
}
