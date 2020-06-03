using Helper;
using Xunit;

namespace Challenges.LeetCode.Tests.May
{
    public class StraightLineTests
    {

        //Input: coordinates = [[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]]
        //Output: true

        //Input: coordinates = [[1,1],[2,2],[3,4],[4,5],[5,6],[7,7]]
        //Output: false

        [Theory]
        [InlineData("1,2-2,3-3,4-4,5-5,6-6,7", true)]
        [InlineData("1,1-2,2-3,4-4,5-5,6-7,7", false)]
        public void ValidStraightLine(string numbersStr, bool expectedResult)
        {
            int[][] points = StringConvertor.ToIntMatrix(numbersStr);

            var result = LeetCode.May.StraightLine.CheckStraightLine(points);
            Assert.True(result == expectedResult, $"{nameof(LeetCode.May.StraightLine.CheckStraightLine)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{numbersStr}'");
        }


        [Theory]
        [InlineData("1,2-2,3-3,4-4,5-5,6-6,7", true)]
        [InlineData("1,1-2,2-3,4-4,5-5,6-7,7", false)]
        public void ValidCheckStraightLine_LeetCodeBest(string numbersStr, bool expectedResult)
        {
            int[][] points = StringConvertor.ToIntMatrix(numbersStr);

            var result = LeetCode.May.StraightLine.CheckStraightLine_LeetCodeBest(points);
            Assert.True(result == expectedResult, $"{nameof(LeetCode.May.StraightLine.CheckStraightLine_LeetCodeBest)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{numbersStr}'");
        }

    }
}
