using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges.Library
{
    public class LongestIncreasingSubsequence
    {
        public static void Run()
        {
            Console.WriteLine($"------------ {nameof(LongestIncreasingSubsequence)} ------------");

            int[] array = new int[] { 1, 4, 3 };
            Console.WriteLine("Max is {0} - shouldbe (2)", FindLargestIncreasingSubsequence(array));

            int[] array2 = new int[] { 1, 4, 5, 2, 6 };
            Console.WriteLine("Max is {0} - shouldbe (4)", FindLargestIncreasingSubsequence(array2));


            int[] array3 = new int[] { 5, 4, 3, 5, 6, 7, 1 };
            Console.WriteLine("Max is {0} - shouldbe (4)", FindLargestIncreasingSubsequence(array3));

        }


        public static int FindLargestIncreasingSubsequence(int[] sequence)
        {
            List<List<int>> allSubsequences = new List<List<int>>();

            for (int i = 0; i < sequence.Length; i++)
            {

                List<int> subsequence = new List<int>();
                int subsequenceIndex = -1;

                for (int j = i; j < sequence.Length; j++)
                {
                    var currentItem = sequence[j];
                    if (!subsequence.Contains(currentItem))
                    {
                        if ((subsequenceIndex == -1) || (subsequence[subsequenceIndex] < currentItem))
                        {
                            subsequence.Add(currentItem);
                            subsequenceIndex++;
                        }
                    }
                }

                allSubsequences.Add(subsequence);

            }

            return allSubsequences.Max(x => x.Count);
        }
    }
}
