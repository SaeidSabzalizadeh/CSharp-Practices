using System.Linq;
using Xunit;

namespace Challenges.Tests
{
    public class LongestIncreasingSubsequenceTests
    {
        [Theory]
        [InlineData("1, 4, 3", 2)]
        [InlineData("1, 4, 5, 2, 6", 4)]
        [InlineData("5, 4, 3, 5, 6, 7, 1", 4)]
        public void ValidLongestIncreasingSubsequence(string sequenceCommaSeprated, int expectedResult)
        {
            int[] sequence = sequenceCommaSeprated.Split(',').Select(x => int.Parse(x.Trim())).ToArray();

            var result = Library.LongestIncreasingSubsequence.FindLargestIncreasingSubsequence(sequence);

            Assert.True(result == expectedResult, $"LongestIncreasingSubsequence does not meet the expected. Solution result is {result} but expected is {expectedResult} for: {sequenceCommaSeprated}");
        }
    }
}
