namespace ReverseFirstKElementsOfQueue
{
    class Diver
    {
        // static void Main(String[] args)
        // {

        //     Solution solution = new Solution();

        //     // Example test case
        //     int[] arr = { 9, 8, 4, 6, 4, 8, 9, 2 };
        //     int n = arr.Length;

        //     long result = solution.minSum(arr, n);

        //     Console.WriteLine("The minimum sum is: " + result);
        // }
    }
    class Solution
    {
        //Function to reverse first k elements of a queue.
        public Queue<int> modifyQueue(Queue<int> q, int k)
        {
            var stack = new Stack<int>();
            var reversedQueue = new Queue<int>();
            for (int i = 0; i < k; i++)
            {
                stack.Push(q.Dequeue());
            }
            for (int i = 0; i < k; i++)
            {
                reversedQueue.Enqueue(stack.Pop());
            }
            while (q.Count != 0)
            {
                reversedQueue.Enqueue(q.Dequeue());
            }
            return reversedQueue;
        }
    }
}