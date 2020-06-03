﻿using Helper;
using Xunit;

namespace Challenges.LeetCode.Tests.May
{
    public class FindTheTownJudgeTests
    {
        /*
         Examples:

        Input: N = 2, trust = [[1,2]]
        Output: 2

        Input: N = 3, trust = [[1,3],[2,3]]
        Output: 3

        Input: N = 3, trust = [[1,3],[2,3],[3,1]]
        Output: -1

        Input: N = 3, trust = [[1,2],[2,3]]
        Output: -1

        Input: N = 4, trust = [[1,3],[1,4],[2,3],[2,4],[4,3]]
        Output: 3

         */

        [Theory]
        [InlineData("1,2", 2, 2)]
        [InlineData("1,3-2,3", 3, 3)]
        [InlineData("1,3-2,3-3,1", 3, -1)]
        [InlineData("1,2-2,3", 3, -1)]
        [InlineData("1,3-1,4-2,3-2,4-4,3", 4, 3)]
        public void ValidFindTheTownJudge(string numbersStr, int n, int expectedResult)
        {
            int[][] trust = StringConvertor.ToIntMatrix(numbersStr);

            var result = LeetCode.May.FindTheTownJudge.FindJudge(n, trust);
            Assert.True(result == expectedResult, $"{nameof(LeetCode.May.FindTheTownJudge.FindJudge)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{numbersStr}'");
        }

        [Theory]
        [InlineData("1,2", 2, 2)]
        [InlineData("1,3-2,3", 3, 3)]
        [InlineData("1,3-2,3-3,1", 3, -1)]
        [InlineData("1,2-2,3", 3, -1)]
        [InlineData("1,3-1,4-2,3-2,4-4,3", 4, 3)]
        public void ValidFindTheTownJudgeII(string numbersStr, int n, int expectedResult)
        {
            int[][] trust = StringConvertor.ToIntMatrix(numbersStr);

            var result = LeetCode.May.FindTheTownJudge.FindJudgeII(n, trust);
            Assert.True(result == expectedResult, $"{nameof(LeetCode.May.FindTheTownJudge.FindJudgeII)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{numbersStr}'");
        }


        [Theory]
        [InlineData("1,2", 2, 2)]
        [InlineData("1,3-2,3", 3, 3)]
        [InlineData("1,3-2,3-3,1", 3, -1)]
        [InlineData("1,2-2,3", 3, -1)]
        [InlineData("1,3-1,4-2,3-2,4-4,3", 4, 3)]
        public void ValidFindTheTownJudgeIII(string numbersStr, int n, int expectedResult)
        {
            int[][] trust = StringConvertor.ToIntMatrix(numbersStr);

            var result = LeetCode.May.FindTheTownJudge.FindJudgeIII(n, trust);
            Assert.True(result == expectedResult, $"{nameof(LeetCode.May.FindTheTownJudge.FindJudgeIII)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{numbersStr}'");
        }

        [Theory]
        [InlineData("1,2", 2, 2)]
        [InlineData("1,3-2,3", 3, 3)]
        [InlineData("1,3-2,3-3,1", 3, -1)]
        [InlineData("1,2-2,3", 3, -1)]
        [InlineData("1,3-1,4-2,3-2,4-4,3", 4, 3)]
        public void ValidFindTheTownJudgeIV(string numbersStr, int n, int expectedResult)
        {
            int[][] trust = StringConvertor.ToIntMatrix(numbersStr);

            var result = LeetCode.May.FindTheTownJudge.FindJudge_LeetCodeBest(n, trust);
            Assert.True(result == expectedResult, $"{nameof(LeetCode.May.FindTheTownJudge.FindJudge_LeetCodeBest)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{numbersStr}'");
        }

    }
}