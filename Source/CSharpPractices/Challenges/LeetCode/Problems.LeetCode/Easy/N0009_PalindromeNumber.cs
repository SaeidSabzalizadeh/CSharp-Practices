using System;

namespace Problems.LeetCode.Easy
{

    /// <summary>
    /// https://leetcode.com/problems/palindrome-number/description/
    /// 
    /// Given an integer x, return true if x is a palindrome, and false otherwise.
    /// -2^31 <= x <= 2^31 - 1
    /// </summary>
    public class N0009_PalindromeNumber
    {
        public static bool BruteForceSolution(int x)
        {
            if (x < 0)
            {
                return false;
            }

            int[] digits = new int[10];
            int index = -1;
            while (x > 0)
            {
                index++;
                int reminder = x % 10;
                x = x / 10;
                digits[index] = reminder;
            }

            int reverseIndex = 0;
            for (int i = index; i >= reverseIndex; i--)
            {
                if (digits[i] != digits[reverseIndex])
                {
                    return false;
                }

                reverseIndex++;
            }

            return true;
        }

        public static bool ConvertToStringSolution(int x)
        {
            if (x < 0)
                return false;

            string s = x.ToString();

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            
            return true;
        }

        public static bool MostEfficientSolution(int x)
        {
            
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int reversed = 0;
            int original = x;

            // Reverse only half of the digits
            while (x > reversed)
            {
                reversed = reversed * 10 + (x % 10);
                x /= 10;
            }

            return (x == reversed || x == reversed / 10);
        }
    }
}
