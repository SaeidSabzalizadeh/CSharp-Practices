using Challenges.Library.LeetCode.Common;
using System;

namespace Challenges.Library.LeetCode.May
{
    public class ConstructBinarySearchOfPreorderTraversal
    {
        /*
        Return the root node of a binary search tree that matches the given preorder traversal.
        (Recall that a binary search tree is a binary tree where for every node, any descendant of node.left has a value < node.val, and any descendant of node.right has a value > node.val.  Also recall that a preorder traversal displays the value of the node first, then traverses node.left, then traverses node.right.)
        It's guaranteed that for the given test cases there is always possible to find a binary search tree with the given requirements.

        Constraints:

            1 <= preorder.length <= 100
            1 <= preorder[i] <= 10^8
            The values of preorder are distinct.


        Input: [8,5,1,7,10,12]
        Output: [8,5,10,1,7,null,12]

                    [8]
            [5]         [10]
        [1]     [7]         [12]    

        */

        public static void Run()
        {
            //TreeNode node = new TreeNode(8);
            //node.left = new TreeNode(5);
            //node.right = new TreeNode(10);
            //node.left.left = new TreeNode(1);
            //node.left.right = new TreeNode(7);
            //node.right.left = null;
            //node.right.right = new TreeNode(12);


            TreeNode node = BstFromPreorder(new int[] { 8, 5, 1, 7, 10, 12 });
            string str = Common.Helper.ToString(node);
            Console.ReadLine();

        }

        public static TreeNode BstFromPreorder(int[] preorder)
        {
            TreeNode root = null;
            int index = 0;
            BuildTreeII(root, preorder, ref index);
            return root;
        }

        private static void BuildTree(TreeNode root, int[] preorder, ref int index)
        {
            if (index >= preorder.Length)
                return;

            int item = preorder[index];

            if (item < root.val)
            {
                if (root.left == null)
                {
                    root.left = new TreeNode(item);
                    index++;
                }

                BuildTree(root.left, preorder, ref index);
            }

            if (item > root.val)
            {
                if (root.right == null)
                {
                    root.right = new TreeNode(item);
                    index++;
                }

                BuildTree(root.right, preorder, ref index);
            }

        }


        private static void BuildTreeII(TreeNode root, int[] preorder, ref int index)
        {
            int item = preorder[index];

            if (root == null)
                root = new TreeNode(item);

            index++;
            if (index >= preorder.Length)
                return;

            int nextItem = preorder[index];

            if (nextItem > item)
                BuildTreeII(root.right, preorder, ref index);
            else
                BuildTreeII(root.left, preorder, ref index);

        }
    }
}
