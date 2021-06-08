﻿using Problems.LeetCode.Hard;
using Xunit;

namespace Problems.LeetCode.Tests.All
{
    public class MedianOfTwoSortedArraysTests
    {
        [Theory]
        [InlineData("[1,3]", "[2]", 2)]
        [InlineData("[1,2]", "[3,4]", 2.5)]
        [InlineData("[0,0]", "[0,0]", 0)]
        [InlineData("[]", "[1]", 1)]
        [InlineData("[2]", "[]", 2)]
        [InlineData("[1,2,3,4]", "[]", 2.5)]
        [InlineData("[0,0,0,0,0]", "[-1,0,0,0,0,0,1]", 0)]
        [InlineData("[2,2,4,4]", "[2,2,4,4]", 3)]
        [InlineData("[1,1]", "[1,2]", 1)]
        public void Test1(string array1Str, string array2Str, double expectedResult)
        {
            int[] nums1 = Helper.GetArray(array1Str);
            int[] nums2 = Helper.GetArray(array2Str);

           double result =  MedianOfTwoSortedArrays.FindMedianSortedArraysFinal(nums1, nums2);

            Assert.True(result == expectedResult, $"result is not as expected. Actual: {result} - Expected: {expectedResult}");

        }
    }
}
