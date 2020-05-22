using System;
using System.Collections.Generic;

namespace Challenges.Library.LeetCode
{
    public class CousinsInBinaryTree
    {
        /*
            In a binary tree, the root node is at depth 0, and children of each depth k node are at depth k+1.
            Two nodes of a binary tree are cousins if they have the same depth, but have different parents.
            We are given the root of a binary tree with unique values, and the values x and y of two different nodes in the tree.
            Return true if and only if the nodes corresponding to the values x and y are cousins.

        */

        static int maxLevel = 15;
        static int currentValue = 0;
        public static void Run()
        {
            Helper.Base.Start(typeof(CousinsInBinaryTree));

            TreeNode root = new TreeNode(0, new TreeNode(), new TreeNode());
            SetNode(0, root);

            //var levels = root2.GetLevels();

            //foreach (var item in levels)
            //{
            //    Console.WriteLine($"{string.Join(", ", item.Value)}");
            //}

            Helper.Base.AddNewSection("Perfoormance Check:");
            Helper.PerformanceProfiler.Compare(new Dictionary<string, Action>()
            {
                {"IsCousins:", ()=>{ _ =IsCousins(root, 2096621, 2097160); } },
                {"IsCousinsII_GetAllLevels:", ()=>{ _ =IsCousinsII_GetAllLevels(root, 2096621, 2097160); } }

            }, 600);


            Helper.Base.End(typeof(CousinsInBinaryTree));

        }

        private static void SetNode(int level, TreeNode currentNode)
        {
            level++;
            currentValue++;
            currentNode.val = currentValue;

            if (level == maxLevel + 1)
                return;

            currentNode.left = new TreeNode();
            currentNode.right = new TreeNode();

            SetNode(level, currentNode.left);
            SetNode(level, currentNode.right);
        }



        public static bool IsCousins(TreeNode root, int x, int y)
        {

            if (root?.val == x || root?.val == y)
                return false;

            if (root?.left?.val == x && root?.right?.val == y)
                return false;

            if (root?.left?.val == y && root?.right?.val == x)
                return false;


            int leftNodeLevel = NodeLevel(root.left, x, 1);
            int rightNodeLevel = NodeLevel(root.right, y, 1);

            if (leftNodeLevel == rightNodeLevel && leftNodeLevel != -1)
                return true;

            leftNodeLevel = NodeLevel(root.left, y, 1);
            rightNodeLevel = NodeLevel(root.right, x, 1);

            if (leftNodeLevel == rightNodeLevel && leftNodeLevel != -1)
                return true;

            return false;
        }

        private static int NodeLevel(TreeNode root, int x, int currentLevel)
        {
            if (root == null)
                return -1;

            if (root.val == x)
                return currentLevel;

            int leftNodeLevel = NodeLevel(root.left, x, currentLevel + 1);
            if (leftNodeLevel > -1)
                return leftNodeLevel;

            int rightNodeLevel = NodeLevel(root.right, x, currentLevel + 1);
            if (rightNodeLevel > -1)
                return rightNodeLevel;

            return -1;

        }


        public static bool IsCousinsII_GetAllLevels(TreeNode root, int x, int y)
        {
            var levels = GetLevels(root);

            foreach (var item in levels)
            {
                if (item.Value != null && item.Value.Contains(x) && item.Value.Contains(y))
                {
                    int xIndex = item.Value.IndexOf(x);
                    int yIndex = item.Value.IndexOf(y);

                    if (yIndex < xIndex)
                    {
                        int temp = xIndex;
                        xIndex = yIndex;
                        yIndex = temp;
                    }

                    if (yIndex - xIndex > 1)
                        return true;

                    return yIndex % 2 == 0;
                }
            }

            return false;
        }

        private static Dictionary<int, List<int>> GetLevels(TreeNode root)
        {
            Dictionary<int, List<int>> levels = new Dictionary<int, List<int>>();
            GetLevels(root, levels, 0);

            return levels;
        }

        private static void GetLevels(TreeNode node, Dictionary<int, List<int>> levelValues, int level)
        {

            if (levelValues == null)
                levelValues = new Dictionary<int, List<int>>();

            if (!levelValues.ContainsKey(level))
                levelValues.Add(level, new List<int>());

            if (node == null)
            {
                levelValues[level].Add(int.MinValue);
                return;
            }

            levelValues[level].Add(node.val);

            GetLevels(node.left, levelValues, level + 1);
            GetLevels(node.right, levelValues, level + 1);

        }





    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public Dictionary<int, List<int>> GetLevels()
        {
            Dictionary<int, List<int>> levels = new Dictionary<int, List<int>>();
            GetLevels(this, levels, 0);

            return levels;
        }

        private void GetLevels(TreeNode node, Dictionary<int, List<int>> levelValues, int level)
        {

            if (levelValues == null)
                levelValues = new Dictionary<int, List<int>>();

            if (!levelValues.ContainsKey(level))
                levelValues.Add(level, new List<int>());

            if (node == null)
            {
                levelValues[level].Add(int.MinValue);
                return;
            }

            levelValues[level].Add(node.val);

            GetLevels(node.left, levelValues, level + 1);
            GetLevels(node.right, levelValues, level + 1);

        }


    }

}
