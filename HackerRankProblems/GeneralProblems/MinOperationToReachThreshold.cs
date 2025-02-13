namespace HackerRankProblems.GeneralProblems
{
    internal class MinOperationToReachThreshold
    {
        public int MinOperations(int[] nums, int k)
        {
            var pq = new PriorityQueue<long, long>();
            int count = 0;
            foreach (var item in nums)
            {
                pq.Enqueue(item, item);
            }
            while (pq.Count > 1 && pq.Peek() < k)
            {
                long value = (pq.Dequeue() * 2) + pq.Dequeue();
                pq.Enqueue(value, value);
                count++;
            }
            return count;
        }
    }
}
