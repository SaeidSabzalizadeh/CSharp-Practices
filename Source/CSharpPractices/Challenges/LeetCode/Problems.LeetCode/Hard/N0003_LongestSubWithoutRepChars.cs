namespace Problems.LeetCode.Hard
{
    public class N0003_LongestSubWithoutRepChars
    {

        /// <summary>
        /// Given a string s, find the length of the longest substring without repeating characters.
        /// 
        /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            char[] chars = new char[input.Length];
            int maxLength = 0;
            int index = 0;
            int firstIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                chars[index] = input[i];

                if (index > 0)
                {
                    for (int j = firstIndex; j < index; j++)
                    {
                        if (chars[index] == chars[j])
                        {
                            //if(index == j + 1)
                            //{
                            //    index = 0;
                            //    chars[index] = chars[j];
                            //    break;
                            //}


                            firstIndex = j + 1;
                            break;
                        }
                    }
                }

                index++;

                if (index - firstIndex > maxLength)
                    maxLength = index - firstIndex;
            }

            return maxLength;

        }

    }
}
