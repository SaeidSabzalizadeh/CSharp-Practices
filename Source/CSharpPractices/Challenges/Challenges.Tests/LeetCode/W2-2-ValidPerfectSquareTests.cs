using Xunit;

namespace Challenges.Tests.LeetCode
{
    public class ValidPerfectSquareTests
    {

        /*
            Input: num = 49
            Output: true

            Input: num = 8
            Output: false

            Input: num = 16
            Output: true

            Input: num = 14
            Output: false
        */

        [Theory]
        [InlineData(49, true)]
        [InlineData(8, false)]
        [InlineData(16, true)]
        [InlineData(121, true)]
        [InlineData(81796, true)]
        [InlineData(14, false)]
        public void ValidPerfectSquare(int number, bool expectedResult)
        {
            var result = Library.LeetCode.ValidPerfectSquare.IsPerfectSquare(number);
            Assert.True(result == expectedResult, $"{nameof(Library.LeetCode.ValidPerfectSquare.IsPerfectSquare)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{number}'");
        }


        [Theory]
        [InlineData(49, true)]
        [InlineData(8, false)]
        [InlineData(16, true)]
        [InlineData(121, true)]
        [InlineData(81796, true)]
        [InlineData(14, false)]
        public void ValidPerfectSquareII(int number, bool expectedResult)
        {
            var result = Library.LeetCode.ValidPerfectSquare.IsPerfectSquareII(number);
            Assert.True(result == expectedResult, $"{nameof(Library.LeetCode.ValidPerfectSquare.IsPerfectSquareII)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{number}'");
        }

        [Theory]
        [InlineData(49, true)]
        [InlineData(8, false)]
        [InlineData(16, true)]
        [InlineData(121, true)]
        [InlineData(81796, true)]
        [InlineData(14, false)]
        public void ValidPerfectSquare_LeetCodeBest(int number, bool expectedResult)
        {
            var result = Library.LeetCode.ValidPerfectSquare.IsPerfectSquare_LeetCodeBest(number);
            Assert.True(result == expectedResult, $"{nameof(Library.LeetCode.ValidPerfectSquare.IsPerfectSquare_LeetCodeBest)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{number}'");
        }

    }
}
