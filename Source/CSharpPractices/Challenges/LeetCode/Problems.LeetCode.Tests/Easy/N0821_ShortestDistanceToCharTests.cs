using Problems.LeetCode.Easy;
using Xunit;

namespace Problems.LeetCode.Tests.Easy
{
    public class N0821_ShortestDistanceToCharTests
    {
        [Theory]
        [InlineData("loveleetcode", 'e', "[3,2,1,0,1,0,0,1,2,2,1,0]")]
        [InlineData("aaba", 'b', "[2,1,0,1]")]
        [InlineData("baaa", 'b', "[0,1,2,3]")]
        public void TestSolution1(string str, char c, string expectedResultStr)
        {

            int[] expectedResult = Helper.GetIntArray(expectedResultStr);
            int[] result = N0821_ShortestDistanceToChar.Solution(str, c);


            Assert.True(result.Length == expectedResult.Length, $"result is not as expected. Length! Actual: {Helper.ToString(result)} - Expected: {expectedResultStr}");

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.True(result[i] == expectedResult[i], $"result is not as expected. Actual: {Helper.ToString(result)} - Expected: {expectedResultStr}");
            }

        }


        [Theory]
        [InlineData("loveleetcode", 'e', "[3,2,1,0,1,0,0,1,2,2,1,0]")]
        [InlineData("aaba", 'b', "[2,1,0,1]")]
        [InlineData("baaa", 'b', "[0,1,2,3]")]
        public void TestSolution2(string str, char c, string expectedResultStr)
        {

            int[] expectedResult = Helper.GetIntArray(expectedResultStr);
            int[] result = N0821_ShortestDistanceToChar.Solution2(str, c);


            Assert.True(result.Length == expectedResult.Length, $"result is not as expected. Length! Actual: {Helper.ToString(result)} - Expected: {expectedResultStr}");

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.True(result[i] == expectedResult[i], $"result is not as expected. Actual: {Helper.ToString(result)} - Expected: {expectedResultStr}");
            }

        }

    }
}
