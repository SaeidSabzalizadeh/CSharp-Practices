using System.Collections.Generic;

namespace Challenges.Other
{
    public class AZ02_A
    {

        //List<int> ratings = new List<int>() { 3, 2, 1, 3 };
        //long x = CheckRatings(ratings);

        public static long CheckRatings(List<int> ratings) // 3 2 1 3 
        {
            int n = ratings[0];
            int result = n;

            for (int i = 2; i <= n; i++)
            {
                result += GetResultforIteration(i, n, ratings);
            }

            return result;
        }

        private static int GetResultforIteration(int iterateSize, int n, List<int> ratings)
        {
            int currentSize = 1;
            int result = 0;

            for (int i = 2; i <= n; i++)
            {
                if (ratings[i] != ratings[i - 1] - 1)
                    currentSize = 1;
                else
                    currentSize++;

                if (currentSize == iterateSize)
                    result++;
            }

            return result;

        }

    }
}
