class PrintFirstNegativeInteger
{
    //Complete this function
    //Function to find the first negative integer for each window of size k.
    public List<long> printFirstNegativeInteger(long[] A, long N, long K)
    {
        Queue<long> queue = new Queue<long>();
        List<long> list = new List<long>();
        int indexPointer = 0;

        for (int i = 0; i < K; i++)
        {
            queue.Enqueue(A[indexPointer++]);
        }

        list.Add(FirstNegative(queue));

        for (int i = indexPointer; i < N; i++)
        {
            queue.Dequeue();
            queue.Enqueue(A[indexPointer++]);
            list.Add(FirstNegative(queue));
        }

        return list;
    }
    private long FirstNegative(Queue<long> queue)
    {
        foreach (var value in queue)
        {
            if (value < 0)
            {
                return value; // Return the first negative number found
            }
        }
        return 0; // Return 0 if no negative number is found
    }
}