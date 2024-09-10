namespace MaximumDiamonds
{
    class MaximumDiamonds
    {
        // static void Main(String[] args)
        // {
        //     int[] arr = {7, 1, 2};
        //     long result = Solution.maxDiamonds(arr, arr.Length, 2);
        //     System.Console.WriteLine(result);
        // }
    }
    class Solution
    {
        public static long maxDiamonds(int[] A, int N, int K)
        {
            long sum = 0;

            for (int i = 0; i < K; i++)
            {
                Array.Sort(A);
                sum += A[N - 1];
                A[N - 1] = A[N - 1] / 2;
            }
            return sum;
        }
    };
}