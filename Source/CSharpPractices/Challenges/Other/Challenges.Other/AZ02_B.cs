namespace Challenges.Other
{
    public class AZ02_B
    {

        public static bool CheckPattern(string pattern)
        {
            return IsValidPattern( pattern, 0);
        }

        private static bool IsValidPattern(string pattern, int startIndex)
        {
            if (string.IsNullOrEmpty(pattern))
                return true;

            if (pattern.Length % 2 != 0)
                return false;

            if (pattern.Length < startIndex + 2)
                return false;


            if (pattern[startIndex] == pattern[startIndex + 1])
            {
                if (pattern.Length > startIndex + 2)
                    pattern = pattern.Substring(0, startIndex) + pattern.Substring(startIndex + 2);
                else
                    pattern = pattern.Substring(0, startIndex);


                if (startIndex > 0)
                    return IsValidPattern(pattern, startIndex - 1);
                else
                    return IsValidPattern(pattern, startIndex);
            }

            return IsValidPattern(pattern, startIndex + 1);

        }
        

    }
}
