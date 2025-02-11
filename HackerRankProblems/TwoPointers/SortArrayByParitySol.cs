namespace HackerRankProblems.TwoPointers
{
    internal class SortArrayByParitySol
    {
        public int[] SortArrayByParity(int[] nums)
        {
            var result = new int[nums.Length];
            int index = 0;
            foreach (var item in nums)
            {
                if (item % 2 == 0)
                    result[index++] = item;
            }

            foreach (var item in nums)
            {
                if (item % 2 != 0)
                    result[index++] = item;
            }
            return result;
        }
    }
}
