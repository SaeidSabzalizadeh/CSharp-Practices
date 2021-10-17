using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Common
{
    public class Helper
    {
        public static string ToString(TreeNode node)
        {
            Dictionary<int, List<int?>> levels = GetLevels(node);
            string str = $"[{levels[0].FirstOrDefault()?.ToString() ?? "null" }";
            foreach (var item in levels)
            {
                if (item.Key == 0)
                    continue;

                foreach (var value in item.Value)
                {
                    str = $"{str},{value?.ToString() ?? "null"}";
                }
            }

            str = $"{str}]";
            return str;
        }

        public static Dictionary<int, List<int?>> GetLevels(TreeNode root)
        {
            Dictionary<int, List<int?>> levels = new Dictionary<int, List<int?>>();
            GetLevels(root, levels, 0);


            foreach (var item in levels)
            {
                if (!item.Value.Any(x => x.HasValue))
                    levels.Remove(item.Key);
            }

            return levels;
        }

        private static void GetLevels(TreeNode node, Dictionary<int, List<int?>> levelValues, int level)
        {

            if (levelValues == null)
                levelValues = new Dictionary<int, List<int?>>();

            if (!levelValues.ContainsKey(level))
                levelValues.Add(level, new List<int?>());

            if (node == null)
            {
                levelValues[level].Add(null);
                return;
            }

            levelValues[level].Add(node.val);

            GetLevels(node.left, levelValues, level + 1);
            GetLevels(node.right, levelValues, level + 1);

        }

        public static bool IsEqual(int[] firstArray, int[] secondArray)
        {
            if (firstArray == null && secondArray != null)
                return false;

            if (secondArray == null && firstArray != null)
                return false;

            if (firstArray.Length != secondArray.Length)
                return false;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                    return false;
            }

            return true;
        }

    }
}