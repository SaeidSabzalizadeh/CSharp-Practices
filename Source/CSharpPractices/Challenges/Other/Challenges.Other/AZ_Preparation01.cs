using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Challenges.Other
{

    /// <summary>
    /// Problem: Longest Substring Without Repeating Characters
    /// Description:
    /// Given a string s, find the length of the longest substring without repeating characters.
    /// Example:
    /// 
    /// Input: s = "abcabcbb"
    /// Output: 3
    /// Explanation: The answer is "abc", with the length of 3.
    /// 
    /// Input: s = "bbbbb"
    /// Output: 1
    /// Explanation: The answer is "b", with the length of 1.
    /// </summary>
    public class AZ_Preparation01
    {
        public static int Run1(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            var chars = new HashSet<char>();
            int maxSubstringLength = 0;
            int inputLength = input.Length;
            //aab
            //il = 3
            while (inputLength > 0)
            {
                for (int i = 0; i < inputLength; i++)
                {
                    //il=3, i = 0, input[i] = 'a', last = F, Contain: F, chars[a], Bigger: F, Max = 0
                    //il=3, i = 1, input[i] = 'a', last = F, Contain: T, chars[a], Bigger: T, Max = 1, input = 'ab'
                    //il=2, i = 0, input[i] = 'a', last = F, Contain: F, chars[a], Bigger: F, Max = 1, input = 'ab'
                    //il=2, i = 1, input[i] = 'b', last = T, Contain: F, chars[a], Bigger: F, Max = 1, input = 'ab'
                    //if (i == inputLength - 1)
                    //{
                    //    inputLength = 0;
                    //    if (i + 1 > maxSubstringLength)
                    //    {
                    //        maxSubstringLength = i + 1;
                    //        break;
                    //    }
                    //}


                    if (!chars.Contains(input[i]))
                    {
                        chars.Add(input[i]);
                    }
                    else
                    {
                        chars = new HashSet<char>();
                        if (i > maxSubstringLength)
                        {
                            maxSubstringLength = i;
                        }

                        input = input.Substring(i, input.Length - i);
                        inputLength = (i == inputLength - 1) ? 0 : input.Length;
                        break;
                    }
                }
            }

            return maxSubstringLength;

        }

        public static int Run2(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            var chars = new HashSet<char>();
            int maxSubstringLength = 0;
            int left = 0;

            for (int right = 0; right < input.Length; right++)
            {
                while (chars.Contains(input[right]))
                {
                    chars.Remove(input[left]);
                    left++;
                }

                chars.Add(input[right]);
                maxSubstringLength = Math.Max(maxSubstringLength, right - left + 1);
            }

            return maxSubstringLength;
        }

        public static void Test(string[] args)
        {
            int methodType = GetMethodType(out bool isExit);

            while (!isExit)
            {
                RunTests(methodType);
                methodType = GetMethodType(out isExit);
            }
        }

        private static int GetMethodType(out bool isExit)
        {
            int number;
            isExit = false;

            do
            {
                Console.WriteLine("Enter method type: (1, 2)?");
                var input = Console.ReadLine();
                if (input == "exit")
                {
                    isExit = true;
                    return -1;
                }

                if (int.TryParse(input, out number) && (number == 1 || number == 2))
                {
                    break;
                }

            } while (true);


            return number;
        }

        private static void RunTests(int methodType)
        {
            int[] inputSizes = { 100, 1000, 5000, 10000, 50000, 100000 };
            foreach (int size in inputSizes)
            {
                var input = GenerateInput(size);
                var stopwatch = Stopwatch.StartNew();

                int result = methodType == 1
                    ? Run1(input)
                    : Run2(input);

                stopwatch.Stop();
                Console.WriteLine($"Input size: {size}, Time taken: {stopwatch.ElapsedMilliseconds} ms");
            }
        }

        private static string GenerateInput(int size)
        {
            var random = new Random();
            var chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = (char)random.Next('a', 'z' + 1);
            }
            return new string(chars);
        }

    }
}
