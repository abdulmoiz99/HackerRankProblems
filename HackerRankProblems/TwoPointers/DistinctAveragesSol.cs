namespace HackerRankProblems.TwoPointers
{
    internal class DistinctAveragesSol
    {
        public int DistinctAverages(int[] nums)
        {
            var set = new HashSet<double>();
            System.Array.Sort(nums);
            int start = 0, end = nums.Length - 1;
            while (start < end)
            {
                double average = nums[start++] + nums[end--];
                set.Add(average);
            }

            return set.Count();
        }
    }
}
