using LeetCode.Common;
using Problems.LeetCode.Medium;
using Xunit;

namespace Problems.LeetCode.Tests.All
{
    public class N1008_Const_Binary_Search_Tree_Pre_TravTests
    {
        [Theory]
        [InlineData("[8,5,1,7,10,12]", "[8,5,10,1,7,null,12]")]
        public void Test1(string preOrderArrayStr, string bstNodeFirstArrayStr)
        {
            int[] preOrderTreeValues = Helper.GetIntArray(preOrderArrayStr);
            TreeNode root = new N1008_Const_Binary_Search_Tree_Pre_Trav().BstFromPreorder(preOrderTreeValues);

            int[] newTreenodePreOrder = root.PreOrderTraverse();

            Assert.True(Helper.IsEqual(preOrderTreeValues, newTreenodePreOrder), "returnedTreeNodeIsNotValid");

        }
    }
}
