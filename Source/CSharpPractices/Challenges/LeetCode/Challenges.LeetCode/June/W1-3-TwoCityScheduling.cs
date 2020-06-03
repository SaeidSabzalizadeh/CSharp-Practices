using Helper;
using System;
using System.Collections.Generic;

namespace Challenges.LeetCode.June
{

    /*
     
    There are 2N people a company is planning to interview. The cost of flying the i-th person to city A is costs[i][0], and the cost of flying the i-th person to city B is costs[i][1].
    Return the minimum cost to fly every person to a city such that exactly N people arrive in each city.

    Note:

        1 <= costs.length <= 100
        It is guaranteed that costs.length is even.
        1 <= costs[i][0], costs[i][1] <= 1000


    Example:
    Input: [[10,20],[30,200],[400,50],[30,20]]
    Output: 110
    Explanation: 
    The first person goes to city A for a cost of 10.
    The second person goes to city A for a cost of 30.
    The third person goes to city B for a cost of 50.
    The fourth person goes to city B for a cost of 20.

    The total minimum cost is 10 + 30 + 50 + 20 = 110 to have half the people interviewing in each city.


    [[10,20],[30,200],[12,50],[40,6]]
    //68 (30+12 , 20+6)

     */
    public class TwoCityScheduling
    {

        public static void Run()
        {
            Base.Start(typeof(TwoCityScheduling));

            Random rnd = new Random();

            const int length = 5000;

            int[][] costs = new int[length][];

            for (int i = 0; i < length; i++)
            {
                costs[i] = new int[2] { rnd.Next(1, 1000), rnd.Next(1, 1000) };
            }

            PerformanceProfiler.Compare(new Dictionary<string, Action>()
            {
                {nameof(TwoCitySchedCost_LeetCodeBest), ()=>{ _ = TwoCitySchedCost_LeetCodeBest(costs); } },
                {nameof(TwoCitySchedCost), ()=>{ _ = TwoCitySchedCost(costs); } }

            });


            Base.End(typeof(TwoCityScheduling));

        }



        public static int TwoCitySchedCost_LeetCodeBest(int[][] costs)
        {
            int n = costs.Length;
            Array.Sort(costs, (p, q) => (p[0] - p[1]).CompareTo((q[0] - q[1])));

            int cost = 0;
            for (int i = 0; i < n; ++i)
            {
                if (i < n / 2)
                {
                    cost += costs[i][0];
                }
                else
                {
                    cost += costs[i][1];
                }
            }

            return cost;

        }

        public static int TwoCitySchedCost(int[][] costs)
        {
            if (costs == null || costs.Length == 0 || costs.Length % 2 != 0)
                return -1;

            int[] A = new int[costs.Length];
            int aCount = 0;

            int[] B = new int[costs.Length];
            int bCount = 0;

            int sum = 0;

            for (int i = 0; i < costs.Length; i++)
            {
                if (costs[i][0] < costs[i][1])
                {
                    A[i] = costs[i][0];
                    sum += costs[i][0];
                    aCount++;
                }
                else
                {
                    B[i] = costs[i][1];
                    sum += costs[i][1];
                    bCount++;
                }

            }

            if (aCount == bCount)
                return sum;

            if (aCount > bCount)
                sum = FindMinsAndSum(costs, bCount, sum, A, B, true);
            else
                sum = FindMinsAndSum(costs, aCount, sum, A, B, false);

            return sum;
        }

        private static int FindMinsAndSum(int[][] costs, int count, int sum, int[] A, int[] B, bool aIsLarger)
        {
            int[] existingItems = new int[costs.Length];
            int existingItemsIndex = 0;

            int remain = (costs.Length / 2) - count;

            int[] largerArray = aIsLarger ? A : B;
            int[] smallerArray = aIsLarger ? B : A;
            int largerIndex = aIsLarger ? 1 : 0;
            int smallerIndex = aIsLarger ? 0 : 1;


            for (int i = 0; i < costs.Length; i++)
            {
                if (largerArray[i] > 0)
                {
                    existingItems[existingItemsIndex] = i;
                    existingItemsIndex++;
                }
            }

            while (remain > 0)
            {
                int min = int.MaxValue;
                int minIndex = -1;

                for (int i = 0; i < existingItemsIndex; i++)
                {
                    int costIndex = existingItems[i];

                    if (largerArray[costIndex] == 0)
                        continue;

                    if (costIndex > -1)
                    {
                        if (costs[costIndex][largerIndex] - costs[costIndex][smallerIndex] < min)
                        {
                            min = costs[costIndex][largerIndex] - costs[costIndex][smallerIndex];
                            minIndex = costIndex;
                        }
                    }
                }

                sum -= costs[minIndex][smallerIndex];
                sum += costs[minIndex][largerIndex];

                largerArray[minIndex] = 0;
                smallerArray[minIndex] = costs[minIndex][largerIndex];
                remain--;
            }

            return sum;
        }
    }
}
