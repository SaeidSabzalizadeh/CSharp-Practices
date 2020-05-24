using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges.Library.LeetCode
{
    /*
     You're given strings J representing the types of stones that are jewels, and S representing the stones you have.  Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.
     The letters in J are guaranteed distinct, and all characters in J and S are letters. Letters are case sensitive, so "a" is considered a different type of stone from "A".

        Example 1:
        Input: J = "aA", S = "aAAbbbb"
        Output: 3

        Example 2:
        Input: J = "z", S = "ZZ"
        Output: 0

        S and J will consist of letters and have length at most 50.
        The characters in J are distinct.


     */
    public class JewelsAndStones
    {

        public static void Run()
        {
            Helper.Base.Start(typeof(JewelsAndStones));
            //const int leftPadLength = 40;

            //string ransomNote = "a";
            //string magazine = "b";
            //Helper.Base.AddItem($"ransomNote: '{ransomNote}', magazine: '{magazine}' > ", $"CanConstruct: {CanConstruct(ransomNote, magazine)}", leftPadLength);

            //ransomNote = "aa";
            //magazine = "ab";
            //Helper.Base.AddItem($"ransomNote: '{ransomNote}', magazine: '{magazine}' > ", $"CanConstruct: {CanConstruct(ransomNote, magazine)}", leftPadLength);

            //ransomNote = "aa";
            //magazine = "aab";
            //Helper.Base.AddItem($"ransomNote: '{ransomNote}', magazine: '{magazine}' > ", $"CanConstruct: {CanConstruct(ransomNote, magazine)}", leftPadLength);


            //Helper.Base.AddNewSection();
            //double canConstruct1RunTime = Helper.PerformanceProfiler.Check(() => { string a = "aa"; string b = "aab"; bool result = CanConstruct1(a, b); });
            //Helper.Base.AddItem("CanConstruct1: ", canConstruct1RunTime);

            //double canConstruct2RunTime = Helper.PerformanceProfiler.Check(() => { string a = "aa"; string b = "aab"; bool result = CanConstruct2(a, b); });
            //Helper.Base.AddItem("CanConstruct2: ", canConstruct2RunTime);

            string j = "aA";
            string s = "aAAbbbb";

            Helper.PerformanceProfiler.Compare(new Dictionary<string, Action>()
            {
                { nameof(NumJewelsInStones), () => { int result = NumJewelsInStones(j, s); } },
                { nameof(NumJewelsInStones_LeetCodeBest), () => { int result = NumJewelsInStones_LeetCodeBest(j, s); } },
            });


            Helper.Base.End(typeof(JewelsAndStones));


        }


        public static int NumJewelsInStones(string J, string S)
        {
            int jewels = 0;
            char[] jArray = J.ToCharArray();

            for (int i = 0; i < S.Length; i++)
            {
                if (jArray.Contains(S[i]))
                    jewels++;
            }

            return jewels;
        }


        public static int NumJewelsInStones_LeetCodeBest(string J, string S)
        {

            int count = 0;
            foreach (char a in J)
            {
                foreach (char b in S)
                {
                    if (a == b)
                    {
                        count++;
                    }

                }
            }
            return count;
        }


    }
}
