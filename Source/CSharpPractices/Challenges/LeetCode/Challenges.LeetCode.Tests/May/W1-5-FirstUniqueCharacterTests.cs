using Xunit;

namespace Challenges.LeetCode.Tests.May
{
    public class FirstUniqueCharacterTests
    {
        [Theory]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        public void ValidFirstUniqChar(string input, int expectedResult)
        {
            var result = LeetCode.May.FirstUniqueCharacter.FirstUniqChar(input);
            Assert.True(result == expectedResult, $"{nameof(LeetCode.May.FirstUniqueCharacter.FirstUniqChar)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{input}'");
        }

        [Theory]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        public void ValidFirstUniqCharII(string input, int expectedResult)
        {
            var result = LeetCode.May.FirstUniqueCharacter.FirstUniqCharII(input);
            Assert.True(result == expectedResult, $"{nameof(LeetCode.May.FirstUniqueCharacter.FirstUniqCharII)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{input}'");
        }

        [Theory]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        public void ValidFirstUniqCharIII(string input, int expectedResult)
        {
            var result = LeetCode.May.FirstUniqueCharacter.FirstUniqCharIII(input);
            Assert.True(result == expectedResult, $"{nameof(LeetCode.May.FirstUniqueCharacter.FirstUniqCharIII)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{input}'");
        }

        [Theory]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        public void ValidFirstUniqChar_LeetCodeBest(string input, int expectedResult)
        {
            var result = LeetCode.May.FirstUniqueCharacter.FirstUniqChar_LeetCodeBest(input);
            Assert.True(result == expectedResult, $"{nameof(LeetCode.May.FirstUniqueCharacter.FirstUniqChar_LeetCodeBest)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{input}'");
        }
    }
}
