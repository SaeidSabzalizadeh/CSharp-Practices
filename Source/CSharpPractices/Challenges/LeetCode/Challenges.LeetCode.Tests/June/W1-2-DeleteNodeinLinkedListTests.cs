using LeetCode.Common;
using Xunit;

namespace Challenges.LeetCode.Tests.June
{
    public class DeleteNodeinLinkedListTests
    {
        [Theory]
        [InlineData("4->5->1->9->NULL", 5, "4->1->9->NULL")]
        [InlineData("4->5->1->9->NULL", 1, "4->5->9->NULL")]
        public void ValidDeleteNodeinLinkedList(string inputStr, int deletedItem, string expectedResultStr)
        {
            ListNode inputListNode = ListNode.Convert(inputStr);
            ListNode expectedResult = ListNode.Convert(expectedResultStr);

            ListNode targetNode = inputListNode;

            while (targetNode?.val != deletedItem)
            {
                targetNode = targetNode.next;
            }

            LeetCode.June.DeleteNodeinLinkedList.DeleteNode(targetNode);
            Assert.True(inputListNode?.ToString() == expectedResult?.ToString(), $"{nameof(LeetCode.June.DeleteNodeinLinkedList.DeleteNode)} does not meet the expected. Solution result is '{inputListNode}' but expected is '{expectedResultStr}' for: '{inputStr}, node={deletedItem}'");
        }

    }
}
