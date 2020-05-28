using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges.Library.LeetCode.Common
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


        public override string ToString()
        {
            ListNode node = this;
            StringBuilder sb = new StringBuilder();

            while (node != null)
            {
                sb.Append($"{node.val}->");
                node = node.next;
            }

            sb.Append("NULL");

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
