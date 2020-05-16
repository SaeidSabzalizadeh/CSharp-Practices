using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;

namespace InterviewQuestions
{
    public class IncreasingSubsequence
    {

        public static void Run()
        {
            int[] array = new int[] { 1, 4, 3 };
            Console.WriteLine("Max is {0} - shouldbe (2)", findLIS2(array));

            int[] array2 = new int[] { 1, 4, 5, 2, 6 };
            Console.WriteLine("Max is {0} - shouldbe (4)", findLIS2(array2));


            int[] array3 = new int[] { 5, 4, 3, 5, 6, 7, 1 };
            Console.WriteLine("Max is {0} - shouldbe (4)", findLIS2(array3));
        }

        public static int findLIS(int[] s)
        {
            List<List<int>> allSubs = new List<List<int>>();

            int lastFindedIndex = 0;

            while (lastFindedIndex < s.Length - 1)
            {
                List<int> subs = new List<int>();
                int subsIndex = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    if (subs.Count == 0)
                    {
                        subs.Add(s[i]);
                        continue;
                    }

                    if (subs[subsIndex] < s[i])
                    {
                        subs.Add(s[i]);
                        subsIndex++;
                        lastFindedIndex = i;
                    }
                }

                allSubs.Add(subs);
            }


            var maxLength = allSubs.Max(x => x.Count);

            return maxLength;


        }


        public static int findLIS2(int[] s)
        {
            List<List<int>> allSubs = new List<List<int>>();
            List<string> StartEnd = new List<string>();

            int lastFindedIndex = -1;
            int startIndex = 0;

            while (lastFindedIndex < s.Length - 1 && startIndex < s.Length)
            {
                List<int> subs = new List<int>();
                int subsIndex = 0;
                int firstStartIndex = -1;
                int currentlastFindedIndex = -1;

                for (int i = startIndex; i < s.Length; i++)
                {

                    if (lastFindedIndex >= 0 && lastFindedIndex == i)
                        continue;

                    if (subs.Count == 0)
                    {
                        subs.Add(s[i]);
                        currentlastFindedIndex = i;
                        if (firstStartIndex == -1)
                            firstStartIndex = i;
                        continue;
                    }

                    if (subs[subsIndex] < s[i])
                    {
                        subs.Add(s[i]);
                        subsIndex++;
                        currentlastFindedIndex = i;
                        if (firstStartIndex == -1)
                            firstStartIndex = i;
                    }
                }

                
              

                lastFindedIndex = currentlastFindedIndex;
                allSubs.Add(subs);

                string firstEnd = $"{firstStartIndex}{currentlastFindedIndex}";
                if (StartEnd.Contains(firstEnd))
                {
                    startIndex++;
                    lastFindedIndex = 0;
                }
                else
                    StartEnd.Add(firstEnd);

            }


            var maxLength = allSubs.Max(x => x.Count);

            return maxLength;


        }


        public static int FindLIS(int[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {


                }

            }

            return 0;
        }



    }
}
