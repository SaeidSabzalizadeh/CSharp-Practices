namespace Problems.LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-integer/description/
    /// 
    /// Given a signed 32-bit integer x, return x with its digits reversed. 
    /// If reversing x causes the value to go outside the signed 32-bit integer range [-2^31, 2^31 - 1], then return 0.
    /// </summary>
    public class N0007_ReverseInteger
    {
        public static int BruteForceSolution(int x)
        {
            if (x == int.MinValue)
            {
                return 0;
            }

            var negativeValueMultiply = 1;
            if (x < 0)
            {
                x = x * -1;
                negativeValueMultiply = -1;
            }

            if (x < 10)
            {
                return x * negativeValueMultiply;
            }

            int y = x % 10;
            int reverce = y;
            x = x / 10;

            while (x > 0)
            {
                if (reverce > int.MaxValue / 10)
                {
                    return 0;
                }

                y = x % 10;
                x = x / 10;
                reverce = (reverce * 10) + y;
            }


            return reverce * negativeValueMultiply;
        }
    }
}
