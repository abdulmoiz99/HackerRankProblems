namespace HackerRankProblems.HashTable
{
    internal class MaximumSumSol
    {
        public int MaximumSum(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();
            int max = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                var value = GetSum(nums[i]);
                if (dictionary.ContainsKey(value))
                {
                    int sum = nums[i] + nums[dictionary[value]];
                    int index = dictionary[value];
                    if (sum > max)
                        max = sum;

                    if (nums[i] > nums[dictionary[value]])
                    {
                        dictionary[value] = i;
                    }
                }
                else dictionary.Add(value, i);
            }

            return max;
        }
        public int GetSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            return sum;
        }
    }
}
