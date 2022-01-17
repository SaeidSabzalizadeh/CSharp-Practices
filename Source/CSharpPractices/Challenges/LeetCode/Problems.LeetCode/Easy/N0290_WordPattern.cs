using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.LeetCode.Easy
{

    /// <summary>
    /// 
    /// Given a pattern and a string s, find if s follows the same pattern.
    /// Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.
    /// 
    /// Example 1:
    /// Input: pattern = "abba", s = "dog cat cat dog"
    /// Output: true
    /// 
    /// Example 2:
    /// Input: pattern = "abba", s = "dog cat cat fish"
    /// Output: false
    /// 
    /// Example 3:
    /// Input: pattern = "aaaa", s = "dog cat cat dog"
    /// Output: false
    /// 
    /// 1 <= pattern.length <= 300
    /// pattern contains only lower-case English letters.
    /// 1 <= s.length <= 3000
    /// s contains only lowercase English letters and spaces ' '.
    /// s does not contain any leading or trailing spaces.
    /// All the words in s are separated by a single space.
    /// 
    /// 
    /// https://leetcode.com/problems/word-pattern/
    /// </summary>
    public class N0290_WordPattern
    {
        public static bool Solution(string pattern, string s)
        {
            string[] dic = new string[26];
            string[] words = s.Split(new char[] { ' ' });

            if (words.Length != pattern.Length)
                return false;

            pattern = pattern.ToLower();

            for (int i = 0; i < pattern.Length; i++)
            {
                if (dic[pattern[i]-97] == null || dic[pattern[i]-97] == string.Empty)
                {
                    for (int j = 0; j < dic.Length; j++)
                    {
                        if (dic[j] == words[i])
                            return false;
                    }

                    dic[pattern[i]-97] = words[i];
                }

                if (words[i] != dic[pattern[i]-97])
                    return false;

            }

            return true;

        }

    }
}
