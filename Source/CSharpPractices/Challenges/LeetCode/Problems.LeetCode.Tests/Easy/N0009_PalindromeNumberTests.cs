using Problems.LeetCode.Easy;
using System.Collections.Generic;
using Xunit;

namespace Problems.LeetCode.Tests.Easy
{
    public class N0009_PalindromeNumberTests
    {
        public static IEnumerable<object[]> PalindromeTestData =>
        new List<object[]>
        {
            new object[] { 121, true },
            new object[] { -121, false },
            new object[] { 10, false }
        };

        [Theory]
        [MemberData(nameof(PalindromeTestData))]
        public void TestBruteForceSolution(int input, bool expectedResult)
        {
            var result = N0009_PalindromeNumber.BruteForceSolution(input);
            AssertAll(input, result, expectedResult);
        }

        [Theory]
        [MemberData(nameof(PalindromeTestData))]
        public void TestConvertToStringSolution(int input, bool expectedResult)
        {
            var result = N0009_PalindromeNumber.ConvertToStringSolution(input);
            AssertAll(input, result, expectedResult);
        }

        [Theory]
        [MemberData(nameof(PalindromeTestData))]
        public void TestMostEfficientSolution(int input, bool expectedResult)
        {
            var result = N0009_PalindromeNumber.MostEfficientSolution(input);
            AssertAll(input, result, expectedResult);
        }

        private void AssertAll(int input, bool result, bool expectedResult)
        {
            Assert.True(result == expectedResult, $"Result is not as expected for: '{input}' | Actual: '{result}' - Expected: '{expectedResult}'");
        }

    }
}
