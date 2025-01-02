using Xunit;

namespace Challenges.Other.Tests;

public class AZ_Preparation02Tests
{
    [Theory]
    [InlineData(new int[] { 1, 3, 4, 2, 2 }, 2)]
    [InlineData(new int[] { 3, 1, 3, 4, 2 }, 3)]
    [InlineData(new int[] { 1, 1 }, 1)]
    [InlineData(new int[] { 1, 1, 2 }, 1)]
    [InlineData(new int[] { 2, 2, 2, 2, 2 }, 2)]
    [InlineData(new int[] { 10, 2, 6, 4, 7, 10, 8, 1, 3, 5, 9 }, 10)]
    [InlineData(new int[] { 9, 7, 8, 7, 6, 1, 2, 4, 5, 3 }, 7)]
    [InlineData(new int[] { 5, 5, 5, 5, 5, 5, 5 }, 5)]
    [InlineData(new int[] { 8, 8, 7, 6, 5, 4, 3, 2, 1, 8 }, 8)]
    [InlineData(new int[] { 2, 5, 1, 1, 4, 3, 1, 6, 7 }, 1)]
    public void AZ_CheckDuplicate_Method1_IsValid(int[] input, int expectedResult)
    {
        int result = AZ_Preparation02.Run1(input);
        Assert.True(result == expectedResult, $"AZ_Preparation02.Run1() does not return as expected. Actual result is [{result}] but expected is [{expectedResult}] for: '{input}'");
    }

}
