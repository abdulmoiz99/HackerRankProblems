using System;
namespace HackerRankProblems.HashTable
{
    internal class MaxNumbersOfIntegers
    {
        public int MaxCount(int[] banned, int n, int maxSum)
        {
            var set = new HashSet<int>(banned);
            int sum = 0;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (!set.Contains(i))
                {
                    sum += i;
                    if (sum > maxSum) break;

                    count++;
                }

            }
            return count;
        }
    }
}
