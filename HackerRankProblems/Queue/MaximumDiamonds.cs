namespace MaximumDiamonds
{
    class MaximumDiamonds
    {
        // static void Main(String[] args)
        // {
        //     int[] arr = { 7, 1, 2 };
        //     long result = Solution.maxDiamonds(arr, arr.Length, 2);
        //     System.Console.WriteLine(result);
        // }
    }
    class Solution
    {
        public static long maxDiamonds(int[] A, int N, int K)
        {
            var pQ = new PriorityQueue<int, int>();
            long sum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                pQ.Enqueue(A[i], -1 * A[i]);
            }

            for (int i = 0; i < K; i++)
            {
                int value = pQ.Dequeue();
                sum += value;
                value = value / 2;
                pQ.Enqueue(value, -1 * value);
            }
            return sum;
        }
    };
}