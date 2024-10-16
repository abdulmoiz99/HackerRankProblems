/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class HasCycle {
    public bool HasCycle1(ListNode head) {
         ListNode current = head;
         var  map = new Dictionary<ListNode, int> ();
         while(current != null){
            if(map.ContainsKey(current)){
                return true;
            }
            else {
                map.Add(current, 0);
            }
            current = current.next;
         }
         return false;
    }
}