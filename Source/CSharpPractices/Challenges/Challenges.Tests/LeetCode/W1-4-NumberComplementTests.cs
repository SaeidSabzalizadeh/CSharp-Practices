﻿using Xunit;

namespace Challenges.Tests.LeetCode
{
    public class NumberComplementTests
    {

        [Theory]
        [InlineData(5, 2)]
        [InlineData(1, 0)]
        public void ValidNumberComplement(int number, int expectedResult)
        {
            var result = Library.LeetCode.NumberComplement.FindComplement(number);
            Assert.True(result == expectedResult, $"NumberComplement does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{number}'");
        }

    }
}