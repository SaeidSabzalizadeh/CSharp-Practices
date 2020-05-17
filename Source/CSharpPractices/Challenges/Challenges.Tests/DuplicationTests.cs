using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Challenges.Tests
{
  public  class DuplicationTests
    {
        [Theory]
        [InlineData("2, 1, 3, 1, 0", 1)]
        [InlineData("2, 0, 3, 1, 0", 0)]
        [InlineData("2, 0, 4, 3, 1, 4", 4)]
        public void ValidLongestIncreasingSubsequence(string numbersStr, int expectedResult)
        {
            int[] numbers = numbersStr.Split(',').Select(x => int.Parse(x.Trim())).ToArray();

            var result = Library.Duplication.FindDuplication(numbers);

            Assert.True(result == expectedResult, $"Duplication does not meet the expected. Solution result is {result} but expected is {expectedResult} for: {numbersStr}");
        }

        [Theory]
        [InlineData("2, 1, 3, 0, 4")]
        [InlineData("2, 1, 3, 0, -1")]
        [InlineData("0")]
        public void InValidLongestIncreasingSubsequence(string numbersStr)
        {
            int[] numbers = numbersStr.Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            Assert.Throws<Exception>(() => Library.Duplication.FindDuplication(numbers));

        }

    }
}
