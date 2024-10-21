public class IntersectionOfTwoLinkedList {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode currentA = headA, currentB = headB;
        var mapA = new Dictionary<int, ListNode>();

        while(currentA != null){
            if(!mapA.ContainsKey(currentA.val))
                mapA.Add(currentA.val, currentA);
            currentA = currentA.next;
        }
        while(currentB != null){
            if(mapA.ContainsKey(currentB.val) && currentB == mapA[currentB.val] ){
                return currentB;
            }
            currentB = currentB.next;
        }
     
        return null;
    }
}