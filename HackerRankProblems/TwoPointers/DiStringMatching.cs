namespace HackerRankProblems.TwoPointers
{
    internal class DiStringMatching
    {
        public int[] DiStringMatch(string s)
        {
            int length = s.Length, low = 0, high = length, index = 0;
            int[] result = new int[length + 1];
            while (index < length)
            {
                if (s[index] == 'I')
                {
                    result[index] = low++;
                }
                else
                {
                    result[index] = high--;
                }
                index++;
            }
            result[index] = low;
            return result;
        }
    }
}
