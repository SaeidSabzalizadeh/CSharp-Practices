using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Common
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode GetListNode(int[] values)
        {
            if (values == null)
                return null;

            ListNode list = new ListNode();
            list.val = values[0];

            if (values.Length == 1)
                return list;

            ListNode currentList = list;

            for (int i = 1; i < values.Length; i++)
            {
                currentList.next = new ListNode(values[i]);
                currentList = currentList.next;
            }

            return list;
        }

        public bool EqualsToValues(int[] values)
        {
            if (values == null)
                return false;

            ListNode current = this;
            for (int i = 0; i < values.Length; i++)
            {
                if (current == null)
                    return false;

                if (current.val != values[i])
                    return false;

                current = current.next;
            }

            if (current != null)
                return false;

            return true;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{ ");
            sb.Append(this.val);

            ListNode currentNode = this.next;

            while (currentNode != null)
            {
                sb.Append(", ");
                sb.Append(currentNode.val);

                currentNode = currentNode.next;
            }

            sb.Append(" }");

            return sb.ToString();


        }

        public static ListNode Convert(string inputStr)
        {
            if (string.IsNullOrEmpty(inputStr))
                return null;

            List<string> strItems = inputStr.Replace("->", ",").Split(',').ToList();

            if (strItems == null || strItems.Count == 0)
                return null;

            ListNode node = null;
            ListNode head = null;

            int parsedValue;

            for (int i = 0; i < strItems.Count; i++)
            {

                if (!int.TryParse(strItems[i], out parsedValue))
                    break;

                if (i == 0)
                {
                    head = new ListNode(parsedValue);
                    node = head;
                }
                else
                {
                    node.next = new ListNode(parsedValue);
                    node = node.next;
                }

            }

            return head;
        }
    }
}
