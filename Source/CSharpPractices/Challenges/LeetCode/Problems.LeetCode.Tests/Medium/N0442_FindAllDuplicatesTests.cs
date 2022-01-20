using Problems.LeetCode.Medium;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Problems.LeetCode.Tests.Medium
{
    public class N0442_FindAllDuplicatesTests
    {
        [Theory]
        [InlineData("[4,3,2,7,8,2,3,1]", "[2,3]")]
        [InlineData("[1,1,2]", "[1]")]
        [InlineData("[1]", "[]")]
        public void Test1(string arrayStr, string expectedResultArrayStr)
        {
            int[] nums = Helper.GetIntArray(arrayStr);
            int[] expectedResult = Helper.GetIntArray(expectedResultArrayStr);

            List<int> result = N0442_FindAllDuplicates.Solution(nums)?.ToList();
            if (result.Any() != true)
                result = null;

            Assert.True(expectedResult?.Count() == result?.Count(), $"result is not as expected. (Count check) Actual: {result?.Count()} - Expected: {expectedResult?.Count()}");

            List<int> orderedResult = result?.OrderBy(x => x).ToList();
            List<int> orderedexpectedResult = expectedResult?.OrderBy(x => x).ToList();
            
            if (orderedResult != null)
            {
                for (int i = 0; i < orderedResult.Count; i++)
                {
                    Assert.True(orderedResult[i] == orderedexpectedResult[i], $"result is not as expected. [{i}] | Actual: {orderedResult[i]} - Expected: {orderedexpectedResult[i]}");
                }
            }

        }

    }
}
