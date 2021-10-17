using LeetCode.Common;

namespace Challenges.LeetCode.May
{
    public class OddEvenLinkedList
    {
        /*
         Given a singly linked list, group all odd nodes together followed by the even nodes. Please note here we are talking about the node number and not the value in the nodes.
        You should try to do it in place. The program should run in O(1) space complexity and O(nodes) time complexity.

        Constraints:

            The relative order inside both the even and odd groups should remain as it was in the input.
            The first node is considered odd, the second node even and so on ...
            The length of the linked list is between [0, 10^4].


        Input: 1->2->3->4->5->NULL
        Output: 1->3->5->2->4->NULL

        Input: 2->1->3->5->6->4->7->NULL
        Output: 2->3->6->7->1->5->4->NULL

         
         */

        public static ListNode OddEvenList_LeetCodeBest(ListNode head)
        {
            if (head == null) return null;

            var odd = head;
            var even = head.next;
            var head2 = even;

            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }

            odd.next = head2;

            return head;
        }

        public static ListNode OddEvenList(ListNode head)
        {
            if (head == null)
                return head;

            ListNode oddNodeHead = null;
            ListNode evenNodeHead = null;

            ListNode currentOddNode = null;
            ListNode currentEvenNode = null;

            ListNode currenNode = head;
            int index = 0;
            int lastIndex = 0;

            while (currenNode != null)
            {
                lastIndex++;
                index++;

                if (index % 2 == 0)
                {
                    if (index == 2)
                    {
                        evenNodeHead = new ListNode(currenNode.val);
                        currentEvenNode = evenNodeHead;
                    }
                    else
                    {
                        currentEvenNode.next = new ListNode(currenNode.val);
                        currentEvenNode = currentEvenNode.next;
                    }

                }
                else
                {
                    if (index == 1)
                    {
                        oddNodeHead = new ListNode(currenNode.val);
                        currentOddNode = oddNodeHead;
                    }
                    else
                    {
                        currentOddNode.next = new ListNode(currenNode.val);
                        currentOddNode = currentOddNode.next;
                    }


                }

                currenNode = currenNode.next;
            }

            currentOddNode.next = evenNodeHead;

            return oddNodeHead;


        }
    }
}
