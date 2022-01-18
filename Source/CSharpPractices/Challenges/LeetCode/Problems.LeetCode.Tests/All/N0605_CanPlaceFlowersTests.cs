using Problems.LeetCode.Easy;
using Xunit;

namespace Problems.LeetCode.Tests.All
{
    public class N0605_CanPlaceFlowersTests
    {
        [Theory]
        [InlineData("[1,0,0,0,1]", 1, true)]
        [InlineData("[1,0,0,0,1]", 2, false)]
        [InlineData("[1,0,0,0,0,0,1]", 2, true)]
        [InlineData("[0,0,1,0,0,0,1]", 2, true)]
        [InlineData("[1,0,0,0,1,0,0]", 2, true)]
        [InlineData("[0]", 1, true)]
        public void TestSolution1(string flowerbedArrayStr, int n, bool expectedResult)
        {

            int[] flowerbed = Helper.GetIntArray(flowerbedArrayStr);
            bool result = N0605_CanPlaceFlowers.Solution(flowerbed, n);

            Assert.True(result == expectedResult, $"result is not as expected. Actual: {result} - Expected: {expectedResult}");

        }

    }
}
