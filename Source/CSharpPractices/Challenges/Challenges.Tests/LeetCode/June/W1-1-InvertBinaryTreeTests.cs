using Challenges.Library.LeetCode.Common;
using Xunit;

namespace Challenges.Tests.LeetCode.June
{
    public class InvertBinaryTreeTests
    {
        [Fact]
        public void ValidInvertBinaryTree()
        {
            TreeNode root = GetSampleNode();
            TreeNode invertRoot = GetSampleInvertNode();

            TreeNode result =  Library.LeetCode.June.InvertBinaryTree.InvertTree(root);
            Assert.True(result.IsEqual(invertRoot), $"{nameof(Library.LeetCode.June.InvertBinaryTree.InvertTree)} does not meet the expected. Solution result is '{result}' but expected is '{invertRoot}' for: '{root}'");
        }

       

        private  TreeNode GetSampleNode()
        {
            TreeNode node = new TreeNode()
            {
                val = 4,
                left = new TreeNode() { val = 2, left = new TreeNode() { val = 1 }, right = new TreeNode() { val = 3 } },
                right = new TreeNode() { val = 7, left = new TreeNode() { val = 6 }, right = new TreeNode() { val = 9 } },
            };

            return node;

        }

        private TreeNode GetSampleInvertNode()
        {
            TreeNode node = new TreeNode()
            {
                val = 4,
                left = new TreeNode() { val = 7, left = new TreeNode() { val = 9 }, right = new TreeNode() { val = 6 } },
                right = new TreeNode() { val = 2, left = new TreeNode() { val = 3 }, right = new TreeNode() { val = 1 } },
            };

            return node;
        }

    }
}
