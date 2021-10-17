using LeetCode.Common;

namespace Problems.LeetCode.Medium
{

    /// <summary>
    /// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
    /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    /// 
    /// https://leetcode.com/problems/add-two-numbers/
    /// </summary>
    public class N0002_AddTwoNumbers
    {

        public static ListNode Solution(ListNode l1, ListNode l2)
        {

            if (l1 == null || l2 == null)
                return null;


            ListNode l1Current = l1;
            ListNode l2Current = l2;

            ListNode firstNode = new ListNode();
            ListNode currentNode = firstNode;
            ListNode lastCurrentNode = null;

            int currentL1Value;
            int currentL2Value;
            int reminder = 0;
            int currentVal = -1;

            while (l1Current != null || l2Current != null)
            {
                if (l1Current == null)
                    currentL1Value = 0;
                else
                    currentL1Value = l1Current.val;

                if (l2Current == null)
                    currentL2Value = 0;
                else
                    currentL2Value = l2Current.val;


                int sum = currentL1Value + currentL2Value + reminder;
                currentVal = sum % 10;

                reminder = 0;
                while (sum > 9)
                {
                    sum = sum / 10;
                    reminder++;
                }


                currentNode.val = currentVal;
                currentNode.next = new ListNode();
                lastCurrentNode = currentNode;
                currentNode = currentNode.next;

                if (l1Current != null)
                    l1Current = l1Current.next;

                if (l2Current != null)
                    l2Current = l2Current.next;
            }

            if (reminder > 0)
                currentNode.val = reminder;
            else
                lastCurrentNode.next = null;

            return firstNode;
        }
    }
}
