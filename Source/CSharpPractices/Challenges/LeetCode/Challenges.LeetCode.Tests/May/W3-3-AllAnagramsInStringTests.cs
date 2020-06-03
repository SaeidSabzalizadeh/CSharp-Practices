using System.Collections.Generic;
using Xunit;

namespace Challenges.LeetCode.Tests.May
{
    public class AllAnagramsInStringTests
    {
        [Theory]
        [InlineData("cbaebabacd", "abc", "[0, 6]")]
        [InlineData("abab", "ab", "[0, 1, 2]")]
        [InlineData("baa", "aa", "[1]")]
        [InlineData("ababababab", "aab", "[0, 2, 4, 6]")]
        [InlineData("af", "be", "[]")]
        public void ValidAllAnagramsInString(string s, string p, string expectedResultStr)
        {
            IList<int> result = LeetCode.May.AllAnagramsInString.FindAnagrams(s, p);
            string resultStr = $"[{string.Join(", ", result)}]";
            Assert.True(resultStr == expectedResultStr, $"{nameof(LeetCode.May.AllAnagramsInString.FindAnagrams)} does not meet the expected. Solution result is '{resultStr}' but expected is '{expectedResultStr}' for: '{s}', '{p}'");
        }


        [Theory]
        [InlineData("cbaebabacd", "abc", "[0, 6]")]
        [InlineData("abab", "ab", "[0, 1, 2]")]
        [InlineData("baa", "aa", "[1]")]
        [InlineData("ababababab", "aab", "[0, 2, 4, 6]")]
        [InlineData("af", "be", "[]")]
        public void ValidAllAnagrams_Stackoverflow(string s, string p, string expectedResultStr)
        {
            IList<int> result = LeetCode.May.AllAnagramsInString.FindAnagrams_Stackoverflow(s, p);
            string resultStr = $"[{string.Join(", ", result)}]";
            Assert.True(resultStr == expectedResultStr, $"{nameof(LeetCode.May.AllAnagramsInString.FindAnagrams_Stackoverflow)} does not meet the expected. Solution result is '{resultStr}' but expected is '{expectedResultStr}' for: '{s}', '{p}'");
        }

    }
}
