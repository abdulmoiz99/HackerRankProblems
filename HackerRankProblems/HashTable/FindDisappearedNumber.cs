namespace HackerRankProblems.HashTable
{
    internal class FindDisappearedNumber
    {
        //public static void Main(string[] args)
        //{
        //    int[] numbers = { 4, 3, 2, 7, 8, 2, 3, 1 };
        //    var result = FindDisappearedNumbers(numbers);
        //    Console.WriteLine("---");
        //}
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            return FindMissingValues(nums);
        }
        public static IList<int> FindMissingValues(int[] nums)
        {
            var result = new List<int>();

            for (int i = 0; i < nums.Count(); i++)
            {
                int index = Math.Abs(nums[i]) - 1;

                if (nums[index] > 0)
                    nums[index] = -nums[index];
            }
            for (int i = 0; i < nums.Count(); i++)
            {
                if(nums[i] > 0)
                    result.Add(i + 1);
            }
            return result;
        }
    }
}
