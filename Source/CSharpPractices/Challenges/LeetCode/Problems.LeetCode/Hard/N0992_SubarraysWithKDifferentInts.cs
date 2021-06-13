using System;

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
    }
}
