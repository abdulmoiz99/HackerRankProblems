public class QueueUsingLinkedList{

}
public class MyQueue
{
    public QueueNode head;
    public QueueNode rear;
    public void push(int x)
    {
        QueueNode newNode = new QueueNode(x);
        if(head == null){
            head = newNode;
        }
        else {
            QueueNode current = head;
            while(current.next != null){
                current = current.next;
            }
            current.next = newNode;
        }
    }
    public int pop()
    {
        if(head == null){
            return -1;
        }
        else{
            int value = head.data;
            head = head.next;
            return value;
        }
    }
}

public class QueueNode
{
    public int data;
    public QueueNode next;
    public QueueNode(int a)
    {
        data = a;
        next = null;
    }
}