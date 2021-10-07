using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.LeetCode.Tests
{
    public class Helper
    {
        internal static List<string> GetStringArray(string str)
        {
            if (string.IsNullOrEmpty(str))
                return null;

            str = str.Trim();

            if (str[0] != '[')
                throw new Exception("Invalid array format expected starts with '['");

            if (str[str.Length - 1] != ']')
                throw new Exception("Invalid array format expected ends with ']'");

            str = str.Substring(1, str.Length - 2);
            str = str.Trim();

            List<string> strings = new List<string>();

            string nextItem = GetNextItem(str, out str);

            while (nextItem != null)
            {
                strings.Add(nextItem);
                nextItem = GetNextItem(str, out str);
            }

            return strings;
        }

        internal static int[] GetIntArray(string str)
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

            if (numbers.Length == 0)
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

        internal static string ToString(IEnumerable<int> result)
        {
            if (result == null)
                return null;

            if (!result.Any())
                return null;

            return $"[{string.Join(',', result)}]";

        }

        private static string GetNextItem(string inputStr, out string str)
        {
            str = inputStr;

            if (string.IsNullOrEmpty(inputStr))
                return null;

            if (inputStr[0] != '\'')
                throw new Exception("Invalid array format expected items starts with (')");

            int lastIndex = inputStr.IndexOf("',", 1);

            if (lastIndex <= 0)
                lastIndex = inputStr.IndexOf("' ,", 1);

            if (lastIndex <= 0)
                lastIndex = inputStr.IndexOf("'  ,", 1);

            if (lastIndex <= 0)
            {
                lastIndex = inputStr.IndexOf("'", 1);
                if (lastIndex != inputStr.Length - 1)
                    throw new Exception("Invalid array format expected items separated by ','");
            }

            if (lastIndex <= 0)
                throw new Exception("Invalid array format expected items ends with (')");


            if (lastIndex == inputStr.Length - 1)
            {
                str = null;
            }
            else
            {
                int endIndex = inputStr.IndexOf(',', lastIndex);
                str = inputStr.Substring(endIndex + 1);
            }


            return inputStr.Substring(1, lastIndex - 1);
        }
    }
}

