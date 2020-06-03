using Helper;
using Xunit;

namespace Challenges.Tests.LeetCode.June
{
    public class TwoCitySchedulingTests
    {
        [Theory]
        [InlineData("[[10,20],[30,200],[400,50],[30,20]]", 110)]
        [InlineData("[[10,20],[30,200],[12,50],[40,6]]", 68)]
        [InlineData("[[259,770],[448,54],[926,667],[184,139],[840,118],[577,469]]", 1859)]
        public void ValidTwoCityScheduling(string inputStr, int expectedResult)
        {
            int[][] costs = StringConvertor.ToIntMatrix(inputStr);

            int result = Library.LeetCode.June.TwoCityScheduling.TwoCitySchedCost(costs);
            Assert.True(result == expectedResult, $"{nameof(Library.LeetCode.June.TwoCityScheduling.TwoCitySchedCost)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{inputStr}'");
        }


        [Theory]
        [InlineData("[[10,20],[30,200],[400,50],[30,20]]", 110)]
        [InlineData("[[10,20],[30,200],[12,50],[40,6]]", 68)]
        [InlineData("[[259,770],[448,54],[926,667],[184,139],[840,118],[577,469]]", 1859)]
        public void ValidTwoCityScheduling_LeetCodeBest(string inputStr, int expectedResult)
        {
            int[][] costs = StringConvertor.ToIntMatrix(inputStr);

            int result = Library.LeetCode.June.TwoCityScheduling.TwoCitySchedCost_LeetCodeBest(costs);
            Assert.True(result == expectedResult, $"{nameof(Library.LeetCode.June.TwoCityScheduling.TwoCitySchedCost_LeetCodeBest)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{inputStr}'");
        }
    }
}
