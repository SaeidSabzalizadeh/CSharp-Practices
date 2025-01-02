using Xunit;

namespace Challenges.Other.Tests
{
    public class AZ_Preparation01Tests
    {
        //[Theory]
        //[InlineData("pwwkew", 3)]
        //[InlineData("aab", 2)]
        //[InlineData("dvdf", 3)]
        //[InlineData("anviaj", 5)]
        //[InlineData("abcbdaac", 4)]
        //[InlineData("abcdefghij", 10)]
        //[InlineData("aabbccdd", 2)]
        //[InlineData("tmmzuxt", 5)]
        //[InlineData("abcdefghijklmnoabcdefghijklmnopqrstuvwxyza", 26)]
        //[InlineData("bpfbhmipx", 7)]
        //public void AZ_CheckLongestSubstring_Method1_IsValid(string input, int expectedResult)
        //{
        //    int result = AZ_Preparation01.Run1(input);
        //    Assert.True(result == expectedResult, $"AZ_Preparation01 does not return as expected. Actual result is [{result}] but expected is [{expectedResult}] for: '{input}'");
        //}

        [Theory]
        [InlineData("pwwkew", 3)]
        [InlineData("aab", 2)]
        [InlineData("dvdf", 3)]
        [InlineData("anviaj", 5)]
        [InlineData("abcbdaac", 4)]
        [InlineData("abcdefghij", 10)]
        [InlineData("aabbccdd", 2)]
        [InlineData("tmmzuxt", 5)]
        [InlineData("abcdefghijklmnoabcdefghijklmnopqrstuvwxyza", 26)]
        [InlineData("bpfbhmipx", 7)]
        public void AZ_CheckLongestSubstring_Method2_IsValid(string input, int expectedResult)
        {
            int result = AZ_Preparation01.Run2(input);
            Assert.True(result == expectedResult, $"AZ_Preparation01 does not return as expected. Actual result is [{result}] but expected is [{expectedResult}] for: '{input}'");
        }
    }
}
