public class StackUsingTwoQueues
{
    public static void Main(string[] args)
    {
        var solution = new Solution();
        solution.push(1);
        solution.push(2);
        solution.push(3);

        System.Console.WriteLine(solution.pop());
        System.Console.WriteLine(solution.pop());
        System.Console.WriteLine(solution.pop());
        System.Console.WriteLine(solution.pop());
    }
}
class Solution
{
    private Queue<int> q1;
    private Queue<int> q2;

    public Solution()
    {
        q1 = new Queue<int>();
        q2 = new Queue<int>();
    }

    // Function to push an element into stack using two queues.
    public void push(int x)
    {
        if (q1.Count() == 0)
        {
            q1.Enqueue(x);
        }
        else
        {
            while (q1.Count() != 0)
            {
                q2.Enqueue(q1.Dequeue());
            }
            q1.Enqueue(x);
            while (q2.Count() != 0)
            {
                q1.Enqueue(q2.Dequeue());
            }
        }
    }

    // Function to pop an element from stack using two queues.
    public int pop()
    {
        if (q1.Count() != 0)
        {
            return q1.Dequeue();
        }
        else return -1;
    }
}