using LeetCode.Common;

namespace Problems.LeetCode.Easy
{

    /// <summary>
    /// Given the root of a binary tree, invert the tree, and return its root.
    /// 
    /// 
    /// Input: root = [4,2,7,1,3,6,9]
    /// Output: [4,7,2,9,6,3,1]
    /// 
    /// 
    /// Input: root = [2,1,3]
    /// Output: [2,3,1]
    /// 
    /// 
    /// Input: root = []
    /// Output: []
    /// 
    /// 
    /// The number of nodes in the tree is in the range [0, 100].
    /// -100 <= Node.val <= 100
    /// 
    /// https://leetcode.com/problems/invert-binary-tree/
    /// </summary>
    public class N0226_InvertBinaryTree
    {

        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            TreeNode invertedRoot = new TreeNode(root.val);
            invertedRoot.left = InvertTree(root.right);
            invertedRoot.right = InvertTree(root.left);

            return invertedRoot;

        }
    }
}
