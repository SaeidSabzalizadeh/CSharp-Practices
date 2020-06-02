using Helper;
using Xunit;

namespace Challenges.Tests.LeetCode.May
{
    public class FloodFillTests
    {
        [Theory]
        [InlineData("1,1,1-1,1,0-1,0,1", 1, 1, 2, "2,2,2-2,2,0-2,0,1")]
        public void ValidFloodFill(string numbersStr, int sr, int sc, int newColor, string expectedResult)
        {
            int[][] matrix = StringConvertor.ToIntMatrix(numbersStr);
            int[][] expectedMatrix = StringConvertor.ToIntMatrix(expectedResult);

            var result = Library.LeetCode.May.FloodFillSolution.FloodFill(matrix, sr, sc, newColor);
            Assert.True(result == expectedMatrix, $"{nameof(Library.LeetCode.May.FindTheTownJudge.FindJudge)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{numbersStr}'");
        }

    }
}
