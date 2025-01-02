using System;

namespace Problems.LeetCode.Medium
{

    /// <summary>
    /// https://leetcode.com/problems/string-to-integer-atoi/description/
    /// 
    /// Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer.
    /// The algorithm for myAtoi(string s) is as follows:
    /// 
    /// 1- Whitespace: Ignore any leading whitespace (" ").
    /// 2- Signedness: Determine the sign by checking if the next character is '-' or '+', assuming positivity if neither present.
    /// 3- Conversion: Read the integer by skipping leading zeros until a non-digit character is encountered or the end of the string is reached. If no digits were read, then the result is 0.
    /// 
    /// 0 <= s.length <= 200
    /// s consists of English letters (lower-case and upper-case), digits (0-9), ' ', '+', '-', and '.'.
    /// </summary>
    public class N0008_StringToInteger
    {
        
        public static int BruteForceSolution(string s)
        {
            int result = 0;
            bool reachedFirstDigit = false;
            bool isNegativeNumber = false;

            for (int i = 0; i < s.Length; i++)
            {

                if (reachedFirstDigit &&
                    s[i] != '0' &&
                    s[i] != '1' &&
                    s[i] != '2' &&
                    s[i] != '3' &&
                    s[i] != '4' &&
                    s[i] != '5' &&
                    s[i] != '6' &&
                    s[i] != '7' &&
                    s[i] != '8' &&
                    s[i] != '9')
                {
                    return isNegativeNumber ? -1 * result : result;
                }

                if (i > 8 && reachedFirstDigit)
                {
                    if (result > int.MaxValue / 10)
                    {
                        return isNegativeNumber ? int.MinValue : int.MaxValue;
                    }

                    if (result == int.MaxValue / 10)
                    {
                        if (s[i] == '8' || s[i] == '9')
                        {
                            return isNegativeNumber ? int.MinValue : int.MaxValue;
                        }
                    }
                }

                if (!reachedFirstDigit && s[i] == ' ')
                {
                    continue;
                }

                if (!reachedFirstDigit && s[i] == '-')
                {
                    isNegativeNumber = true;
                    reachedFirstDigit = true;
                    continue;
                }

                if (!reachedFirstDigit && s[i] == '+')
                {
                    reachedFirstDigit = true;
                    continue;
                }

                if (result == 0 && s[i] == '0')
                {
                    reachedFirstDigit = true;
                    continue;
                }

                if (s[i] == '0')
                {
                    reachedFirstDigit = true;
                    result = result * 10;
                    continue;
                }

                if (s[i] == '1')
                {
                    reachedFirstDigit = true;
                    result = result * 10 + 1;
                    continue;
                }

                if (s[i] == '2')
                {
                    reachedFirstDigit = true;
                    result = result * 10 + 2;
                    continue;
                }

                if (s[i] == '3')
                {
                    reachedFirstDigit = true;
                    result = result * 10 + 3;
                    continue;
                }

                if (s[i] == '4')
                {
                    reachedFirstDigit = true;
                    result = result * 10 + 4;
                    continue;
                }

                if (s[i] == '5')
                {
                    reachedFirstDigit = true;
                    result = result * 10 + 5;
                    continue;
                }

                if (s[i] == '6')
                {
                    reachedFirstDigit = true;
                    result = result * 10 + 6;
                    continue;
                }

                if (s[i] == '7')
                {
                    reachedFirstDigit = true;
                    result = result * 10 + 7;
                    continue;
                }

                if (s[i] == '8')
                {
                    reachedFirstDigit = true;
                    result = result * 10 + 8;
                    continue;
                }

                if (s[i] == '9')
                {
                    reachedFirstDigit = true;
                    result = result * 10 + 9;
                    continue;
                }

                return isNegativeNumber ? -1 * result : result;
            }

            return isNegativeNumber ? -1 * result : result;

        }

        public static int SimpleSolution(string str)
        {
            int sign = 1;
            int basic = 0;
            int i = 0;

            while (i < str.Length && str[i] == ' ')
            {
                i++;
            }

            if (str[i] == '-' || str[i] == '+')
            {
                sign = str[i] == '-' ? -1 : 1;
                i++;
            }

            while (i < str.Length && str[i] == '0')
            {
                i++;
            }

            while (i < str.Length && str[i] >= '0' && str[i] <= '9')
            {
                if (basic > int.MaxValue / 10 || (basic == int.MaxValue / 10 && str[i] - '0' > 7))
                {
                    return sign == 1 ? int.MaxValue : int.MinValue;
                }

                basic = 10 * basic + (str[i] - '0');
                i++;
            }

            return basic * sign;

        }
    }
}
