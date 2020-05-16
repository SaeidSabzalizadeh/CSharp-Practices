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
        public void ValidLongestIncreasingSubsequenceTests(string sequenceCommaSeprated, int expectedLength)
        {
            int[] sequence = sequenceCommaSeprated.Split(',').Select(x => int.Parse(x.Trim())).ToArray();

            var actualValue = Library.LongestIncreasingSubsequence.FindLargestIncreasingSubsequence(sequence);

            Assert.True(expectedLength == actualValue, $"Does not meet the expected. Solution result is {actualValue} but expected value is {expectedLength} for: {sequenceCommaSeprated}");
        }
    }
}
