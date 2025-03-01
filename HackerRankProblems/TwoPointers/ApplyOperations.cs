namespace HackerRankProblems.TwoPointers
{
    internal class ApplyOperations
    {
        public int[] ApplyOperationsSol(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            int index = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums[i] *= 2;
                    nums[i + 1] = 0;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (nums[i] != 0)
                {
                    result[index++] = nums[i];
                }
            }

            return result;
        }
    }
}
