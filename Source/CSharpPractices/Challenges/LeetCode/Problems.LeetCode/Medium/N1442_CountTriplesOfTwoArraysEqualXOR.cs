using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problems.LeetCode.Medium
{
    /// <summary>
    /// Given an array of integers arr.
    ///    We want to select three indices i, j and k where(0 <= i<j <= k<arr.length).
    /// Let's define a and b as follows:
    /// a = arr[i] ^ arr[i + 1] ^ ... ^ arr[j - 1]
    /// b = arr[j] ^ arr[j + 1] ^ ... ^ arr[k]
    /// Note that ^ denotes the bitwise-xor operation.
    /// Return the number of triplets (i, j and k) Where a == b.
    /// 
    /// https://leetcode.com/problems/count-triplets-that-can-form-two-arrays-of-equal-xor/description/?envType=daily-question&envId=2024-05-30
    /// </summary>
    public class N1442_CountTriplesOfTwoArraysEqualXOR
    {

        public static void Run()
        {
            int[] array = new int[] { 2, 3, 1, 6, 7 };
            int result = Solution(array);
            Console.WriteLine($"Result: {result}");
        }

        public static int Solution(int[] arr)
        {

            int count = 0;

            for (int k = 0; k < arr.Length; k++)
            {
                for (int j = 0; j <= k; j++)
                {
                    for (int i = 0; i < j; i++)
                    {
                        int a = CalculateXOR(arr, i, j - 1);
                        int b = CalculateXOR(arr, j, k);

                        if (a == b)
                        {
                            count++;
                        }
                    }
                }

            }

            return count;
        }

        static int CalculateXOR(int[] arr, int start, int end)
        {
            int result = 0;
            for (int index = start; index <= end; index++)
            {
                result ^= arr[index];
            }
            return result;
        }

        public static int Solution2(int[] arr)
        {

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int val = arr[i];

                for (int k = i + 1; k < arr.Length; k++)
                {
                    val ^= arr[k];

                    if (val == 0)
                    {
                        count += (k - i);
                    }
                }
            }

            return count;
        }

    }
}
