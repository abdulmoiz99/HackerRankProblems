namespace HackerRankProblems.GeneralProblems
{
    internal class CountingWords
    {
        public int PrefixCount(string[] words, string pref)
        {
            int count = 0;
            int length = pref.Length;
            foreach (var item in words)
            {
                if (item.Length >= length && item.StartsWith(pref))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
