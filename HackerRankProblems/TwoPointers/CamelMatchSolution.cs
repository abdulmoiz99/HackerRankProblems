namespace HackerRankProblems.TwoPointers
{
    internal class CamelMatchSolution
    {
        //public static void Main(string[] args)
        //{
        //    var query = "ControlPanel";
        //    var pattern = "CooP";
        //    Console.WriteLine(IsMatch(query, pattern));
        }
        public static bool IsMatch(string query, string pattern)
        {
            int i = 0, j = 0;
            for (i = 0; i < query.Length; i++)
            {
                if (char.IsUpper(query[i]))
                {
                    if (j >= pattern.Length || query[i] != pattern[j])
                        return false;
                    j++;
                }
                else if (j < pattern.Length && query[i] == pattern[j])
                {
                    j++;
                }
            }

            return j == pattern.Length;
        }
    }
}
