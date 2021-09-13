namespace Problems.LeetCode.Medium
{

    /// <summary>
    /// 
    /// The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: 
    /// (you may want to display this pattern in a fixed font for better legibility)
    /// 
    /// P   A   H   N
    /// A P L S I I G
    /// Y   I R
    /// 
    /// And then read line by line: "PAHNAPLSIIGYIR"
    /// Write the code that will take a string and make this conversion given a number of rows:
    /// 
    /// https://leetcode.com/problems/zigzag-conversion/
    /// </summary>
    public class N0006_ZigZagConversion
    {

        public static string Solution(string inputStr, int numRows)
        {
            if (string.IsNullOrEmpty(inputStr))
                return null;

            if (numRows <= 0)
                return null;

            if (numRows == 1)
                return inputStr;

            char[][] chars = new char[numRows][];

            for (int i = 0; i < numRows; i++)
            {
                chars[i] = new char[inputStr.Length];
            }

            int currentRow = 0;
            int currentColumn = 0;
            int index = 0;

            while (index < inputStr.Length)
            {
                if (currentRow == 0)
                {
                    while (currentRow < numRows && index < inputStr.Length)
                    {
                        chars[currentRow][currentColumn] = inputStr[index];
                        currentRow++;
                        index++;
                    }
                }

                if (currentRow == numRows)
                {
                    currentRow--;

                    while (currentRow > 1 && index < inputStr.Length)
                    {
                        currentRow--;
                        currentColumn++;
                        chars[currentRow][currentColumn] = inputStr[index];

                        index++;
                    }

                    index--;
                    currentRow = 0;
                    currentColumn++;
                }

                index++;
            }

            string result = "";

            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < chars[i].Length; j++)
                {
                    if (chars[i][j] != '\0')
                        result += chars[i][j];
                }

            }


            return result;

        }
    }
}
