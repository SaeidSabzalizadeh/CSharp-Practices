using LeetCode.Common;
using Xunit;

namespace Challenges.LeetCode.Tests.May
{
    public class OddEvenLinkedListTests
    {
        [Theory]
        [InlineData("1->2->3->4->5->NULL", "1->3->5->2->4->NULL")]
        [InlineData("2->1->3->5->6->4->7->NULL", "2->3->6->7->1->5->4->NULL")]
        [InlineData("NULL", "NULL")]
        public void ValidOddEvenLinkedList(string inputStr, string expectedResultStr)
        {
            ListNode inputListNode = ListNode.Convert(inputStr);
            ListNode expectedResult = ListNode.Convert(expectedResultStr);

            ListNode result = LeetCode.May.OddEvenLinkedList.OddEvenList(inputListNode);
            Assert.True(result?.ToString() == expectedResult?.ToString(), $"{nameof(LeetCode.May.OddEvenLinkedList.OddEvenList)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResultStr}' for: '{inputStr}'");
        }

        [Theory]
        [InlineData("1->2->3->4->5->NULL", "1->3->5->2->4->NULL")]
        [InlineData("2->1->3->5->6->4->7->NULL", "2->3->6->7->1->5->4->NULL")]
        [InlineData("NULL", "NULL")]
        public void ValidOddEvenLinkedList_LeetCodeBest(string inputStr, string expectedResultStr)
        {
            ListNode inputListNode = ListNode.Convert(inputStr);
            ListNode expectedResult = ListNode.Convert(expectedResultStr);

            ListNode result = LeetCode.May.OddEvenLinkedList.OddEvenList_LeetCodeBest(inputListNode);
            Assert.True(result?.ToString() == expectedResult?.ToString(), $"{nameof(LeetCode.May.OddEvenLinkedList.OddEvenList_LeetCodeBest)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResultStr}' for: '{inputStr}'");
        }


    }
}
