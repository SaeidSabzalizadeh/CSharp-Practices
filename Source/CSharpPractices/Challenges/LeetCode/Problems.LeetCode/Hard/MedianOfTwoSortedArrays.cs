namespace Problems.LeetCode.Hard
{
    /// <summary>
    /// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
    /// The overall run time complexity should be O(log (m+n)).
    /// 
    /// https://leetcode.com/problems/median-of-two-sorted-arrays/
    /// </summary>
    public class MedianOfTwoSortedArrays
    {
        public static double FindMedianSortedArraysFinal(int[] nums1, int[] nums2)
        {

            int length1 = 0;
            int length2 = 0;

            if (nums1 != null)
                length1 = nums1.Length;

            if (nums2 != null)
                length2 = nums2.Length;

            int index1 = 0;
            int index2 = 0;
            int lastIndex = -1;

            int totalLength = length1 + length2;
            int[] mergedArray = new int[totalLength];


            for (int i = 0; i < totalLength; i++)
            {

                if (index1 < length1)
                {
                    if (index2 == length2 || index2 < length2 && nums1[index1] <= nums2[index2])
                    {
                        lastIndex++;
                        mergedArray[lastIndex] = nums1[index1];
                        index1++;
                    }
                    else if (lastIndex >= 0 && nums1[index1] == mergedArray[lastIndex])
                    {
                        index1++;
                    }
                }


                if (index2 < length2)
                {
                    if (index1 == length1 || index1 < length1 && nums2[index2] <= nums1[index1])
                    {
                        lastIndex++;
                        mergedArray[lastIndex] = nums2[index2];
                        index2++;
                    }
                    else if (lastIndex >= 0 && nums2[index2] == mergedArray[lastIndex])
                    {
                        index2++;
                    }
                }
            }


            int mergedArrayLength = lastIndex + 1;
            if (mergedArrayLength % 2 == 0)
                return (mergedArray[mergedArrayLength / 2] + mergedArray[(mergedArrayLength / 2) - 1]) / 2.0;


            return mergedArray[mergedArrayLength / 2];

        }

        public static double FindMedianSortedArrays2ndTry(int[] nums1, int[] nums2)
        {

            int length1 = 0;
            int length2 = 0;

            if (nums1 != null)
                length1 = nums1.Length;

            if (nums2 != null)
                length2 = nums2.Length;

            int index1 = 0;
            int index2 = 0;
            int lastIndex = -1;

            int totalLength = length1 + length2;
            int[] mergedArray = new int[totalLength];


            for (int i = 0; i < totalLength; i++)
            {

                if (index1 < length1)
                {
                    if ((index2 == length2 || index2 < length2 && nums1[index1] <= nums2[index2]) &&
                        (lastIndex < 0 || nums1[index1] > mergedArray[lastIndex]))
                    {
                        lastIndex++;
                        mergedArray[lastIndex] = nums1[index1];
                        index1++;
                    }
                    else if (lastIndex >= 0 && nums1[index1] == mergedArray[lastIndex])
                    {
                        index1++;
                    }
                }


                if (index2 < length2)
                {
                    if ((index1 == length1 || index1 < length1 && nums2[index2] <= nums1[index1]) &&
                        (lastIndex < 0 || nums2[index2] > mergedArray[lastIndex]))
                    {
                        lastIndex++;
                        mergedArray[lastIndex] = nums2[index2];
                        index2++;
                    }
                    else if (lastIndex >= 0 && nums2[index2] == mergedArray[lastIndex])
                    {
                        index2++;
                    }
                }
            }


            int mergedArrayLength = lastIndex + 1;
            if (mergedArrayLength % 2 == 0)
                return (mergedArray[mergedArrayLength / 2] + mergedArray[(mergedArrayLength / 2) - 1]) / 2.0;


            return mergedArray[mergedArrayLength / 2];

        }

        public static double FindMedianSortedArrays1stTry(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums1.Length == 0)
                return FindMedianSortedArray(nums2);

            if (nums2 == null || nums2.Length == 0)
                return FindMedianSortedArray(nums1);


            int length1 = nums1.Length;
            int length2 = nums2.Length;

            int max = length1 + length2;

            double[] medians = new double[2] { 0, 0 };



            int index1 = 0;
            int index2 = 0;

            int current1 = nums1[0];
            int current2 = nums2[0];
            int maxMerge = -1;

            int[] mergedArray = new int[max];

            for (int i = 0; i < max; i++)
            {

                if (index1 < length1 && nums1[index1] < current2)
                {
                    if (i == 0 || mergedArray[maxMerge] < nums1[index1])
                    {
                        maxMerge++;
                        mergedArray[maxMerge] = nums1[index1];
                    }

                    current1 = nums1[index1];
                    index1++;
                }
                else if (index2 < length2)
                {
                    if (i == 0 || mergedArray[maxMerge] < nums2[index2])
                    {
                        maxMerge++;
                        mergedArray[maxMerge] = nums2[index2];
                    }

                    current2 = nums2[index2];
                    index2++;
                }

            }

            maxMerge++;

            int indexmedian1 = -1;
            int indexmedian2 = -1;

            if (maxMerge % 2 == 0)
            {
                indexmedian2 = maxMerge / 2;
                indexmedian1 = indexmedian2 - 1;
            }
            else
            {
                indexmedian1 = maxMerge / 2;
            }


            if (indexmedian2 > -1)
                return (mergedArray[indexmedian1] + mergedArray[indexmedian2]) / 2.0;

            return medians[indexmedian1];

        }

        private static double FindMedianSortedArray(int[] nums)
        {
            if (nums == null)
                return 0;

            if (nums.Length % 2 == 0)
            {
                return (nums[nums.Length / 2] + nums[(nums.Length / 2) - 1]) / 2.0;
            }

            return nums[nums.Length / 2];

        }

    }
}
