namespace Challenges.Library
{
    public class PalindromeNumber
    {
        public static void Run()
        {

        }

        public static bool IsPalindrome(int number)
        {
            int reversed = 0;
            int copy = number;

            while (number != 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }

            return reversed == copy;
        }

    }
}
