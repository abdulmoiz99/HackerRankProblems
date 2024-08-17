namespace HackerRankProblems.Array._2DArray
{
    internal class AbsoluteDifference
    {
        //public static void Main(string[] args)
        //{
        //    List<List<int>> list = new List<List<int>>();
        //    list.Add(new List<int> { 11, 2, 4 });
        //    list.Add(new List<int> { 4, 5, 6 });
        //    list.Add(new List<int> { 10, 8, -12 });
        //    Console.WriteLine(diagonalDifference(list));
        //}
        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftDiagonalSum = 0;
            int rightDiagonalSum = 0;
            int rightDiagonalIndex = arr.Count - 1;
          
            for (int i = 0; i < arr.Count; i++)
            {
                leftDiagonalSum += arr[i][i];
                rightDiagonalSum += arr[i][rightDiagonalIndex--];
            }
            return Math.Abs(leftDiagonalSum - rightDiagonalSum);
        }
    }
}
