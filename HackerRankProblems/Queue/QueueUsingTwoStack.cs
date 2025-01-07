class QueueUsingTwoStack
{
    // static void Main(String[] args)
    // {
    //     int queueSize = int.Parse(Console.ReadLine());
    //     Queue queue = new Queue(queueSize);
    //     for (int i = 0; i < queueSize; i++)
    //     {
    //         string input = Console.ReadLine();
    //         string[] inputs = input.Split(" ");
    //         if (inputs[0].ToString() == "1")
    //         {
    //             queue.enqueue(int.Parse(inputs[1].ToString()));
    //         }
    //         else if (inputs[0].ToString() == "2")
    //         {
    //             queue.dequeue();
    //         }
    //         else
    //         {
    //             System.Console.WriteLine(queue.peek());
    //         }
    //     }

    // }
}
class Queue
{
    int[] queue;
    int front = 0;
    int rear = 0;
    public Queue(int queueSize)
    {
        queue = new int[queueSize * 2];
    }
    public int peek()
    {
        return queue[front];
    }
    public void enqueue(int value)
    {
        queue[rear++] = value;
    }
    public int dequeue()
    {
        return queue[front++];
    }
}
class StackQueue
{
  private Stack<int> s1;
  private Stack<int> s2;

  public StackQueue(){
      s1 = new Stack<int>();
      s2 = new Stack<int>();
  }
  public void push(int x)
    {
       if(s1.Count == 0){
           s1.Push(x);
       }
       else {
           while(s1.Count != 0){
               s2.Push(s1.Pop());
           }
           s1.Push(x);
          

        while(s2.Count != 0){
               s1.Push(s2.Pop());
           }
            
       }
     
    }

    public int pop()
    {
         if(s1.Count == 0){
            return -1;
          }
          else {
              return s1.Pop();
          }
    }
}