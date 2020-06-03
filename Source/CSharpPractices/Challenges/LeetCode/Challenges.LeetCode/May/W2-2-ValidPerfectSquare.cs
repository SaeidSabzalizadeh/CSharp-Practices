using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.LeetCode.May
{
    public class ValidPerfectSquare
    {
        /*
          Given a positive integer num, write a function which returns True if num is a perfect square else False.
          Follow up: Do not use any built-in library function such as sqrt.


            Input: num = 49
            Output: true

            Input: num = 8
            Output: false

            Input: num = 16
            Output: true

            Input: num = 14
            Output: false
        */

        public static void Run()
        {
            Helper.Base.Start(typeof(ValidPerfectSquare));

            Helper.PerformanceProfiler.Compare(new Dictionary<string, Action>()
            {
                {nameof(IsPerfectSquare),   ()=>{ bool result = IsPerfectSquare(2025000000); } },
                {nameof(IsPerfectSquareII), ()=>{ bool result = IsPerfectSquareII(2025000000); } },
                {nameof(IsPerfectSquare_LeetCodeBest), ()=>{ bool result = IsPerfectSquare_LeetCodeBest(2025000000); } }
            });


            Helper.Base.End(typeof(ValidPerfectSquare));
        }


        public static bool IsPerfectSquare(int num)
        {
            if (num == 1)
                return true;

            for (int i = 2; i < num; i++)
            {
                int sq = i * i;

                if (sq == num)
                    return true;

                if (sq > num)
                    return false;
            }

            return false;
        }


        public static bool IsPerfectSquareII(int num)
        {
            if (num == 1 || num == 4)
                return true;

            if (num < 4)
                return false;

            int first = 2;
            int second = num / 2;

            return CheckPerfectSquare(num, first, second);
        }

        public static bool IsPerfectSquare_LeetCodeBest(int num)
        {
            long i = 1;

            while (i * i < num)
            {
                i *= 2;
            }
            long l = i / 2;
            long r = i;

            while (l < r)
            {
                if (r * r == num) return true;

                long m = (l + r) / 2;

                if (m * m < num)
                {
                    l = m;
                    r = r - 1;
                }
                else
                {
                    r = m;
                }
            }
            return false;
        }

        private static bool CheckPerfectSquare(int num, long first, long second)
        {
            long middle = (first + second) / 2;
            long sqrFirst = first * first;
            long sqrSecond = second * second;
            long sqrMiddle = middle * middle;

            if (num == sqrFirst || num == sqrSecond || num == sqrMiddle)
                return true;

            if (sqrFirst > num)
                return false;

            if (first == middle || second == middle)
                return false;

            if (num > sqrMiddle)
                return CheckPerfectSquare(num, middle, second);

            return CheckPerfectSquare(num, first, middle);
        }


    }
}
