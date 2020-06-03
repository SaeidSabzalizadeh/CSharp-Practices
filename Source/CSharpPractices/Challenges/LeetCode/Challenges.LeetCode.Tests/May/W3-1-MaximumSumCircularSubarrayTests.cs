using System.Linq;
using Xunit;

namespace Challenges.LeetCode.Tests.May
{
    public class MaximumSumCircularSubarrayTests
    {
        [Theory]
        [InlineData("1,-2,3,-2", 3)]
        [InlineData("5,-3,5", 10)]
        [InlineData("3,-1,2,-1", 4)]
        [InlineData("3,-2,2,-3", 3)]
        [InlineData("-2,-3,-1", -1)]
        [InlineData("2,-1,3,-2,4,1", 9)]
        public void ValidMaxSubarraySumCircular_ForLoop(string numberStr, int expectedResult)
        {
            int[] numbers = numberStr.Split(',').Select(x => int.Parse(x)).ToArray();

            var result = LeetCode.May.MaximumSumCircularSubarray.MaxSubarraySumCircular_ForLoop(numbers);
            Assert.True(result == expectedResult, $"{nameof(LeetCode.May.MaximumSumCircularSubarray.MaxSubarraySumCircular_ForLoop)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{numberStr}'");
        }


        [Theory]
        [InlineData("1,-2,3,-2", 3)]
        [InlineData("5,-3,5", 10)]
        [InlineData("3,-1,2,-1", 4)]
        [InlineData("3,-2,2,-3", 3)]
        [InlineData("-2,-3,-1", -1)]
        [InlineData("2,-1,3,-2,4,1", 9)]
        public void ValidMaxSubarraySumCircular_Kadane(string numberStr, int expectedResult)
        {
            int[] numbers = numberStr.Split(',').Select(x => int.Parse(x)).ToArray();

            var result = LeetCode.May.MaximumSumCircularSubarray.MaxSubarraySumCircular_Kadane(numbers);
            Assert.True(result == expectedResult, $"{nameof(LeetCode.May.MaximumSumCircularSubarray.MaxSubarraySumCircular_Kadane)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{numberStr}'");
        }

        [Theory]
        [InlineData("1,-2,3,-2", 3)]
        [InlineData("5,-3,5", 10)]
        [InlineData("3,-1,2,-1", 4)]
        [InlineData("3,-2,2,-3", 3)]
        [InlineData("-2,-3,-1", -1)]
        [InlineData("2,-1,3,-2,4,1", 9)]
        [InlineData("1,-1,3,-2,4,1", 8)]
        public void ValidMaxSubarraySumCircular_LeetCodeBest(string numberStr, int expectedResult)
        {
            int[] numbers = numberStr.Split(',').Select(x => int.Parse(x)).ToArray();

            var result = LeetCode.May.MaximumSumCircularSubarray.MaxSubarraySumCircular_LeetCodeBest(numbers);
            Assert.True(result == expectedResult, $"{nameof(LeetCode.May.MaximumSumCircularSubarray.MaxSubarraySumCircular_LeetCodeBest)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{numberStr}'");
        }



    }
}
