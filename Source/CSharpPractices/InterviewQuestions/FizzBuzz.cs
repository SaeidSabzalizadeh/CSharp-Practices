using System;

namespace InterviewQuestions
{
    public class FizzBuzz
    {
        public static void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                string test = string.Empty;
                test += (i % 3) == 0 ? "fizz" : "";
                test += (i % 5) == 0 ? "buzz" : "";

                Console.WriteLine(string.IsNullOrEmpty(test) ? i.ToString() : $"{i} - {test}");

            }
        }
    }
}
