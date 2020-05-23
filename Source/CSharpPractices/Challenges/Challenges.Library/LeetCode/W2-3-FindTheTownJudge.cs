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

                        if(trust[k][0] == i)
                        {
                            nextCandidate = true;
                            break;
                        }

                        if(trust[k][1] == i)
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


    }
}
