namespace HackerRankProblems.LinkedList
{
    internal class AddingTwoNumber
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0); // Dummy head node
            ListNode current = dummyHead;
            int carry = 0;
            while (l1 != null || l2 != null || carry > 0)
            {
                int value1 = l1 != null ? l1.val : 0;
                int value2 = l2 != null ? l2.val : 0;
                int result = value1 + value2 + carry;

                carry = result / 10;

                var node = new ListNode(result % 10);
                current.next = node;
                current = current.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            return dummyHead.next;
        }
    }
}
