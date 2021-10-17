using LeetCode.Common;
using Xunit;

namespace Challenges.LeetCode.Tests.Common
{
    public class HelperTests
    {

        [Fact]
        public void ValidToStringTreeNode()
        {
            //Input: [8,5,1,7,10,12]
            //Output: [8,5,10,1,7,null,12]

            TreeNode node = new TreeNode(8);
            node.left = new TreeNode(5);
            node.right = new TreeNode(10);
            node.left.left = new TreeNode(1);
            node.left.right = new TreeNode(7);
            node.right.left = null;
            node.right.right = new TreeNode(12);

            string result = LeetCode.Common.Helper.ToString(node);
            string expectedResult = "[8,5,10,1,7,null,12]";
            Assert.True(result == expectedResult, $"ToStringTreeNode does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}'.");
        }


    }
}
