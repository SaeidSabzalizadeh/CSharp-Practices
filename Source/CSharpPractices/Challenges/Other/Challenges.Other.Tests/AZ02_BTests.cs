using Xunit;

namespace Challenges.Other.Tests
{
    public class AZ02_BTests
    {
        [Theory]
        [InlineData("", true)]
        [InlineData("aa", true)]
        [InlineData("baab", true)]
        [InlineData("CbaabC", true)]
        [InlineData("CbaabCfghjkkjhgf", true)]
        [InlineData("abcdeedfggfcba", true)]
        [InlineData("abcdeedfggfcbax", false)]
        [InlineData("xabcdeedfggfcba", false)]
        [InlineData("xaxbcdeedfggfcba", false)]
        public void AZ_CheckPattern_IsValid(string pattern, bool expectedResult)
        {
            bool result = AZ02_B.CheckPattern(pattern);
            Assert.True(result == expectedResult, $"AZ_CheckPattern_IsValid does not return as expected. Solution result is [{result}] but expected is [{expectedResult}] for: '{pattern}'");
        }
    }
}