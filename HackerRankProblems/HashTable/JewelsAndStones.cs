namespace HackerRankProblems.HashTable
{
    internal class JewelsAndStones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            var set = new HashSet<char>();
            foreach (var c in jewels)
            {
                set.Add(c);
            }
            int count = 0;
            foreach (var c in stones)
            {
                if (set.Contains(c)) count++;
            }
            return count;
        }
    }
}
