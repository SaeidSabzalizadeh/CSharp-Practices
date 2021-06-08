using Problems.LeetCode.Common;
using Problems.LeetCode.Medium;
using Xunit;

namespace Problems.LeetCode.Tests.All
{
    public class AddTwoNumbersTests
    {

        [Theory]
        [InlineData("{ 2, 4, 3 }", "{ 5, 6, 4 }", "{ 7, 0, 8 }")]
        [InlineData("{ 9,9,9,9,9,9,9 }", "{9,9,9,9}", "{8,9,9,9,0,0,0,1}")]
        public void Test1(string array1Str, string array2Str, string arrayExpectedStr)
        {
            int[] l1Values = Helper.GetArray(array1Str);
            ListNode l1 = ListNode.GetListNode(l1Values);

            int[] l2Values = Helper.GetArray(array2Str);
            ListNode l2 = ListNode.GetListNode(l2Values);

            int[] expectedValues = Helper.GetArray(arrayExpectedStr);
            ListNode expectedResult = ListNode.GetListNode(expectedValues);

            ListNode result = AddTwoNumbers.Solution(l1, l2);

            bool isExpected = result.EqualsToValues(expectedValues);

            Assert.True(isExpected, $"result is not as expected. Actual: {result} - Expected: {expectedResult}");

        }

    }
}
