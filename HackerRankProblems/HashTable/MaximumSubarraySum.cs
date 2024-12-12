namespace HackerRankProblems.HashTable
{
    internal class MaximumSubarraySum
    {
        //public static void Main(string[] args)
        //{
        //    int[] nums = { 9, 9, 9, 1, 2, 3 };
        //    Console.WriteLine(MaximumSubarraySum1(nums, 3));
        //}
        public static long MaximumSubarraySum1(int[] nums, int k)
        {
            HashSet<int> set = new HashSet<int>();
            int j = 0;
            long max = 0, sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                while (set.Contains(nums[i]))
                {
                    set.Remove(nums[j]);
                    sum -= nums[j];
                    j++;
                }

                set.Add(nums[i]);
                sum += nums[i];

                if (i - j + 1 == k)
                {
                    max = Math.Max(max, sum);
                    set.Remove(nums[j]);
                    sum -= nums[j];
                    j++;
                }
            }
            return max;
        }
    }
}
