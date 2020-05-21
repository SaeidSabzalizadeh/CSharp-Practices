using Xunit;

namespace Challenges.Tests
{
    public class FirstUniqueCharacterTests
    {
        [Theory]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        public void ValidNumberComplement(string input, int expectedResult)
        {
            var result = Library.LeetCode.FirstUniqueCharacter.FirstUniqChar(input);
            Assert.True(result == expectedResult, $"FirstUniqueCharacter does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{input}'");
        }

        [Theory]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        public void ValidNumberComplementII(string input, int expectedResult)
        {
            var result = Library.LeetCode.FirstUniqueCharacter.FirstUniqCharII(input);
            Assert.True(result == expectedResult, $"FirstUniqueCharacterII does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{input}'");
        }

        [Theory]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        public void ValidNumberComplementIII(string input, int expectedResult)
        {
            var result = Library.LeetCode.FirstUniqueCharacter.FirstUniqCharIII(input);
            Assert.True(result == expectedResult, $"FirstUniqCharIII does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{input}'");
        }
    }
}
