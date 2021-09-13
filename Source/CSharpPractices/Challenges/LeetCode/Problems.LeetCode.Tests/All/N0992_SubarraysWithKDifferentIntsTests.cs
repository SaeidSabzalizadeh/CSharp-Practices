using Problems.LeetCode.Hard;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Problems.LeetCode.Tests.All
{
    public class N0992_SubarraysWithKDifferentIntsTests
    {
        [Theory]
        [InlineData("[1,2,1,2,3]", 2, 7)]
        [InlineData("[1,2,1,3,4]", 3, 3)]
        public void Test1(string arrayStr, int k, int expectedResult)
        {
            int[] nums = Helper.GetArray(arrayStr);
            int result = N0992_SubarraysWithKDifferentInts.SubarraysWithKDistinct(nums, k);

            Assert.True(result == expectedResult, $"result is not as expected. Actual: {result} - Expected: {expectedResult}");

        }


        [Theory]
        [InlineData("[3,7,1,2]", 2)]
        public void Test2(string arrayStr, long expectedResult)
        {
            int[] nums = Helper.GetArray(arrayStr);
            long result = N0992_SubarraysWithKDifferentInts.howManySwaps(nums.ToList());

            Assert.True(result == expectedResult, $"result is not as expected. Actual: {result} - Expected: {expectedResult}");

        }

        //[Theory]
        //[InlineData("*|*|*|", "[")]
        //public void Test3(string arrayStr, long expectedResult)
        //{
        //    List<int> result = N0992_SubarraysWithKDifferentInts.numberOfItems("|**|*|*", new List<int>() {1,1 }, new List<int> { 5,6});

        //    Assert.True(result.Count == 2, $"result is not as expected. Actual: {result} - Expected: {expectedResult}");




        //}

    }
}
