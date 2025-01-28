namespace HackerRankProblems.HashTable
{
    internal class FirstCompleteIndexSol
    {
        public int FirstCompleteIndex(int[] arr, int[][] mat)
        {
            int rows = mat.Length;
            int columns = mat[0].Length;

            var rowFrequence = new int[rows];
            var colFrequence = new int[columns];

            var set = new Dictionary<int, (int, int)>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    set.Add(mat[i][j], (i, j));
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                var value = set[arr[i]];
                rowFrequence[value.Item1]++;
                if (rowFrequence[value.Item1] == columns)
                    return i;

                colFrequence[value.Item2]++;
                if (colFrequence[value.Item2] == rows)
                    return i;
            }
            return 1;
        }
    }
}
