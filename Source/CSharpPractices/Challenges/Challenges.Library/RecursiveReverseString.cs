using System;

namespace Challenges.Library
{
    public class RecursiveReverseString
    {

        public static void Run()
        {
            Console.WriteLine("Enter a string to Reverse:");
            var input = Console.ReadLine();

            var reverse = ReverseString(input); //AnotherReverseString(input);

            Console.WriteLine($"The reverse of {input} is {reverse}");
            Console.ReadLine();
        }


        public static string MyReverseString(string input, int currentLength)
        {

            if (currentLength == input.Length)
                return input;

            var last = input.Substring(input.Length - 1, 1);
            var first = (currentLength > 1) ? input.Substring(0, currentLength - 1) : "";
            var rest = input.Substring(currentLength - 1, input.Length - currentLength);

            input = first + last + rest;
            return MyReverseString(input, ++currentLength);

        }

        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return ReverseString(input.Substring(1)) + input[0];
        }

        public static string AnotherReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return input[input.Length - 1] + AnotherReverseString(input.Substring(0, input.Length - 1));
        }

    }
}
