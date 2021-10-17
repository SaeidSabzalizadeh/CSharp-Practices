using LeetCode.Common;

namespace Problems.LeetCode.Medium
{

    /// <summary>
    /// 
    /// 1008. Construct Binary Search Tree from Preorder Traversal
    /// 
    /// 
    /// Given an array of integers preorder, which represents the preorder traversal of a BST (i.e., binary search tree), 
    /// construct the tree and return its root.
    /// 
    /// It is guaranteed that there is always possible to find a binary search tree with the given requirements for the given test cases.
    /// 
    /// A binary search tree is a binary tree where for every node, any descendant of Node.left has a value strictly less than Node.val, 
    /// and any descendant of Node.right has a value strictly greater than Node.val.
    /// 
    /// A preorder traversal of a binary tree displays the value of the node first, then traverses Node.left, then traverses Node.right.
    /// 
    /// Input: preorder = [8,5,1,7,10,12]
    /// Output: [8,5,10,1,7,null,12]
    /// 
    /// Input: preorder = [1,3]
    /// Output: [1,null,3]
    /// 
    /// 
    /// Constraints:
    /// 1 <= preorder.length <= 100
    /// 1 <= preorder[i] <= 10^8
    /// All the values of preorder are unique.
    /// 
    /// 
    /// https://leetcode.com/problems/construct-binary-search-tree-from-preorder-traversal/
    /// 
    /// </summary>
    public class N1008_Const_Binary_Search_Tree_Pre_Trav
    {

        int index = 0;

        public TreeNode BstFromPreorder(int[] preorder)
        {
            if (preorder == null || preorder.Length == 0)
                return null;

            int size = preorder.Length;
            TreeNode root = ConstructTreeFromPreOrder(preorder, int.MinValue, int.MaxValue);
            return root;
        }

        private TreeNode ConstructTreeFromPreOrder(int[] preorder, int min, int max)
        {
            // Base case
            if (index >= preorder.Length)
                return null;

            int key = preorder[index];

            // If current element of preorder[] is in range, then only it is part of current subtree
            if (key <= min || key >= max)
                return null;

            // Allocate memory for root of this subtree and increment index
            TreeNode root = new TreeNode(key);
            index++;

            // All nodes which are in range {min .. key} will go in left subtree,
            // and first such node will be root of left subtree.
            root.left = ConstructTreeFromPreOrder(preorder, min, key);

            // All nodes which are in range {key..max} will go in right subtree,
            // and first such node will be root of right subtree.
            root.right = ConstructTreeFromPreOrder(preorder, key, max);

            return root;
        }

    }
}
