using Problems.LeetCode.Medium;
using Xunit;

namespace Problems.LeetCode.Tests.Medium
{
    public class N0875_KokoEatingBananasTests
    {
        [Theory]
        [InlineData("[3,6,7,11]", 8, 4)]
        [InlineData("[30,11,23,4,20]", 5, 30)]
        [InlineData("[30,11,23,4,20]", 6, 23)]
        public void KoKoSoultion1(string pilesStr, int h, int expectedResult)
        {
            int[] piles = Helper.GetIntArray(pilesStr);
            int result = N0875_KokoEatingBananas.Solution1(piles, h);

            Assert.True(result == expectedResult, $"result is not as expected. Actual: {result} - Expected: {expectedResult}");
        }


        [Theory]
        [InlineData("[3,6,7,11]", 8, 4)]
        [InlineData("[30,11,23,4,20]", 5, 30)]
        [InlineData("[30,11,23,4,20]", 6, 23)]
        public void KoKoSoultion2(string pilesStr, int h, int expectedResult)
        {
            int[] piles = Helper.GetIntArray(pilesStr);
            int result = N0875_KokoEatingBananas.Solution2(piles, h);

            Assert.True(result == expectedResult, $"result is not as expected. Actual: {result} - Expected: {expectedResult}");
        }



    }
}
