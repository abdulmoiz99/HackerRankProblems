namespace HackerRankProblems.GeneralProblems
{
    internal class FindThePrefixCommonArraySolution
    {
        public int[] FindThePrefixCommonArray(int[] A, int[] B)
        {
            int[] freq = new int[A.Length];
            int[] result = new int[A.Length];

            int ans = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int a = A[i] - 1, b = B[i] - 1;
                freq[a]++;
                freq[b]++;

                if (freq[a] == 2 && a != b) ans++;
                if (freq[b] == 2) ans++;

                result[i] = ans;
            }

            return result;
        }
    }
}
