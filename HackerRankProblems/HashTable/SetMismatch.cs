namespace HackerRankProblems.HashTable
{
    internal class SetMismatch
    {
        //public static void Main(string[] args)
        //{
        //    int[] nums = { 2, 2 };
        //    Console.WriteLine(FindErrorNums(nums));
        //}
        public static int[] FindErrorNums(int[] nums)
        {
            return new int[] { FindDuplicatedValue(nums), FindMissingValues(nums) };
        }
        public static int FindMissingValues(int[] nums)
        {
            var set = new HashSet<int>(nums);
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!set.Contains(i))
                    return i;
            }
            return -1;
        }
        public static int FindDuplicatedValue(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (var item in nums)
            {
                if (set.Contains(item)) { return item; }
                set.Add(item);
            }
            return -1;
        }
    }
}
