using Challenges.Library.LeetCode.Common;

namespace Challenges.Library.LeetCode
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

        public static TreeNode BstFromPreorder(int[] preorder)
        {
            TreeNode root = new TreeNode();
            root.val = preorder[0];
            TreeNode parent = null;

            TreeNode current = root;
            for (int i = 1; i < preorder.Length; i++)
            {
                if (preorder[i] > current.val && preorder[i] > parent.val)
                {
                    current.right = new TreeNode(preorder[i]);
                    parent = current;
                    current = current.right;

                }
                else if (preorder[i] < current.val && preorder[i] < parent.val)
                {
                    current.left = new TreeNode(preorder[i]);
                    parent = current;
                    current = current.left;
                }

                //else if (preorder[i] > parent.val)



            }

            return root;
        }





    }
}
