using System.Collections.Generic;

namespace Problems.LeetCode.Easy
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public class N0001_TwoSum
    {
        public static int[] BruteForceSolution(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[2] { j, i };
                    }
                }
            }

            return new int[2] { -1, -1 };
        }

        public static int[] OptimalSolution(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i]; 

                if (dictionary.ContainsKey(diff))
                {
                    return new int[2] { dictionary[diff], i };
                }

                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], i);
                }
            }

            return new int[2] { -1, -1 };
        }
    }
}
