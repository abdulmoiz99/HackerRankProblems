namespace HackerRankProblems.GeneralProblems
{
    internal class RotateArray
    {
        //public static void Main(string[] args)
        //{
        //    int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        //    Rotate(nums, 3);
        //}
        public static void Rotate(int[] nums, int k)
        {
            for (int j = 0; j < k; j++)
            {
                int hold = nums[nums.Length - 1];
                for (int i = 0; i < nums.Length; i++)
                {
                    (hold, nums[i]) = (nums[i], hold);
                }
            }

            Console.WriteLine();
        }
    }
}
