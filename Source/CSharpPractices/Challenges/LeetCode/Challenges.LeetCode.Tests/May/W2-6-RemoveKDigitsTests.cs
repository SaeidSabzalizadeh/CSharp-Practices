using Xunit;

namespace Challenges.LeetCode.Tests.May
{
    public class RemoveKDigitsTests
    {

        //Input: num = "1432219", k = 3
        //Output: "1219"
        //Explanation: Remove the three digits 4, 3, and 2 to form the new number 1219 which is the smallest.


        //Input: num = "10200", k = 1
        //Output: "200"
        //Explanation: Remove the leading 1 and the number is 200. Note that the output must not contain leading zeroes.

        //Input: num = "10", k = 2
        //Output: "0"
        //Explanation: Remove all the digits from the number and it is left with nothing which is 0.

        [Theory]
        [InlineData("1432219", 3, "1219")]
        [InlineData("10200", 1, "200")]
        [InlineData("10", 2, "0")]
        [InlineData("112", 1, "11")]
        [InlineData("5337", 2, "33")]
        [InlineData("2132427023021364", 12, "13")]
        [InlineData("21324270230213604", 11, "1304")]
        public void ValidRemoveKDigits(string number, int k, string expectedResult)
        {
            var result = LeetCode.May.RemoveKDigits.RemoveKdigits(number, k);
            Assert.True(result == expectedResult, $"{nameof(LeetCode.May.RemoveKDigits.RemoveKdigits)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{number}, {k}'");
        }

        [Theory]
        [InlineData("1432219", 3, "1219")]
        [InlineData("10200", 1, "200")]
        [InlineData("10", 2, "0")]
        [InlineData("112", 1, "11")]
        [InlineData("5337", 2, "33")]
        [InlineData("43214321", 4, "1321")]
        [InlineData("2132427023021364", 12, "13")]
        [InlineData("21324270230213604", 11, "1304")]
        public void ValidRemoveKDigits_LeetCodeBest(string number, int k, string expectedResult)
        {
            var result = LeetCode.May.RemoveKDigits.RemoveKdigits_LeetCodeBest(number, k);
            Assert.True(result == expectedResult, $"{nameof(LeetCode.May.RemoveKDigits.RemoveKdigits_LeetCodeBest)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{number}, {k}'");
        }

    }
}
