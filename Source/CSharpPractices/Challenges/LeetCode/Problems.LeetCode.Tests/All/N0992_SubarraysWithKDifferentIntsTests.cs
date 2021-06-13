using Problems.LeetCode.Hard;
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

    }
}
