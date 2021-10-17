using System.Collections.Generic;

namespace LeetCode.Common
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

        public TreeNode ConstructTreeFromPreOrder(int[] preorder)
        {
            return ConstructTreeFromPreOrder(preorder, int.MinValue, int.MaxValue);
        }

        public int[] PreOrderTraverse()
        {
            List<int> preOrderValues = new List<int>();
            PreOrderTraverse(preOrderValues, val, left, right);

            return preOrderValues.ToArray();

        }





        private void PreOrderTraverse(List<int> preOrderValues, int val, TreeNode left, TreeNode right)
        {
            preOrderValues.Add(val);

            if (left != null)
                PreOrderTraverse(preOrderValues, left.val, left.left, left.right);

            if (right != null)
                PreOrderTraverse(preOrderValues, right.val, right.left, right.right);
        }

        private int preOrderTraverseIndex = 0;
        private TreeNode ConstructTreeFromPreOrder(int[] preorder, int min, int max)
        {
            // Base case
            if (preOrderTraverseIndex >= preorder.Length)
                return null;

            int key = preorder[preOrderTraverseIndex];

            // If current element of preorder[] is in range, then only it is part of current subtree
            if (key <= min || key >= max)
                return null;

            // Allocate memory for root of this subtree and increment index
            TreeNode root = new TreeNode(key);
            preOrderTraverseIndex++;

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
