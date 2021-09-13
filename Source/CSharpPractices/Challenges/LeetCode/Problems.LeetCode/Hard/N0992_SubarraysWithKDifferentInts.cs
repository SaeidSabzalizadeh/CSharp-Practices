using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.LeetCode.Hard
{
    public class N0992_SubarraysWithKDifferentInts
    {

        /// <summary>
        /// Given an array nums of positive integers, call a (contiguous, not necessarily distinct) subarray of nums good if the number of different integers in that subarray is exactly k.
        /// 
        /// https://leetcode.com/problems/subarrays-with-k-different-integers/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int SubarraysWithKDistinct(int[] nums, int k)
        {

            //Input: nums = [1, 2, 1, 2, 3], k = 2
            //Output: 7
            //Explanation: Subarrays formed with exactly 2 different integers: [1,2], [2,1], [1,2], [2,3], [1,2,1], [2,1,2], [1,2,1,2].

            if (nums == null || nums.Length == 0 || k < 1)
                return 0;

            int[] ks = new int[k];
            int lastKSIndex = 0;
            int result = 0;

            ks[lastKSIndex] = nums[0];
            int firstIndex = 1;

            int[] substrings = new int[nums.Length];
            int subIndex = -1;

            for (int n = 1; n < nums.Length; n++)
            {
                firstIndex = n;
                lastKSIndex = 0;


                for (int i = firstIndex; i < nums.Length; i++)
                {

                    if (k == lastKSIndex + 1) // we have all Ks
                    {
                        if (Matched(ks, lastKSIndex, nums[i]))
                        {
                            if (!ContainsInSubstring(subIndex, substrings, nums, firstIndex, i))
                            {
                                subIndex++;
                                result++;
                            }
                        }
                        else
                        {
                            lastKSIndex = 0;
                            ks[lastKSIndex] = nums[i - 1];

                            if (lastKSIndex < k - 1)
                            {
                                lastKSIndex++;
                                ks[lastKSIndex] = nums[i];

                                if (k == lastKSIndex + 1)
                                {
                                    if (!ContainsInSubstring(subIndex, substrings, nums, firstIndex, i))
                                    {
                                        subIndex++;
                                        result++;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {

                        if (!Matched(ks, lastKSIndex, nums[i]))
                        {
                            lastKSIndex++;
                            ks[lastKSIndex] = nums[i];

                            if (k == lastKSIndex + 1)
                            {
                                if (!ContainsInSubstring(subIndex, substrings, nums, firstIndex, i))
                                {
                                    subIndex++;
                                    result++;
                                }
                            }

                        }

                    }






                }
            }

            return result;


        }



        public static int SubarraysWithKDistinct2(int[] nums, int k)
        {

            //Input: nums = [1, 2, 1, 2, 3], k = 2
            //Output: 7
            //Explanation: Subarrays formed with exactly 2 different integers: [1,2], [2,1], [1,2], [2,3], [1,2,1], [2,1,2], [1,2,1,2].

            if (nums == null || nums.Length == 0 || k < 1)
                return 0;

            int[] ks = new int[k];
            int lastKSIndex = 0;
            int result = 0;

            ks[lastKSIndex] = nums[0];
            int firstIndex = 1;

            int[] substrings = new int[nums.Length];
            int subIndex = -1;

            for (int n = 1; n < nums.Length; n++)
            {
                firstIndex = n;
                lastKSIndex = 0;


                for (int i = firstIndex; i < nums.Length; i++)
                {

                    if (k == lastKSIndex + 1) // we have all Ks
                    {
                        if (Matched(ks, lastKSIndex, nums[i]))
                        {
                            if (!ContainsInSubstring(subIndex, substrings, nums, firstIndex, i))
                            {
                                subIndex++;
                                result++;
                            }
                        }
                        else
                        {
                            lastKSIndex = 0;
                            ks[lastKSIndex] = nums[i - 1];

                            if (lastKSIndex < k - 1)
                            {
                                lastKSIndex++;
                                ks[lastKSIndex] = nums[i];

                                if (k == lastKSIndex + 1)
                                {
                                    if (!ContainsInSubstring(subIndex, substrings, nums, firstIndex, i))
                                    {
                                        subIndex++;
                                        result++;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {

                        if (!Matched(ks, lastKSIndex, nums[i]))
                        {
                            lastKSIndex++;
                            ks[lastKSIndex] = nums[i];

                            if (k == lastKSIndex + 1)
                            {
                                if (!ContainsInSubstring(subIndex, substrings, nums, firstIndex, i))
                                {
                                    subIndex++;
                                    result++;
                                }
                            }

                        }

                    }






                }
            }

            return result;


        }

        private static bool ContainsInSubstring(int index, int[] substrings, int[] nums, int firstIndex, int lastIndex)
        {

            int value = -1;

            if (firstIndex == 0)
            {
                value = -1 * lastIndex;
            }
            else
            {

                int count = 0;
                int refLast = lastIndex;

                while (refLast > 0)
                {
                    refLast = refLast / 10;
                    count++;
                }

                value = (int)(firstIndex * Math.Pow(10, count)) + lastIndex;

            }

            if (index > 0)
            {
                for (int i = 0; i < index; i++)
                {
                    if (substrings[i] == value)
                        return true;
                }
            }



            substrings[index + 1] = value;

            return false;
        }

        private static bool Matched(int[] ks, int lastKSIndex, int value)
        {
            for (int i = 0; i <= lastKSIndex; i++)
            {
                if (ks[i] == value)
                    return true;
            }

            return false;
        }

        public static int SubarraysWithKDistinct1(int[] nums, int k)
        {

            //Input: nums = [1, 2, 1, 2, 3], k = 2
            //Output: 7
            //Explanation: Subarrays formed with exactly 2 different integers: [1,2], [2,1], [1,2], [2,3], [1,2,1], [2,1,2], [1,2,1,2].



            if (nums == null || nums.Length == 0 || k < 1)
                return 0;

            int[] ks = new int[k];
            int lastKSIndex = 0;
            int result = 0;
            bool notMatched = false;
            bool alreadyAdded = false;


            ks[lastKSIndex] = nums[0];
            int firstIndex = 1;


            for (int n = 1; n < nums.Length; n++)
            {
                firstIndex = n;
                notMatched = false;
                alreadyAdded = false;
                lastKSIndex = 0;


                for (int i = firstIndex; i < nums.Length; i++)
                {

                    //K        : 2
                    // nums[i] : 12123
                    //lastIndex: 0
                    //KS       : 23
                    //result   : 4 12/121/1212/23

                    for (int j = 0; j <= lastKSIndex; j++) //12123
                    {
                        if (nums[i] != ks[j])
                        {
                            if (lastKSIndex == k - 1)
                            {
                                notMatched = true;
                                break;
                            }
                        }
                        else
                        {
                            alreadyAdded = true;
                            break;
                        }
                    }


                    if (lastKSIndex < k - 1 && !alreadyAdded)
                    {
                        lastKSIndex++;
                        ks[lastKSIndex] = nums[i];
                    }

                    if (lastKSIndex == k - 1 && !notMatched)
                    {
                        result++;
                    }


                    if (notMatched)
                    {
                        lastKSIndex = 0;
                        ks[lastKSIndex] = nums[i - 1];

                        if (lastKSIndex < k - 1)
                        {
                            lastKSIndex++;
                            ks[lastKSIndex] = nums[i];
                        }

                        if (lastKSIndex == k - 1)
                        {
                            result++;
                        }

                    }

                    notMatched = false;
                    alreadyAdded = false;

                }
            }




            return result;


        }


        public static List<int> numberOfItems(string s, List<int> startIndices, List<int> endIndices)
        {
            int[] results = new int[startIndices.Count];
            int start = -1;
            int end = -1;

            for (int i = 0; i < startIndices.Count; ++i)
            {
                start = startIndices[i];
                end = endIndices[i];
                results[i] = GetNumber(s, start, end);

            }


            return results.ToList();

        }

        private static int GetNumber(string str, int start, int end)
        {

            int startIndex = str.IndexOf('|', start - 1);
            if (startIndex < 0 || startIndex > end - 1)
                return 0;

            int endIndex = -1;

            int starsCount = 0;

            while (startIndex >= start - 1 && startIndex < endIndex && endIndex < end)
            {
                endIndex = str.IndexOf('|', startIndex + 1);
                if (endIndex < startIndex)
                {
                    startIndex = -1;
                }
                else
                {
                    starsCount += endIndex - startIndex - 1;
                    startIndex = endIndex;
                }


            }

            return starsCount;


        }
        public static long howManySwaps(List<int> arr)
        {

            long swaps = 0;
            int count = arr.Count;
            int middle = (count / 2);


            for (int n = 0; n < middle; ++n)
            {
                for (int i = n; i < middle; ++i)
                {
                    if (arr[i] > arr[count - i - 1])
                    {
                        swap(i, count - i - 1, arr);
                        swaps++;
                    }

                }
            }

            return swaps;
        }



        private static void swap(int i, int j, List<int> arr)
        {
            int temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
}
