using Problems.LeetCode.Medium;
using Xunit;

namespace Problems.LeetCode.Tests.Medium
{
    public class N0735_AsteroidCollisionTests
    {
        [Theory]
        [InlineData("[5,10,-5]", "[5,10]")]
        [InlineData("[8,-8]", "[]")]
        [InlineData("[10,2,-5]", "[10]")]
        [InlineData("[-2,-1,1,2]", "[-2,-1,1,2]")]
        public void TestSolution1(string asteroidsStr, string expectedResultStr)
        {
            int[] asteroids = Helper.GetIntArray(asteroidsStr);
            int[] result = N0735_AsteroidCollision.Solution(asteroids);
            int[] expectedResult = Helper.GetIntArray(expectedResultStr);

            if (expectedResult == null)
                expectedResult = new int[0];

            if (result == null)
            {
                Assert.True(expectedResult == null, $"result is not as expected. Actual is null - Expected is not null : {expectedResultStr}");
            }
            else if (expectedResult == null)
            {
                Assert.True(result == null, $"result is not as expected. Actual: {Helper.ToString(result)} - Expected is null");
            }
            else
            {
                Assert.True(result.Length == expectedResult.Length, $"result is not as expected. Length! Actual: {Helper.ToString(result)} - Expected: {expectedResultStr}");

                for (int i = 0; i < expectedResult.Length; i++)
                {
                    Assert.True(result[i] == expectedResult[i], $"result is not as expected. Actual: {Helper.ToString(result)} - Expected: {expectedResultStr}");
                }
            }

        }

    }
}
