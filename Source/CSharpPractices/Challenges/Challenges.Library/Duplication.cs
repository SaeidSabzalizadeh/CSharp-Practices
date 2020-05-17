using System;

namespace Challenges.Library
{
    public class Duplication
    {

        public static int FindDuplication(int[] numbers)
        {
            int length = numbers.Length;

            int sum1 = 0;
            for (int i = 0; i < length; ++i)
            {
                if (numbers[i] < 0 || numbers[i] > length - 2)
                    throw new Exception("Invalid numbers.");

                sum1 += numbers[i];
            }

            int sum2 = ((length - 1) * (length - 2)) >> 1;

            return (sum1 - sum2) ;
        }
    }
}
