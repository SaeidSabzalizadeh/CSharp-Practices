using Challenges.Library.LeetCode.Common;

namespace Challenges.Library.LeetCode.June
{
    public class InvertBinaryTree
    {
        public static TreeNode InvertTree(TreeNode root)
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
