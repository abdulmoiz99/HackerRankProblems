namespace HackerRankProblems.PriorityQueue
{
    class MaxProductofTwoElementInArray
    {
        public int MaxProduct(int[] nums)
        {
            int firstMax = 0, secondMax = 0;
            foreach (var num in nums)
            {
                if (num > firstMax)
                {
                    secondMax = firstMax;
                    firstMax = num;
                }
                else if (num > secondMax)
                {
                    secondMax = num;
                }
            }
            return (firstMax - 1) * (secondMax - 1);
        }
    }
}
