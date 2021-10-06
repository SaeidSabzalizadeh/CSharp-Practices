using System;
using System.Collections.Generic;

namespace Problems.LeetCode.Medium
{
    public class N0442_FindAllDuplicates
    {

        /// <summary>
        /// 
        /// Given an integer array nums of length n where all the integers of nums are in the range [1, n] 
        /// and each integer appears once or twice, return an array of all the integers that appears twice.
        /// You must write an algorithm that runs in O(n) time and uses only constant extra space.
        /// 
        /// https://leetcode.com/problems/find-all-duplicates-in-an-array/
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<int> Solution(int[] nums)
        {
            int[] distinctArray = new int[nums.Length + 1]; //nums of length n where all the integers of nums are in the range [1, n] 
            List<int> duplicates = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (distinctArray[nums[i]] > 0)
                    duplicates.Add(nums[i]);
                else
                    distinctArray[nums[i]] = 1;
            }

            return duplicates;
        }
    }
}
