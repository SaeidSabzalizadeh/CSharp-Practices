using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges.Library.LeetCode.May
{
    public class RemoveKDigits
    {
        /*
         
        Given a non-negative integer num represented as a string, remove k digits from the number so that the new number is the smallest possible.

        Note:
        The length of num is less than 10002 and will be ≥ k.
        The given num does not contain any leading zero.

        Input: num = "1432219", k = 3
        Output: "1219"
        Explanation: Remove the three digits 4, 3, and 2 to form the new number 1219 which is the smallest.         


        Input: num = "10200", k = 1
        Output: "200"
        Explanation: Remove the leading 1 and the number is 200. Note that the output must not contain leading zeroes.

        Input: num = "10", k = 2
        Output: "0"
        Explanation: Remove all the digits from the number and it is left with nothing which is 0.


         */


        public static void Run()
        {
            Base.Start(typeof(RemoveKDigits));


            PerformanceProfiler.Compare(new Dictionary<string, Action>()
            {
                {nameof(RemoveKdigits),   ()=>{ string result = RemoveKdigits("2132422587452116894621014862305470230213604", 18); } },
                {nameof(RemoveKdigits_LeetCodeBest),   ()=>{ string result = RemoveKdigits_LeetCodeBest("2132422587452116894621014862305470230213604", 18); } },
            });

            Base.End(typeof(RemoveKDigits));
        }

        public static string RemoveKdigits_LeetCodeBest(string num, int k)
        {
            if (string.IsNullOrWhiteSpace(num))
                return num;

            if (num.Length <= k)
                return "0";

            var st = new Stack<char>();

            for (int i = 0; i < num.Length; i++)
            {
                while (k > 0 && st.Count > 0 && st.Peek() > num[i])
                {
                    st.Pop();
                    k--;
                }
                st.Push(num[i]);
            }

            while (k > 0)
            {
                k--;
                st.Pop();
            }

            var sb = new StringBuilder();
            while (st.Count > 0)
                sb.Append(st.Pop());

            var arr = sb.ToString().ToArray();
            Array.Reverse(arr);

            var ret = new StringBuilder();

            foreach (var c in arr)
            {
                if (c == '0' && ret.Length == 0)
                    continue;

                ret.Append(c);
            }

            return ret.Length == 0 ? "0" : ret.ToString();
        }

        public static string RemoveKdigits(string num, int k)
        {
            if (num.Length == k)
                return "0";

            StringBuilder sb = new StringBuilder(num);

            /*We will iterate the number k times. In each iteration:
            1. Remove the digit for which the next digit is smaller.
            2. If we reach at the end than remove last digit.*/
            for (int j = 0; j < k; j++)
            {
                int i = 0;
                while (i < sb.Length - 1 && sb[i] <= sb[i + 1])
                {
                    i++;
                }
                sb.Remove(i, 1);
            }

            //remove leading 0's
            while (sb.Length > 1 && sb[0] == '0')
                sb.Remove(0, 1);

            if (sb.Length == 0)
            {
                return "0";
            }

            return sb.ToString();
        }


        //public static string RemoveKdigits(string num, int k)
        //{
        //    if (string.IsNullOrEmpty(num) || num.Length <= k)
        //        return "0";


        //    int remainLength = num.Length - k;
        //    char[] digits = "0123456789".ToCharArray();

        //    int startIndex = 0;
        //    int currentIndex = -1;
        //    int candidate = int.Parse(num);
        //    string newStr = "";
        //    int newInt = -1;

        //    int digitIndex = 0;

        //    newStr = DoSomething();

        //    while (digitIndex < digits.Length)
        //    {
        //        currentIndex = num.IndexOf(digits[digitIndex], startIndex);
        //        if (currentIndex >= 0)
        //        {
        //            startIndex = currentIndex + 1;
        //            newStr += digits[digitIndex];

        //            if (newStr.Length == remainLength)
        //            {
        //                newStr = num.Substring(currentIndex, remainLength);
        //                newInt = int.Parse(newStr);

        //                if (newInt < candidate)
        //                    candidate = newInt;
        //            }
        //        }
        //        else
        //        {
        //            digitIndex++;
        //            startIndex = 0;
        //        }
        //    }

        //    return candidate.ToString();
        //}

        //private static string DoSomething(string num, int currentIndex, int remailLength)
        //{
        //    if (remailLength + currentIndex > num.Length + 1)
        //        return "0";

        //    string candidateStr = num.Substring(currentIndex, remailLength);
        //    int candedate = int.Parse(candidateStr);

        //    char[] digits = "0123456789".ToCharArray();

        //    int index =  num.IndexOf(' ', currentIndex + 1);
        //    if(index >= 0)
        //    {

        //    }


        //}

        public static string RemoveKdigits_Failed2(string num, int k)
        {
            if (string.IsNullOrEmpty(num) || num.Length <= k)
                return "0";

            int remainLength = num.Length - k;

            int candidate = int.Parse(num);
            string newStr = "";
            int newInt = -1;

            for (int i = 0; i < num.Length; i++)
            {

                if (i + remainLength <= num.Length)
                {
                    newStr = num.Substring(i, remainLength);
                    newInt = int.Parse(newStr);

                    if (newInt < candidate)
                        candidate = newInt;
                }

                if (i + k <= num.Length)
                {
                    newStr = num.Substring(0, i) + (i + k < num.Length ? num.Substring(i + k) : "");
                    newInt = int.Parse(newStr);

                    if (newInt < candidate)
                        candidate = newInt;
                }
            }

            return candidate.ToString();
        }


        public static string RemoveKdigits_Failed(string num, int k)
        {
            if (string.IsNullOrEmpty(num) || num.Length <= k)
                return "0";

            int candidate = int.Parse(num);
            string newStr = "";
            int newInt = -1;

            for (int i = 0; i < num.Length; i++)
            {
                if (i + k <= num.Length)
                {
                    newStr = num.Substring(0, i) + (i + k < num.Length ? num.Substring(i + k) : "");
                    newInt = int.Parse(newStr);

                    if (newInt < candidate)
                        candidate = newInt;
                }
            }

            return candidate.ToString();
        }


    }
}
