using System;

namespace Problems.LeetCode.Medium
{
    /// <summary>
    /// Given a string s, return the longest palindromic substring in s
    /// Input: s = "babad"
    /// Output: "bab"
    /// Explanation: "aba" is also a valid answer.
    /// 
    /// 1 <= s.length <= 1000
    /// s consist of only digits and English letters.
    /// 
    /// </summary>
    public class N0005_LongestPalindromicSubstring
    {
        public static string BruteForceSolution(string s)
        {
            if (s.Length == 0)
            {
                return string.Empty;
            }

            if (s.Length == 1)
            {
                return s;
            }

            int pointer1HighLevel = 0;
            int pointer2HighLevel = s.Length - 1;

            int pointer1 = 0;
            int pointer2 = s.Length - 1;

            int startPoint = pointer1;
            int endPoint = pointer2;

            bool valid = true;
            var longestPalindromic = "";

            while (pointer1 < pointer2)
            {


                while (pointer1 <= pointer2)
                {
                    if (s[pointer1] == s[pointer2])
                    {
                        pointer1++;
                        pointer2--;
                        valid = true;
                    }
                    else
                    {
                        pointer1 = pointer1HighLevel;
                        pointer2HighLevel--;
                        pointer2 = pointer2HighLevel;
                        startPoint = pointer1;
                        endPoint = pointer2;
                        valid = false;

                        if (longestPalindromic.Length > endPoint - startPoint + 1)
                        {
                            break;
                        }
                    }
                }

                if (valid)
                {
                    var localLongestPalindromic = s.Substring(startPoint, endPoint - startPoint + 1);
                    if (localLongestPalindromic.Length > longestPalindromic.Length)
                    {
                        longestPalindromic = localLongestPalindromic;
                    }
                }

                pointer1HighLevel++;
                pointer2HighLevel = s.Length - 1;
                pointer1 = pointer1HighLevel;
                pointer2 = pointer2HighLevel;
                startPoint = pointer1;
                endPoint = pointer2;

                if (longestPalindromic.Length > endPoint - startPoint + 1)
                {
                    break;
                }
            }

            return longestPalindromic;

        }

        public static string RecursiveSolution(string s)
        {
            if (s == Reverse(s))
            {
                return s;
            }

            var left = RecursiveSolution(s.Substring(1));
            var right = RecursiveSolution(s.Substring(0, s.Length - 1));

            return left.Length > right.Length ? left : right;
        }

        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


        public static string ManachersAlgorithmSolution(string s)
        {
            if (s.Length <= 1)
            {
                return s;
            }

            int maxLen = 1;
            string maxStr = s.Substring(0, 1);
            s = "#" + string.Join("#", s.ToCharArray()) + "#";
            int[] dp = new int[s.Length];
            int center = 0;
            int right = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i < right)
                {
                    dp[i] = Math.Min(right - i, dp[2 * center - i]);
                }

                while (i - dp[i] - 1 >= 0 && i + dp[i] + 1 < s.Length && s[i - dp[i] - 1] == s[i + dp[i] + 1])
                {
                    dp[i]++;
                }

                if (i + dp[i] > right)
                {
                    center = i;
                    right = i + dp[i];
                }

                if (dp[i] > maxLen)
                {
                    maxLen = dp[i];
                    maxStr = s.Substring(i - dp[i], 2 * dp[i] + 1).Replace("#", "");
                }
            }

            return maxStr;
        }

    }
}
