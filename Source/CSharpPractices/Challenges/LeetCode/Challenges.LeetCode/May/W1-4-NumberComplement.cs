using System;
using System.Collections;
using System.Collections.Generic;

namespace Challenges.LeetCode.May
{
    public class NumberComplement
    {
        /*
        
        Given a positive integer num, output its complement number. The complement strategy is to flip the bits of its binary representation.

        Example 1:
        Input: num = 5
        Output: 2
        Explanation: The binary representation of 5 is 101 (no leading zero bits), and its complement is 010. So you need to output 2.

        Example 2:
        Input: num = 1
        Output: 0
        Explanation: The binary representation of 1 is 1 (no leading zero bits), and its complement is 0. So you need to output 0.

        - The given integer num is guaranteed to fit within the range of a 32-bit signed integer.
        - num >= 1
        - You could assume no leading zero bit in the integer’s binary representation.

        */


        public static void Run()
        {
            Helper.Base.Start(typeof(NumberComplement));

            Helper.PerformanceProfiler.Compare(new Dictionary<string, Action>()
            {
                { nameof(FindComplement), () => { int result = FindComplement(62589548); } },
                { nameof(FindComplement_LeetCodeBest), () => { int result = FindComplement_LeetCodeBest(62589548); } },
            });

            Helper.Base.End(typeof(NumberComplement));
        }

        public static int FindComplement(int num)
        {
            if (num < 1)
                throw new InvalidOperationException("Invalid input");

            int complement = ~num;
            int noLeadingZeroComplement = RemoveLeadingOnes(complement);

            return noLeadingZeroComplement;
        }

        public static int FindComplement_LeetCodeBest(int num)
        {
            int n = num;
            int lastZero = -1;
            int count = 0;
            while (n > 0)
            {
                if ((n & 1) == 0)
                {
                    lastZero = count;
                }
                n = n >> 1;
                count++;
            }
            if (lastZero == -1)
            {
                return 0;
            }
            var temp = 1 << lastZero;
            temp = temp >> 1;

            var res = 1;

            while (temp > 0)
            {
                res = res << 1;
                if ((num & temp) == 0)
                {
                    res += 1;
                }
                temp = temp >> 1;
            }

            return res;

        }


        private static int RemoveLeadingOnes(int number)
        {
            BitArray bitArray = new BitArray(new int[] { number });

            for (int i = bitArray.Length - 1; i > -1; i--)
            {
                if (bitArray[i] == false)
                    break;

                bitArray[i] = false;
            }

            var result = new int[1];
            bitArray.CopyTo(result, 0);
            return result[0];
        }
    }
}
