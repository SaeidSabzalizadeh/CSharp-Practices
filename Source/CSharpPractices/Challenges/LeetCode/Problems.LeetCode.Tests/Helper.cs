using System;

namespace Problems.LeetCode.Tests
{
    public class Helper
    {
        public static int[] GetArray(string str)
        {
            if (string.IsNullOrEmpty(str))
                return null;

            str = str.Replace("{", "");
            str = str.Replace("[", "");
            str = str.Replace("}", "");
            str = str.Replace("]", "");
            str = str.Replace(" ", "");

            string[] numbers = str.Split(',');

            if (numbers == null)
                return null;

            if (string.IsNullOrEmpty(numbers[0]))
                return null;

            int[] array = new int[numbers.Length];

            int number = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!int.TryParse(numbers[i], out number))
                    throw new Exception("Not expected string value.");

                array[i] = number;
            }


            return array;


        }
    }
}
