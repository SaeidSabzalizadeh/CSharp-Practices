namespace Problems.LeetCode.Easy
{


    /// <summary>
    /// 
    /// You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.
    /// Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty,
    /// and an integer n, return if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule.
    /// 
    /// Example 1:
    /// Input: flowerbed = [1,0,0,0,1], n = 1
    /// Output: true
    /// 
    /// Example 2:
    /// Input: flowerbed = [1,0,0,0,1], n = 2
    /// Output: false
    /// 
    /// Constraints:
    /// 1 <= flowerbed.length <= 2 * 10^4
    /// flowerbed[i] is 0 or 1
    /// There are no two adjacent flowers in flowerbed
    /// 0 <= n <= flowerbed.length
    /// 
    /// 
    /// https://leetcode.com/problems/can-place-flowers/
    /// </summary>
    public class N0605_CanPlaceFlowers
    {

        public static bool Solution(int[] flowerbed, int n)
        {
            if (n <= 0)
                return true;

            if (flowerbed.Length == 1)
            {
                return flowerbed[0] == 0;
            }

            int numOfContinuesZero = 0;

            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                    numOfContinuesZero++;
                else
                    numOfContinuesZero = 0;

                if (numOfContinuesZero == 3)
                {
                    numOfContinuesZero = 1;
                    n--;
                }

                if (i == 1 && numOfContinuesZero == 2)
                {
                    numOfContinuesZero = 1;
                    n--;
                }

                if (i == flowerbed.Length - 1 && numOfContinuesZero == 2)
                {
                    numOfContinuesZero = 1;
                    n--;
                }


                if (n == 0)
                    return true;

            }

            return false;
        }

    }
}
