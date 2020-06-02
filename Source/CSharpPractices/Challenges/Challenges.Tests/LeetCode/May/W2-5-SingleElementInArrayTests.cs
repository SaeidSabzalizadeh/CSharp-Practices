using System.Linq;
using Xunit;

namespace Challenges.Tests.LeetCode.May
{
    public class SingleElementInArrayTests
    {
        [Theory]
        [InlineData("1,1,2,3,3,4,4,8,8", 2)]
        [InlineData("3,3,7,7,10,11,11", 10)]
        [InlineData("1,2,2,3,3", 1)]
        public void ValidSingleElementInArray(string numbersStr, int expectedResult)
        {
            int[] nums = numbersStr.Split(',').Select(x => int.Parse(x.Trim())).ToArray();

            var result = Library.LeetCode.May.SingleElementInArray.SingleNonDuplicate(nums);
            Assert.True(result == expectedResult, $"{nameof(Library.LeetCode.May.SingleElementInArray.SingleNonDuplicate)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{numbersStr}'");
        }
    }
}
