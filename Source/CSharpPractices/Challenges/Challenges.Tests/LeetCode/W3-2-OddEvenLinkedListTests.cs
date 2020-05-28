using Challenges.Library.LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Challenges.Tests.LeetCode
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

            ListNode result = Library.LeetCode.OddEvenLinkedList.OddEvenList(inputListNode);
            Assert.True(result?.ToString() == expectedResult?.ToString(), $"{nameof(Library.LeetCode.OddEvenLinkedList.OddEvenList)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResultStr}' for: '{inputStr}'");
        }


    }
}
