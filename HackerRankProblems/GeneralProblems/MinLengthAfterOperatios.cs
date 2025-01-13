namespace HackerRankProblems.GeneralProblems
{
    internal class MinLengthAfterOperatios
    {
        public int MinimumLength(string s)
        {
            var dictionary = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dictionary.ContainsKey(s[i]))
                    dictionary[s[i]]++;
                else dictionary.Add(s[i], 1);
            }
            int result = 0;
            foreach (var item in dictionary)
            {
                if (item.Value >= 3)
                {
                    int value = item.Value;
                    while (value >= 3)
                        value = value - 2;
                    result += value;
                }
                else result += item.Value;
            }
            return result;
        }
    }
}
