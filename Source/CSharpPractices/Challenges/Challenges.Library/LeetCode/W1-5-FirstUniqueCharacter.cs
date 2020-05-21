using System;
using System.Collections.Generic;

namespace Challenges.Library.LeetCode
{
    public class FirstUniqueCharacter
    {
        /*
         Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.

            Examples:
            s = "leetcode"
            return 0.

            s = "loveleetcode",
            return 2.

         */

        public static void Run()
        {
            Helper.Base.Start(typeof(FirstUniqueCharacter));

            Helper.PerformanceProfiler.Compare(new Dictionary<string, Action>()
            {
                { "FirstUniqChar", () => { int result = FirstUniqChar("loveleetcode"); } },
                { "FirstUniqCharII", () => { int result = FirstUniqCharII("loveleetcode"); } },
                { "FirstUniqCharIII", () => { int result = FirstUniqCharIII("loveleetcode"); } }
            });

            Helper.Base.End(typeof(FirstUniqueCharacter));
        }

        public static int FirstUniqChar(string s)
        {
            Dictionary<char, Tuple<int, int>> charsFirstIndexCount = new Dictionary<char, Tuple<int, int>>();

            char[] characters = s.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (charsFirstIndexCount.ContainsKey(characters[i]))
                    charsFirstIndexCount[characters[i]] = new Tuple<int, int>(charsFirstIndexCount[characters[i]].Item1, charsFirstIndexCount[characters[i]].Item2 + 1); // count
                else
                    charsFirstIndexCount.Add(characters[i], new Tuple<int, int>(i, 1));
            }

            foreach (var item in charsFirstIndexCount)
            {
                if (item.Value.Item2 == 1)
                    return item.Value.Item1;
            }

            return -1;


        }

        public static int FirstUniqCharII(string s)
        {
            Dictionary<char, int> charsFirstIndex = new Dictionary<char, int>();

            char[] characters = s.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (charsFirstIndex.ContainsKey(characters[i]))
                    charsFirstIndex[characters[i]] = -1;
                else
                    charsFirstIndex.Add(characters[i], i);
            }

            foreach (var item in charsFirstIndex)
            {
                if (item.Value != -1)
                    return item.Value;
            }

            return -1;

        }

        public static int FirstUniqCharIII(string s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                if (s.IndexOf(s[i]) == s.LastIndexOf(s[i]))
                {
                    return i;
                }
            }

            return -1;
        }


    }
}
