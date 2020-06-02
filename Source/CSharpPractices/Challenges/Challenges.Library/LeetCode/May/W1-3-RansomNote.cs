using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Challenges.Library.LeetCode.May
{
    /*
        Given an arbitrary ransom note string and another string containing letters from all the magazines, write a function that will return true if the ransom note can be constructed from the magazines ; otherwise, it will return false.
        Each letter in the magazine string can only be used once in your ransom note.

        Example 1:
        Input: ransomNote = "a", magazine = "b"
        Output: false

        Example 2:
        Input: ransomNote = "aa", magazine = "ab"
        Output: false

        Example 3:
        Input: ransomNote = "aa", magazine = "aab"
        Output: true

   */


    public class RansomNote
    {

        public static void Run()
        {
            Helper.Base.Start(typeof(RansomNote));
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

            string a = "aa"; 
            string b = "aab";

            Helper.PerformanceProfiler.Compare(new Dictionary<string, Action>()
            {
                { nameof(CanConstruct1), () => { bool result = CanConstruct1(a, b); } },
                { nameof(CanConstruct2), () => { bool result = CanConstruct2(a, b); } },
                { nameof(CanConstruct_LeetCodeBest), () => { bool result = CanConstruct_LeetCodeBest(a, b); } },
            });


            Helper.Base.End(typeof(RansomNote));


        }

        public static bool CanConstruct1(string ransomNote, string magazine)
        {
            if (string.IsNullOrEmpty(ransomNote))
                return true;

            if (string.IsNullOrEmpty(magazine))
                return false;

            foreach (var character in ransomNote)
            {
                if (!FindAndRemove(character, ref magazine))
                    return false;
            }

            return true;
        }

        public static bool CanConstruct2(string ransomNote, string magazine)
        {
            if (string.IsNullOrEmpty(ransomNote))
                return true;

            if (string.IsNullOrEmpty(magazine))
                return false;

            char[] ransomCharArray = ransomNote.ToCharArray();

            for (int i = 0; i < ransomCharArray.Length; i++)
            {
                if (!FindAndRemove(ransomCharArray[i], ref magazine))
                    return false;
            }

            return true;
        }

        public static bool CanConstruct_LeetCodeBest(string ransomNote, string magazine)
        {
            int[] leters = new int[('z' - 'a') + 1];

            for (int i = 0; i < magazine.Length; i++)
            {
                leters[magazine[i] - 'a']++;
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (--leters[ransomNote[i] - 'a'] < 0)
                    return false;
            }

            return true;
        }


        private static bool FindAndRemove(char character, ref string magazine)
        {
            int index = magazine.IndexOf(character);

            if (index < 0)
                return false;

            magazine = magazine.Remove(index, 1);
            return true;
        }
    }
}
