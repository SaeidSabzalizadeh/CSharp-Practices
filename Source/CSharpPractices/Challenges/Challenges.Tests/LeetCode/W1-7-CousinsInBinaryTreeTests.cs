using Challenges.Library.LeetCode;
using Challenges.Library.LeetCode.Common;
using System;
using System.Collections.Generic;
using Xunit;

namespace Challenges.Tests.LeetCode
{
    public class CousinsInBinaryTreeTests
    {

        //[Fact]
        //public void ValidMajorityElement()
        //{
        //    List<Tuple<TreeNode, int, int, bool, string>> sampleNodes = GetSampleNodes();

        //    foreach (var item in sampleNodes)
        //    {
        //        var result = CousinsInBinaryTree.IsCousins(item.Item1, item.Item2, item.Item3);
        //        Assert.True(result == item.Item4, $"{nameof(CousinsInBinaryTree.IsCousinsII_GetAllLevels)} does not meet the expected. Solution result is '{result}' but expected is '{item.Item4}' for: '[{item.Item5}] | x={item.Item2}, y={item.Item3}'");

        //    }
        //}


        [Fact]
        public void ValidCousinsInBinaryTree_GetAllLevels()
        {
            List<Tuple<TreeNode, int, int, bool, string>> sampleNodes = GetSampleNodes();

            foreach (var item in sampleNodes)
            {
                var result = CousinsInBinaryTree.IsCousinsII_GetAllLevels(item.Item1, item.Item2, item.Item3);
                Assert.True(result == item.Item4, $"{nameof(CousinsInBinaryTree.IsCousinsII_GetAllLevels)} does not meet the expected. Solution result is '{result}' but expected is '{item.Item4}' for: '[{item.Item5}] | x={item.Item2}, y={item.Item3}'");

            }
        }

        [Fact]
        public void ValidCousinsInBinaryTree_LeetCodeBest()
        {
            List<Tuple<TreeNode, int, int, bool, string>> sampleNodes = GetSampleNodes();

            foreach (var item in sampleNodes)
            {
                var result = CousinsInBinaryTree.IsCousins_LeetCodeBest(item.Item1, item.Item2, item.Item3);
                Assert.True(result == item.Item4, $"{nameof(CousinsInBinaryTree.IsCousins_LeetCodeBest)} does not meet the expected. Solution result is '{result}' but expected is '{item.Item4}' for: '[{item.Item5}] | x={item.Item2}, y={item.Item3}'");

            }
        }


        private List<Tuple<TreeNode, int, int, bool, string>> GetSampleNodes()
        {
            List<Tuple<TreeNode, int, int, bool, string>> samples = new List<Tuple<TreeNode, int, int, bool, string>>();

            //root = [1,2,3,4], x = 4, y = 3, false
            //root = [1,2,3,null,4,null,5], x = 5, y = 4, true
            //root = [1,2,3,null,4], x = 2, y = 3, false
            //root = [1,3,2,null,null,7,4,null,null,5,6,null,8,null,9] x=  8 y= 9, true
            //root = [10,1,2,3,4,5,6], x= 4, y = 5, true


            TreeNode node1 = new TreeNode()
            {
                val = 1,
                left = new TreeNode() { val = 2, left = new TreeNode() { val = 4 } },
                right = new TreeNode() { val = 3 }
            };

            TreeNode node2 = new TreeNode()
            {
                val = 1,
                left = new TreeNode() { val = 2, left = null, right = new TreeNode() { val = 4 } },
                right = new TreeNode() { val = 3, left = null, right = new TreeNode() { val = 5 } }
            };


            TreeNode node3 = new TreeNode()
            {
                val = 1,
                left = new TreeNode() { val = 2, right = new TreeNode() { val = 4 } },
                right = new TreeNode() { val = 3 }
            };

            TreeNode node4 = new TreeNode(1)
            {
                left = new TreeNode(3),
                right = new TreeNode(2)
                {
                    left = new TreeNode(7),
                    right = new TreeNode(4)
                    {
                        left = new TreeNode(5) { right = new TreeNode(8) },
                        right = new TreeNode(6) { right = new TreeNode(9) },
                    }
                }
            };

            TreeNode node5 = new TreeNode(0)
            {
                left = new TreeNode(1, left: new TreeNode(3), right: new TreeNode(4)),
                right = new TreeNode(2, left: new TreeNode(5), right: new TreeNode(6)),

            };


            samples.Add(new Tuple<TreeNode, int, int, bool, string>(node1, 4, 3, false, "node1"));
            samples.Add(new Tuple<TreeNode, int, int, bool, string>(node2, 5, 4, true, "node2"));
            samples.Add(new Tuple<TreeNode, int, int, bool, string>(node3, 2, 3, false, "node3"));
            samples.Add(new Tuple<TreeNode, int, int, bool, string>(node4, 8, 9, true, "node4"));
            samples.Add(new Tuple<TreeNode, int, int, bool, string>(node4, 5, 9, false, "node4"));
            samples.Add(new Tuple<TreeNode, int, int, bool, string>(node4, 5, 6, false, "node4"));
            samples.Add(new Tuple<TreeNode, int, int, bool, string>(node4, 4, 5, false, "node4"));
            samples.Add(new Tuple<TreeNode, int, int, bool, string>(node4, 3, 4, false, "node4"));
            samples.Add(new Tuple<TreeNode, int, int, bool, string>(node5, 4, 5, true, "node5"));
            samples.Add(new Tuple<TreeNode, int, int, bool, string>(node5, 3, 6, true, "node5"));
            samples.Add(new Tuple<TreeNode, int, int, bool, string>(node5, 3, 5, true, "node5"));
            samples.Add(new Tuple<TreeNode, int, int, bool, string>(node5, 4, 6, true, "node5"));
            samples.Add(new Tuple<TreeNode, int, int, bool, string>(node5, 5, 6, false, "node5"));

            return samples;
        }
    }
}
