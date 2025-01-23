namespace HackerRankProblems.GeneralProblems
{
    internal class CountServersThatCommunicate
    {
        public int CountServers(int[][] grid)
        {
            var rows = new int[grid[0].Length];
            var cols = new int[grid.Length];
            var list = new List<(int, int)>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        list.Add((i, j));
                        cols[i]++;
                        rows[j]++;

                    }
                }
            }
            int count = 0;
            foreach (var value in list)
            {
                if (rows[value.Item2] > 1 || cols[value.Item1] > 1)
                    count++;
            }

            return count;
        }
    }
}
