using System.Text;

namespace Problems.LeetCode.Common
{

    //Definition for singly-linked list.
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
    }

}
