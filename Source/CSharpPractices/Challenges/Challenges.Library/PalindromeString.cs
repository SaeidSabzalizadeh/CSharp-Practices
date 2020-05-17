using System;

namespace Challenges.Library
{
    public class PalindromeString
    {

        public static void Run()
        {
            GetPalindromeResultof("abXba");
            GetPalindromeResultof("abbbba");
            GetPalindromeResultof("abSbba");
        }

        public static bool IsPalindromeRecursive(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            if (input.Length == 1)
                return true;

            if (input[0] == input[input.Length - 1])
            {
                if (input.Length == 2)
                    return true;

                return IsPalindromeRecursive(input.Substring(1, input.Length - 2));
            }

            return false;
        }

        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;
            
            int length = input.Length;
            int half = length >> 1;

            for (int i = 0; i < half; i++)
            {
                if (input[i] != input[length - 1 - i])
                    return false;
            }

            return true;
        }


        private static void GetPalindromeResultof(string input)
        {
            Console.WriteLine();
            Console.WriteLine($" '{input}' {(IsPalindrome(input) ? "Is Palindrome" : "Is not Palindrome")}");
        }


    }
}
