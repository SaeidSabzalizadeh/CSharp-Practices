using System;
using System.Collections.Generic;

namespace Problems.LeetCode.Medium
{

    /// <summary>
    /// Maximum Length of a Concatenated String with Unique Characters
    /// 
    /// You are given an array of strings arr. A string s is formed by the concatenation of a subsequence of arr that has unique characters.
    /// Return the maximum possible length of s.
    /// A subsequence is an array that can be derived from another array by deleting some or no elements without changing the order of the remaining elements.
    /// 
    /// 1 <= arr.length <= 16
    /// 1 <= arr[i].length <= 26
    /// arr[i] contains only lowercase English letters.
    /// 
    /// https://leetcode.com/problems/maximum-length-of-a-concatenated-string-with-unique-characters/
    /// 
    /// </summary>
    public class N1239_MaxLenConcatStringUniqChars
    {

        public static int Solution(IList<string> arr)
        {

            int[] result = new int[1];
            maxUnique(arr, 0, "", result);

            return result[0];
        }

        private static void maxUnique(IList<string> arr, int index, string current, int[] result)
        {

            if (index == arr.Count && UniqCharCount(current) > result[0])
            {
                result[0] = current.Length;
                return;
            }

            if (index == arr.Count)
                return;

            maxUnique(arr, index + 1, current, result);
            maxUnique(arr, index + 1, current + arr[index], result);
        }

        private static int UniqCharCount(string str)
        {
            int[] counts = new int[26];

            foreach (char c in str)
            {
                if (counts[c - 'a']++ > 0)
                    return -1;
            }

            return str.Length;
        }
    }
}
