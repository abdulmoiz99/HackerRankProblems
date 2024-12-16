namespace HackerRankProblems.GeneralProblems
{
    internal class SortedSquares
    {
        public int[] SortedSquare(int[] nums)
        {
            int n = nums.Length;
            int left = 0, right = n - 1;
            var sorted = new int[n];
            for (int i = n - 1; i >= 0; i--)
            {
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    sorted[i] = nums[left] * nums[left];
                    left++;
                }
                else
                {
                    sorted[i] = nums[right] * nums[right];
                    right--;
                }

            }
            return sorted;
        }
    }
}
