using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.LeetCode.Easy
{


    /// <summary>
    /// 
    /// Given a string s and a character c that occurs in s, return an array of integers answer where answer.length == s.length
    /// and answer[i] is the distance from index i to the closest occurrence of character c in s.
    /// 
    /// The distance between two indices i and j is abs(i - j), where abs is the absolute value function.
    /// 
    /// 
    /// Example 1:
    /// Input: s = "loveleetcode", c = "e"
    /// Output: [3,2,1,0,1,0,0,1,2,2,1,0]
    /// 
    /// Explanation: The character 'e' appears at indices 3, 5, 6, and 11 (0-indexed).
    /// The closest occurrence of 'e' for index 0 is at index 3, so the distance is abs(0 - 3) = 3.
    /// The closest occurrence of 'e' for index 1 is at index 3, so the distance is abs(1 - 3) = 2.
    /// For index 4, there is a tie between the 'e' at index 3 and the 'e' at index 5,
    /// but the distance is still the same: abs(4 - 3) == abs(4 - 5) = 1.
    /// The closest occurrence of 'e' for index 8 is at index 6, so the distance is abs(8 - 6) = 2.
    /// 
    /// 
    /// 
    /// Example 2:
    /// Input: s = "aaab", c = "b"
    /// Output: [3,2,1,0]
    /// 
    /// 
    /// Constraints:
    /// 1 <= s.length <= 10^4
    /// s[i] and c are lowercase English letters.
    /// It is guaranteed that c occurs at least once in s.
    /// 
    /// https://leetcode.com/problems/shortest-distance-to-a-character/
    /// 
    /// </summary>
    public class N0821_ShortestDistanceToChar
    {

        public static int[] Solution(string s, char c)
        {
            if (s == null || s == string.Empty)
                return null;


            int[] result = new int[s.Length];
            int[] occurance = new int[s.Length];
            int max = -1;
            int min1 = -1;
            int min2 = -1;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    occurance[i] = 1;
                    max = i;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                min1 = -1;
                min2 = -1;

                if (occurance[i] == 1)
                {
                    result[i] = 0;
                }
                else
                {
                    if (i < max)
                    {
                        for (int j = i + 1; j <= max; j++)
                        {
                            if (occurance[j] == 1)
                            {
                                min1 = j;
                                break;
                            }

                        }
                    }

                    if (i > 0)
                    {
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if (occurance[j] == 1)
                            {
                                min2 = j;
                                break;
                            }
                        }
                    }

                    if (min1 > -1)
                    {
                        if (min2 > -1)
                        {
                            if (i - min2 > min1 - i)
                                result[i] = min1 - i;
                            else
                                result[i] = i - min2;
                        }
                        else
                        {
                            result[i] = min1 - i;
                        }
                    }
                    else
                    {
                        result[i] = i - min2;
                    }
                }
            }




            return result;
        }

        public static int[] Solution2(string s, char c)
        {
            if (s == null || s == string.Empty)
                return null;

            int[] result = new int[s.Length];
            int max = -1;

            int previous = -1;
            int next = -1;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    next = i;
                    previous = i;
                }

                if (next == i)
                {
                    result[i] = 0;
                    previous = next;
                    next = -1;
                }
                else
                {
                    if (next >= i)
                    {
                        result[i] = GetShortest(next, previous, i);
                    }
                    else
                    {
                        if (max >= -1 && i < s.Length - 1)
                        {
                            for (int j = i + 1; j < s.Length; j++)
                            {
                                if (s[j] == c)
                                {
                                    next = j;
                                    max = j;
                                    break;
                                }

                                max = -2;
                            }

                            if (next > i)
                            {
                                result[i] = GetShortest(next, previous, i);
                            }
                            else
                            {
                                result[i] = i - previous;
                            }

                        }
                        else
                        {
                            result[i] = i - previous;
                        }

                    }
                }
            }

            return result;
        }

        public static int[] Solution3(string s, char c)
        {
            if (s == null || s == string.Empty)
                return null;

            int[] result = new int[s.Length];
            int max = -1;

            int previous = -1;
            int next = -1;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    next = i;
                    previous = i;
                }

                if (next == i)
                {
                    result[i] = 0;
                    previous = next;
                    next = -1;
                }
                else
                {
                    if (next >= i)
                    {
                        if (previous > -1)
                        {
                            if (next - i < i - previous)
                            {
                                result[i] = next - i;
                            }
                            else
                            {
                                result[i] = i - previous;
                            }
                        }
                        else
                        {
                            result[i] = next - i;
                        }


                    }
                    else
                    {
                        if (max >= -1 && i < s.Length - 1)
                        {
                            for (int j = i + 1; j < s.Length; j++)
                            {
                                if (s[j] == c)
                                {
                                    next = j;
                                    max = j;
                                    break;
                                }

                                max = -2;
                            }

                            if (next > i)
                            {
                                if (previous > -1)
                                {
                                    if (next - i < i - previous)
                                    {
                                        result[i] = next - i;
                                    }
                                    else
                                    {
                                        result[i] = i - previous;
                                    }
                                }
                                else
                                {
                                    result[i] = next - i;
                                }
                            }
                            else
                            {
                                result[i] = i - previous;
                            }

                        }
                        else
                        {
                            result[i] = i - previous;
                        }

                    }
                }
            }

            return result;
        }

        private static int GetShortest(int next, int previous, int i)
        {
            if (previous > -1)
            {
                if (next - i < i - previous)
                {
                    return next - i;
                }
                else
                {
                    return i - previous;
                }
            }
            else
            {
                return next - i;
            }
        }



        public static void Run()
        {
            Helper.Base.Start(typeof(N0821_ShortestDistanceToChar));

            Helper.Base.AddItem("Start comparing:", $"------");

            Helper.PerformanceProfiler.Compare(new Dictionary<string, Action>()
            {
                 { "Solution1", () => { int[] result = Solution("loveleetcode",'e');}},
                 { "Solution2", () => { int[] result = Solution2("loveleetcode",'e');}},
                 { "Solution3", () => { int[] result = Solution3("loveleetcode",'e');}},

            }, 1500); ;


            Helper.Base.End(typeof(N0821_ShortestDistanceToChar));
        }
    }
}
