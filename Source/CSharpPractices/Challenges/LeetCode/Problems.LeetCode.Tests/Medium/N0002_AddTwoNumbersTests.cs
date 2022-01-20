using LeetCode.Common;
using Problems.LeetCode.Medium;
using Xunit;

namespace Problems.LeetCode.Tests.Medium
{
    public class N0002_AddTwoNumbersTests
    {

        [Theory]
        [InlineData("{ 2, 4, 3 }", "{ 5, 6, 4 }", "{ 7, 0, 8 }")]
        [InlineData("{ 9,9,9,9,9,9,9 }", "{9,9,9,9}", "{8,9,9,9,0,0,0,1}")]
        public void Test1(string array1Str, string array2Str, string arrayExpectedStr)
        {
            int[] l1Values = Helper.GetIntArray(array1Str);
            ListNode l1 = ListNode.GetListNode(l1Values);

            int[] l2Values = Helper.GetIntArray(array2Str);
            ListNode l2 = ListNode.GetListNode(l2Values);

            int[] expectedValues = Helper.GetIntArray(arrayExpectedStr);
            ListNode expectedResult = ListNode.GetListNode(expectedValues);

            ListNode result = N0002_AddTwoNumbers.Solution(l1, l2);

            bool isExpected = result.EqualsToValues(expectedValues);

            Assert.True(isExpected, $"result is not as expected. Actual: {result} - Expected: {expectedResult}");

        }

    }
}
