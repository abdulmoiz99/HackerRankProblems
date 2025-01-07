namespace HackerRankProblems.LinkedList
{
    internal class GetDecimalValues
    {
        public int GetDecimalValue(ListNode head)
        {
            ListNode current = head;
            double result = 0;
            int length = 0;
            while (current.next != null)
            {
                length++;
                current = current.next;
            }
            while (head != null)
            {
                if (head.val == 1)
                    result += Math.Pow(2, length);
                length--;
                head = head.next;
            }
            return Convert.ToInt32(result);
        }
    }
}
