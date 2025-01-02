using Problems.LeetCode.Easy;
using System;
using Xunit;

namespace Problems.LeetCode.Tests.Easy
{
    public class N0001_TwoSumTests
    {
        [Theory]
        [InlineData("[2,7,11,15]", 9, "[0,1]")]
        [InlineData("[3,2,4]", 6, "[1,2]")]
        [InlineData("[3,3]", 6, "[0,1]")]
        [InlineData("[0,4,3,0]", 0, "[0,3]")]
        public void TestBruteForceSolution(string arrayStr, int target, string expectedResultStr)
        {
            int[] nums = Helper.GetIntArray(arrayStr);
            int[] result = N0001_TwoSum.BruteForceSolution(nums, target);
            int[] expectedResult = Helper.GetIntArray(expectedResultStr);
            
            AssertAll(nums,  result, expectedResult, target);
        }

        

        [Theory]
        [InlineData("[2,7,11,15]", 9, "[0,1]")]
        [InlineData("[3,2,4]", 6, "[1,2]")]
        [InlineData("[3,3]", 6, "[0,1]")]
        [InlineData("[0,4,3,0]", 0, "[0,3]")]
        public void TestOptimalSolution(string arrayStr, int target, string expectedResultStr)
        {
            int[] nums = Helper.GetIntArray(arrayStr);
            int[] result = N0001_TwoSum.OptimalSolution(nums, target);
            int[] expectedResult = Helper.GetIntArray(expectedResultStr);

            AssertAll(nums, result, expectedResult, target);
        }


        private void AssertAll(int[] nums, int[] result, int[] expectedResult, int target)
        {
            Assert.True(result.Length == expectedResult.Length, $"result is not as expected length. Actual: {result.Length} - Expected: {expectedResult.Length}");
            for (int i = 0; i < result.Length; i++)
            {
                Assert.True(result[i] == expectedResult[i], $"result[{i}] is not as expected. Actual: {result[i]} - Expected: {expectedResult[i]}");
            }
        }
    }
}
