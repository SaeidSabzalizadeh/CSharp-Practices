using System.Collections.Generic;

namespace Challenges.Library.LeetCode.Common
{
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

        public bool IsEqual(TreeNode node)
        {
            if (node == null)
                return false;

            if (node.val != val)
                return false;

            if (left != null && !left.IsEqual(node.left))
                return false;

            if (right != null && !right.IsEqual(node.right))
                return false;

            if (left == null && node.left != null)
                return false;

            if (right == null && node.right != null)
                return false;

            return true;
        }

        public override string ToString()
        {
            List<int> breadthFirstSearchSortedValues = new List<int>();
            
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(this);
            
            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                breadthFirstSearchSortedValues.Add(currentNode.val);

                if (currentNode.left != null)
                    queue.Enqueue(currentNode.left);

                if (currentNode.right != null)
                    queue.Enqueue(currentNode.right);
            }

            return $"[{string.Join(",", breadthFirstSearchSortedValues)}]";
        }

    }
}
