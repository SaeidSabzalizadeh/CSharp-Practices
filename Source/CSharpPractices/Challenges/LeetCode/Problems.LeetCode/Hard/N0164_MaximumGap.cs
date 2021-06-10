using System;

namespace Problems.LeetCode.Hard
{

    /// <summary>
    /// Given an integer array nums, return the maximum difference between two successive elements in its sorted form. If the array contains less than two elements, return 0.
    /// You must write an algorithm that runs in linear time and uses linear extra space.
    /// 
    /// https://leetcode.com/problems/maximum-gap/
    /// </summary>
    public class N0164_MaximumGap
    {
        public static int MaximumGap(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return 0;

            int[] sortedNums = Sort2(nums);
            int gap = 0;
            int currentDiff = 0;

            for (int i = 1; i < sortedNums.Length; i++)
            {
                currentDiff = sortedNums[i] - sortedNums[i - 1];
                if (currentDiff > gap)
                {
                    gap = currentDiff;
                }
            }

            return gap;
        }

      

        public static int[] Sort2(int[] entry)
        {
            Quick_Sort(entry, 0, entry.Length - 1);

            return entry;
        }
        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];

            int lowIndex = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    lowIndex++;

                    int temp = array[lowIndex];
                    array[lowIndex] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[lowIndex + 1];
            array[lowIndex + 1] = array[high];
            array[high] = temp1;

            return lowIndex + 1;
        }

        static void Quick_Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(array, low, high);

                Quick_Sort(array, low, partitionIndex - 1);
                Quick_Sort(array, partitionIndex + 1, high);
            }
        }


        public static int[] Sort1(int[] entry)
        {
            int currentItem;

            for (int i = 1; i < entry.Length; i++)
            {
                currentItem = entry[i];
                int currentIndex = i;

                while (currentIndex > 0 && entry[currentIndex - 1] > currentItem)
                {
                    entry[currentIndex] = entry[currentIndex - 1];
                    currentIndex--;
                }

                entry[currentIndex] = currentItem;
            }

            return entry;
        }

    }
}
