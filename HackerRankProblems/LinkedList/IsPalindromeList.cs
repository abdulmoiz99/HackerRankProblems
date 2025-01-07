namespace HackerRankProblems.LinkedList
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
    }

    internal class IsPalindromeList
    {
        public bool IsPalindrome(ListNode head)
        {

            if (head == null) return false;


            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            var reverse = ReverseList(slow);

            while (reverse != null)
            {
                if (head.val != reverse.val) return false;

                head = head.next;
                reverse = reverse.next;
            }



            return true;
        }
        ListNode ReverseList(ListNode head)
        {

            ListNode prev = null, current = head;

            while (current != null)
            {
                ListNode next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }
    }
}
