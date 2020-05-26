using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges.Library.LeetCode
{
    public class MajorityElement
    {
        /*
         
        Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.
        You may assume that the array is non-empty and the majority element always exist in the array.

        Example:
        Input: [3,2,3]
        Output: 3

        Input: [2,2,1,1,1,2,2]
        Output: 2

         */

        public static void Run()
        {
            Helper.Base.Start(typeof(MajorityElement));

            List<int> cc = new List<int>();
            Random ran = new Random();

            for (int i = 0; i < 50000; i++)
            {
                if (i % 2 == 0)
                    cc.Add(ran.Next(1, 500));
                else
                    cc.Add(cc.First());
            }

            int[] longArray = cc.ToArray();

            Helper.Base.AddItem("Start comparing:", $"long array length: {longArray.Length}");

            Helper.PerformanceProfiler.Compare(new Dictionary<string, Action>()
            {
                 { nameof(FindMajorityElement_Dictionary), () => { int result = FindMajorityElement_Dictionary(longArray);}},
                 { nameof(FindMajorityElementII_ImprovedDictionary), () => { int result = FindMajorityElementII_ImprovedDictionary(longArray);}},
                 { nameof(FindMajorityElementIII_LinqSort), () => { int result = FindMajorityElementIII_LinqSort(longArray);}},
                 { nameof(FindMajorityElementIV_LinqSortIndirect), () => { int result = FindMajorityElementIV_LinqSortIndirect(longArray);}},
                 { nameof(FindMajorityElementV_InsertionSort), () => { int result = FindMajorityElementV_InsertionSort(longArray);}},
                 { nameof(FindMajorityElementVI_BubbleSort), () => { int result = FindMajorityElementVI_BubbleSort(longArray);}},
                 { nameof(FindMajorityElementVII_SelectionSort), () => { int result = FindMajorityElementVII_SelectionSort(longArray);}},
                 { nameof(FindMajorityElementVIII_Loops), () => { int result = FindMajorityElementVIII_Loops(longArray);}},
                 { nameof(FindMajorityElement_LeetCodeBest), () => { int result = FindMajorityElement_LeetCodeBest(longArray);}},

            }, 4); ;

            Helper.Base.End(typeof(MajorityElement));
        }


        public static int FindMajorityElement_Dictionary(int[] nums)
        {

            Dictionary<int, int> numberCount = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numberCount.ContainsKey(nums[i]))
                    numberCount[nums[i]] += 1;
                else
                    numberCount.Add(nums[i], 1);
            }


            var max = numberCount.Max(x => x.Value);

            if (max > nums.Length / 2)
                return numberCount.FirstOrDefault(x => x.Value == max).Key;

            return int.MinValue;

        }

        public static int FindMajorityElementII_ImprovedDictionary(int[] nums)
        {
            Dictionary<int, int> numberCount = new Dictionary<int, int>();
            int n = nums.Length;

            if (n == 0)
                return int.MinValue;

            if (n == 1)
                return nums[0];

            int half = n / 2;

            for (int i = 0; i < n; i++)
            {
                int currentValue = nums[i];

                if (numberCount.ContainsKey(currentValue))
                {

                    numberCount[currentValue] += 1;

                    if (numberCount[currentValue] > half)
                        return currentValue;
                }
                else
                {
                    numberCount.Add(currentValue, 1);
                }
            }

            return int.MinValue;
        }

        public static int FindMajorityElementIII_LinqSort(int[] nums)
        {
            return FindMajorityElementWithSortedArray(nums.OrderBy(x => x).ToArray());
        }

        public static int FindMajorityElementIV_LinqSortIndirect(int[] nums)
        {
            return FindMajorityElementWithSortedArray(ArraySorts.LinqSort(nums));
        }

        public static int FindMajorityElementV_InsertionSort(int[] nums)
        {
            return FindMajorityElementWithSortedArray(ArraySorts.InsertionSort(nums));
        }

        public static int FindMajorityElementVI_BubbleSort(int[] nums)
        {
            return FindMajorityElementWithSortedArray(ArraySorts.BubbleSort(nums));
        }

        public static int FindMajorityElementVII_SelectionSort(int[] nums)
        {
            return FindMajorityElementWithSortedArray(ArraySorts.SelectionSort(nums));
        }

        public static int FindMajorityElementVIII_Loops(int[] nums)
        {

            int maxCount = 0;
            int index = -1; // sentinels  

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        count++;
                }

                // update maxCount if count of  
                // current element is greater  
                if (count > maxCount)
                {
                    maxCount = count;
                    index = i;
                }
            }

            // if maxCount is greater than n/2  
            // return the corresponding element  
            if (maxCount > nums.Length / 2)
                return nums[index];

            return int.MinValue;

        }

        public static int FindMajorityElement_LeetCodeBest(int[] nums)
        {
            // Boyer-Moore Voting
            var candidate = 0;
            var count = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                // eg. {7,5,|7,7,5,5|,7}
                if (count == 0)
                {
                    candidate = nums[i];
                    count++;
                }
                else
                {
                    if (nums[i] == candidate)
                        count++;
                    else
                        count--;
                }
            }

            return candidate;

        }


        private static int FindMajorityElementWithSortedArray(int[] sortedNums)
        {
            int n = sortedNums.Length;

            if (n == 0)
                return int.MinValue;

            if (n == 1)
                return sortedNums[0];

            int half = n / 2;
            int currentCount = 1;
            int maxCount = -1;
            int currentValue = sortedNums[0];


            for (int i = 1; i < n; i++)
            {
                if (currentValue == sortedNums[i])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                    currentValue = sortedNums[i];
                }

                if (currentCount > half)
                    return currentValue;

                if (currentCount > maxCount)
                    maxCount = currentCount;
            }

            return int.MinValue;
        }


    }
}
