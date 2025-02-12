namespace HackerRankProblems.HashTable
{
    internal class LargestPositiveIntegerWithNegativeNumber
    {
        public int FindMaxK(int[] nums)
        {
            var set = new HashSet<int>();
            int max = -1;
            foreach (var num in nums)
            {
                int value = Math.Abs(num);
                if ((num > 0 && set.Contains(num * -1)) || (num < 0 && set.Contains(value)))
                {
                    if (value > max) max = value;
                }
                else set.Add(num);
            }
            return max;
        }
    }
}
