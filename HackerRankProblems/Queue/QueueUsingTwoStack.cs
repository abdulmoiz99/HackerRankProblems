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