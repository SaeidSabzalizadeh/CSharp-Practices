using Problems.LeetCode.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Problems.LeetCode.Tests.Medium
{
    public class N1442_CountTriplesOfTwoArraysEqualXORTests
    {
        [Theory]
        [InlineData("[2,3,1,6,7]", 4)]
        [InlineData("[1,1,1,1,1]", 10)]
        public void Test1(string arrayStr, int expectedResult)
        {
            int[] array = Helper.GetIntArray(arrayStr);
            int result = N1442_CountTriplesOfTwoArraysEqualXOR.Solution(array);

            Assert.True(result == expectedResult, $"Solution 1 | result is not as expected. Actual: {result} - Expected: {expectedResult}");
        }

        [Theory]
        [InlineData("[2,3,1,6,7]", 4)]
        [InlineData("[1,1,1,1,1]", 10)]
        public void Test2(string arrayStr, int expectedResult)
        {
            int[] array = Helper.GetIntArray(arrayStr);
            int result = N1442_CountTriplesOfTwoArraysEqualXOR.Solution2(array);

            Assert.True(result == expectedResult, $"Solution 2 | result is not as expected. Actual: {result} - Expected: {expectedResult}");
        }
    }
}
