using Helper;
using System;
using System.Collections.Generic;

namespace Challenges.Library.LeetCode
{
    public class FindTheTownJudge
    {

        /*
        
        In a town, there are N people labelled from 1 to N.  There is a rumor that one of these people is secretly the town judge.

        If the town judge exists, then:

        - The town judge trusts nobody.
        - Everybody (except for the town judge) trusts the town judge.
        - There is exactly one person that satisfies properties 1 and 2.
        - You are given trust, an array of pairs trust[i] = [a, b] representing that the person labelled a trusts the person labelled b.

        If the town judge exists and can be identified, return the label of the town judge.  Otherwise, return -1.

        Constraints:

            1 <= N <= 1000
            0 <= trust.length <= 10^4
            trust[i].length == 2
            trust[i] are all different
            trust[i][0] != trust[i][1]
            1 <= trust[i][0], trust[i][1] <= N


        Examples:

        Input: N = 2, trust = [[1,2]]
        Output: 2

        Input: N = 3, trust = [[1,3],[2,3]]
        Output: 3

        Input: N = 3, trust = [[1,3],[2,3],[3,1]]
        Output: -1

        Input: N = 3, trust = [[1,2],[2,3]]
        Output: -1

        Input: N = 4, trust = [[1,3],[1,4],[2,3],[2,4],[4,3]]
        Output: 3


         */



        public static void Run()
        {


            Base.Start(typeof(FindTheTownJudge));

            Test();

            Random rnd = new Random();
            const int N = 500;
            int[][] trust = new int[N * 2][];

            for (int i = 1; i <= N * 2; i++)
            {
                int left = (i <= N) ? i : i / 2;
                int right = (i <= N) ? (N / 2) : rnd.Next(1, N);

                trust[i - 1] = new int[2] { left, right };
            }

            PerformanceProfiler.Compare(new Dictionary<string, Action>()
            {
                {nameof(FindJudge),   ()=>{ int result = FindJudge(N,trust);  } },
                {nameof(FindJudgeII), ()=>{ int result = FindJudgeII(N,trust); } },
                {nameof(FindJudgeIII), ()=>{ int result = FindJudgeIII(N,trust); } },
                {nameof(FindJudge_LeetCodeBest), ()=>{ int result = FindJudge_LeetCodeBest(N,trust); } }
            });


            Base.End(typeof(FindTheTownJudge));
        }

        public static void Test()
        {
            int[][] trust = StringConvertor.ToIntMatrix("1,3-1,4-2,3-2,4-4,3");
            var result = FindJudge_LeetCodeBest(4, trust);
            Console.WriteLine(result);
        }

        public static int FindJudge(int N, int[][] trust)
        {

            int candidate = -1;
            bool nextCandidate = false;
            bool hasTrust = false;

            for (int i = 1; i <= N; i++)
            {
                nextCandidate = false;
                candidate = -1;

                for (int j = 1; j <= N; j++)
                {
                    hasTrust = false;

                    for (int k = 0; k < trust.Length; k++)
                    {

                        if (trust[k][0] != j)
                            continue;

                        if (trust[k][0] == i)
                        {
                            nextCandidate = true;
                            break;
                        }

                        if (trust[k][1] == i)
                        {
                            hasTrust = true;
                            break;
                        }
                    }

                    if (nextCandidate)
                    {
                        candidate = -1;
                        break;
                    }

                    if (!hasTrust)
                        break;

                    candidate = i;

                }

                if (candidate != -1)
                    return candidate;
            }


            return -1;


        }

        public static int FindJudgeII(int N, int[][] trust)
        {

            for (int i = 1; i <= N; i++)
            {
                bool everyOneHasTrust = true;

                for (int j = 1; j <= N; j++)
                {
                    if (i != j && !HasTrust(j, i, trust))
                    {
                        everyOneHasTrust = false;
                        break;
                    }
                }

                if (everyOneHasTrust && HosNotTrustToAnyOne(i, trust))
                    return i;
            }

            return -1;
        }

        public static int FindJudgeIII(int N, int[][] trust)
        {
            for (int i = 1; i <= N; i++)
            {
                bool iHasNotTrustToAnyone = true;
                bool allJsHaveTrustToi = true;

                for (int j = 1; j <= N; j++)
                {
                    if (i == j)
                        continue;

                    bool jHasTrustToi = false;

                    for (int k = 0; k < trust.Length; k++)
                    {
                        if (trust[k][0] == j && trust[k][1] == i)
                        {
                            jHasTrustToi = true;
                        }

                        if (trust[k][0] == i)
                        {
                            iHasNotTrustToAnyone = false;
                            break;
                        }
                    }

                    if (!iHasNotTrustToAnyone)
                        break; //next i


                    if (!jHasTrustToi)
                    {
                        allJsHaveTrustToi = false;
                        break; //next i
                    }
                }


                if (iHasNotTrustToAnyone && allJsHaveTrustToi)
                    return i;


            }

            return -1;
        }

        public static int FindJudge_LeetCodeBest(int N, int[][] trust)
        {
            int[] barr = new int[N];

            //Console.WriteLine();
            for (int i = 0; i < trust.GetLength(0); i++)
            {
                barr[trust[i][0] - 1]--;
                barr[trust[i][1] - 1]++;
            }

            int index = -1;

            for (int i = 0; i < N; i++)
                if (barr[i] == N - 1)
                    index = i;

            return index == -1 ? -1 : index + 1;
        }

        private static bool HosNotTrustToAnyOne(int judgeCandidate, int[][] trust)
        {
            for (int l = 0; l < trust.Length; l++)
            {
                if (trust[l][0] == judgeCandidate)
                    return false;
            }

            return true;
        }

        private static bool HasTrust(int member, int judgeCandidate, int[][] trust)
        {
            for (int k = 0; k < trust.Length; k++)
            {
                if (trust[k][0] == member && trust[k][1] == judgeCandidate)
                    return true;
            }

            return false;
        }
    }
}
