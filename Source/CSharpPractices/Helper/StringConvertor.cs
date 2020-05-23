using System.Linq;

namespace Helper
{
    public class StringConvertor
    {

        public static int[][] ToIntMatrix(string str)
        {
            string[] rows = str.Split('-').ToArray();
            int[][] points = new int[rows.Length][];

            for (int i = 0; i < rows.Length; i++)
            {
                points[i] = rows[i].Trim().Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            }

            return points;
        }
    }
}
