namespace HackerRankProblems.HashTable
{
    internal class DistributeCandie
    {
        public int DistributeCandies(int[] candyType)
        {
            int candyLimit = candyType.Length / 2;
            var set = new HashSet<int>();
            foreach (var candy in candyType)
            {
                set.Add(candy);
                if (set.Count == candyLimit) return candyLimit;
            }
            return set.Count;
        }
    }
}
