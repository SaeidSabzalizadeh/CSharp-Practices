using Problems.LeetCode.Medium;
using System.Collections.Generic;
using Xunit;

namespace Problems.LeetCode.Tests.All
{
    public class N1239_MaxLenConcatStringUniqCharsTests
    {
        [Theory]
        [InlineData("['un','iq','ue']", 4)]
        [InlineData("['cha','r','act','ers']", 6)]
        [InlineData("['abcdefghijklmnopqrstuvwxyz']", 26)]
        [InlineData("['aa','bb']", 0)]
        public void Test1(string arrayStr, int expectedResult)
        {
            List<string> array = Helper.GetStringArray(arrayStr);
            int result = N1239_MaxLenConcatStringUniqChars.Solution(array);

            Assert.True(result == expectedResult, $"result is not as expected. Actual: {result} - Expected: {expectedResult}");
        }
    }
}
