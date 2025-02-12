namespace HackerRankProblems.TwoPointers
{
    internal class MaxProfitAssignmentSolution
    {
        public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
        {
            var heap = new PriorityQueue<int, int>();
            for (int i = 0; i < profit.Length; i++)
            {
                heap.Enqueue(difficulty[i], profit[i] * -1);
            }
            int total = 0;
            for (int i = 0; i < worker.Length; i++)
            {
                heap.TryPeek(out int diff, out int profitValue);
                if (diff <= worker[i])
                {
                    total += profitValue;
                }
                else
                {
                    var list = new List<Tuple<int, int>>();
                    while (true)
                    {
                        heap.TryPeek(out diff, out profitValue);
                        if (diff <= worker[i]) break;
                        heap.TryDequeue(out diff, out profitValue);
                        list.Add(new Tuple<int, int>(diff, profitValue));
                    }
                    total += profitValue;
                    foreach (Tuple<int, int> tuple in list)
                    {
                        heap.Enqueue(tuple.Item1, tuple.Item2);
                    }
                }
            }
            return total * -1;
        }
    }
}
