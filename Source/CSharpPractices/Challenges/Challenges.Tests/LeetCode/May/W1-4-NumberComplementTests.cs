﻿using Xunit;

namespace Challenges.Tests.LeetCode.May
{
    public class NumberComplementTests
    {

        [Theory]
        [InlineData(5, 2)]
        [InlineData(1, 0)]
        public void ValidNumberComplement(int number, int expectedResult)
        {
            var result = Library.LeetCode.May.NumberComplement.FindComplement(number);
            Assert.True(result == expectedResult, $"{nameof(Library.LeetCode.May.NumberComplement.FindComplement)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{number}'");
        }

        [Theory]
        [InlineData(5, 2)]
        [InlineData(1, 0)]
        public void ValidComplement_LeetCodeBest(int number, int expectedResult)
        {
            var result = Library.LeetCode.May.NumberComplement.FindComplement_LeetCodeBest(number);
            Assert.True(result == expectedResult, $"{nameof(Library.LeetCode.May.NumberComplement.FindComplement_LeetCodeBest)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{number}'");
        }

    }
}
