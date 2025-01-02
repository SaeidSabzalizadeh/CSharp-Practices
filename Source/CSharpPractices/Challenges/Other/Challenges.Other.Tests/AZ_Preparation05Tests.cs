using Xunit;

namespace Challenges.Other.Tests;

public class AZ_Preparation05Tests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
    [InlineData(new int[] { -1, 1, 0, -3, 3 }, new int[] { 0, 0, 9, 0, 0 })]
    [InlineData(new int[] { 2, 3, 4, 5 }, new int[] { 60, 40, 30, 24 })]
    [InlineData(new int[] { 1, 2 }, new int[] { 2, 1 })]
    [InlineData(new int[] { 1, 0, 3, 4 }, new int[] { 0, 12, 0, 0 })]
    [InlineData(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
    [InlineData(new int[] { 5, 5, 5, 5 }, new int[] { 125, 125, 125, 125 })]
    [InlineData(new int[] { 3, -1, 4 }, new int[] { -4, 12, -3 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 120, 60, 40, 30, 24 })]
    [InlineData(new int[] { 1 }, new int[] { })] // Edge case: Single element array, although problem guarantees n > 1


    public void AZ_CheckDuplicate_Method1_IsValid(int[] input, int[] expectedResult)
    {
        int[] result = AZ_Preparation05.Run1(input);
        Assert.True(Equal(expectedResult, result), $"AZ_Preparation05.Run1() does not return as expected. Actual result is [{ToString(result)}] but expected is [{ToString(expectedResult)}] for: '{ToString(input)}'");
    }

    public bool Equal(int[] firstArray, int[] secondArray)
    {
        if (firstArray.Length != secondArray.Length)
            return false;

        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
                return false;
        }

        return true;
    }

    public string ToString(int[] array)
    {
        return string.Join(',', array);
    }


}
