using System;

namespace InterviewQuestions
{
    public class PalindromeString
    {

        public static void Run()
        {
            GetPalindromeResultof("abXba");
            GetPalindromeResultof("abbbba");
            GetPalindromeResultof("abSbba");
        }

        private static void GetPalindromeResultof(string input)
        {
            Console.WriteLine();
            Console.WriteLine($" '{input}' {(IsStringAPalindrome(input) ? "Is Palindrome" : "Is not Palindrome")}");
        }

        private static bool IsStringAPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            if (input.Length == 1)
                return true;

            if (input[0] == input[input.Length - 1])
            {
                if (input.Length == 2)
                    return true;

                return IsStringAPalindrome(input.Substring(1, input.Length - 2));
            }


            return false;
        }

    }
}
