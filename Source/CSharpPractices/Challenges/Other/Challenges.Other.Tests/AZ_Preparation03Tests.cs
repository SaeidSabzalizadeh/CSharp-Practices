using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Challenges.Other.Tests;

public class AZ_Preparation03Tests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 9, new int[] { 3, 4 })]
    [InlineData(new int[] { -1, -2, -3, -4, -5 }, -8, new int[] { 2, 4 })]
    [InlineData(new int[] { 0, 4, 3, 0 }, 0, new int[] { 0, 3 })]
    [InlineData(new int[] { 2, 5, 5, 11 }, 10, new int[] { 1, 2 })]
    [InlineData(new int[] { 1, 1, 1, 1 }, 2, new int[] { 0, 1 })]
    [InlineData(new int[] { 1, 3, 5, 7, 9 }, 10, new int[] { 0, 4 })]
    [InlineData(new int[] { 5, -2, 6, 3, 4, 7 }, 9, new int[] { 0, 4 })]
    public void AZ_CheckDuplicate_Method1_IsValid(int[] input, int target, int[] expectedResult)
    {
        int[] result = AZ_Preparation03.Run1(input, target);
        Assert.True(Equal(expectedResult, result), $"AZ_Preparation03.Run1() does not return as expected. Actual result is [{ToString(result)}] but expected is [{ToString(expectedResult)}] for: '{ToString(input)}, {target}'");
    }

    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 9, new int[] { 3, 4 })]
    [InlineData(new int[] { -1, -2, -3, -4, -5 }, -8, new int[] { 2, 4 })]
    [InlineData(new int[] { 0, 4, 3, 0 }, 0, new int[] { 0, 3 })]
    [InlineData(new int[] { 2, 5, 5, 11 }, 10, new int[] { 1, 2 })]
    [InlineData(new int[] { 1, 1, 1, 1 }, 2, new int[] { 0, 1 })]
    [InlineData(new int[] { 1, 3, 5, 7, 9 }, 10, new int[] { 1, 3 })]
    [InlineData(new int[] { 5, -2, 6, 3, 4, 7 }, 9, new int[] { 2, 3 })]
    public void AZ_CheckDuplicate_Method2_IsValid(int[] input, int target, int[] expectedResult)
    {
        int[] result = AZ_Preparation03.Run2(input, target);
        Assert.True(Equal(expectedResult, result), $"AZ_Preparation03.Run2() does not return as expected. Actual result is [{ToString(result)}] but expected is [{ToString(expectedResult)}] for: '{ToString(input)}, {target}'");
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
