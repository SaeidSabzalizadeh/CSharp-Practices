using System;
using System.Collections.Generic;
using System.Linq;

namespace Helper
{
    public class StringConvertor
    {

        public static int[][] ToIntMatrix(string str)
        {
            if (string.IsNullOrEmpty(str))
                return null;

            str = str.Trim();

            if (str[0] == '[')
                return ToIntMatrixWithStandardView(str);

            string[] rows = str.Split('-').ToArray();
            int[][] points = new int[rows.Length][];

            for (int i = 0; i < rows.Length; i++)
            {
                points[i] = rows[i].Trim().Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            }

            return points;
        }

        private static int[][] ToIntMatrixWithStandardView(string str)
        {
            if (string.IsNullOrEmpty(str))
                return null;

            str = str.Trim();

            if (str[0] != '[' || str[str.Length - 1] != ']')
                return null;

            str = str.Substring(1, str.Length - 2).Trim();

            if (str[0] != '[' || str[str.Length - 1] != ']')
                return null;

            List<string> items = new List<string>();

            int startIndex = 0;
            int endIndex = -1;

            while (startIndex >= 0)
            {
                endIndex = str.IndexOf(']', startIndex + 1);

                if (endIndex < 0)
                    throw new Exception("Invalid input");

                items.Add(str.Substring(startIndex + 1, endIndex - startIndex - 1));
                startIndex = str.IndexOf('[', endIndex + 1);
            }

            int[][] points = new int[items.Count][];

            for (int i = 0; i < items.Count; i++)
            {
                points[i] = items[i].Trim().Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            }

            return points;

        }
    }
}
