using Helper;
using System;
using System.Collections.Generic;

namespace Challenges.Library.LeetCode.May
{
    public class SingleElementInArray
    {

        /*
        
        Single Element in a Sorted Array
        You are given a sorted array consisting of only integers where every element appears exactly twice, except for one element which appears exactly once. Find this single element that appears only once.

        Follow up: Your solution should run in O(log n) time and O(1) space.

        Constraints:

        1 <= nums.length <= 10^5
        0 <= nums[i] <= 10^5

         */

        public static void Run()
        {
            Base.Start(typeof(SingleElementInArray));

            const int arrayLength = 8001;
            int half = arrayLength / 2;
            half = (half % 2 == 0) ? half : half + 1;
            int uniqNumber = (half * 2) + 2;

            int[] points = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                if (i == half) 
                {
                    points[i] = uniqNumber;
                }
                else if (i > half)
                {
                    if (i % 2 != 0)
                        points[i] = (i * 2) + 2;
                    else
                        points[i] = points[i - 1];
                }
                else
                {
                    if (i % 2 == 0)
                        points[i] = (i * 2) + 2;
                    else
                        points[i] = points[i - 1];
                }

            }


            int result1 = SingleNonDuplicate(points);
            Base.AddItem("SingleNonDuplicate result:", result1);

            int result2 = SingleNonDuplicate_LeetCodeBest(points);
            Base.AddItem("SingleNonDuplicate_LeetCodeBest result:", result2);


            Base.AddNewSection();
            Base.AddNewSection("Start Comaring");

            PerformanceProfiler.Compare(new Dictionary<string, Action>()
            {
                {nameof(SingleNonDuplicate),   ()=>{ int result = SingleNonDuplicate(points); } },
                {nameof(SingleNonDuplicate_LeetCodeBest),   ()=>{ int result = SingleNonDuplicate_LeetCodeBest(points); } },
            });

            Base.End(typeof(SingleElementInArray));
        }

        public static int SingleNonDuplicate(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            int length = nums.Length;

            if (length == 1)
                return nums[0];

            if (length == 2)
                return -1;

            if (nums[0] != nums[1])
                return nums[0];

            for (int i = 1; i < length; i++)
            {
                if (i < length - 1 && nums[i - 1] != nums[i] && nums[i] != nums[i + 1])
                    return nums[i];
            }

            if (nums[length - 1] != nums[length - 2])
                return nums[length - 1];

            return -1;
        }

        public static int SingleNonDuplicate_LeetCodeBest(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }

            if (nums[0] != nums[1])
            {
                return nums[2] == nums[1] ? nums[0] : nums[1];
            }

            if (nums[nums.Length - 1] != nums[nums.Length - 2])
            {
                return nums[nums.Length - 3] == nums[nums.Length - 2] ? nums[nums.Length - 1] : nums[nums.Length - 2];
            }

            return Search(nums, 0, nums.Length - 1);
        }

        private static int Search(int[] arr, int l, int r)
        {
            while (true)
            {
                var mid = (l + r) / 2;

                if (arr[mid] != arr[mid - 1] && arr[mid] != arr[mid + 1])
                {
                    return arr[mid];
                }

                var isEven = mid % 2 == 0;

                if (!isEven)
                {
                    if (arr[mid] == arr[mid - 1])
                    {
                        l = mid;
                        continue;
                    }

                    r = mid;
                    continue;
                }

                if (arr[mid] == arr[mid + 1])
                {
                    l = mid;
                    continue;
                }

                r = mid;
            }
        }

    }
}
