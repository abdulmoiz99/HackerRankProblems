namespace HackerRankProblems.HashTable
{
    internal class ComputeAnagrams
    {
        //public static void Main(string[] args)
        //{
        //    var s = "cbaebabacd";
        //    var p = "abc";
        //    Console.WriteLine(FindAnagrams(s, p));
        //}

        public static IList<int> FindAnagrams(string s, string p)
        {
            var list = new List<int>();
            int start = 0, end = 0;


            var compare = new Dictionary<char, int>();

            foreach (var item in p)
            {
                if (compare.ContainsKey(item))
                {
                    compare[item]++;
                }
                else compare.Add(item, 1);
            }

            var set = new Dictionary<char, int>();

            while (end < s.Length)
            {
                if (set.ContainsKey(s[end]))
                    set[s[end]]++;
                else
                    set.Add(s[end], 1);
                end++;

                if (end - start == p.Length)
                {
                    if (IsDictionaryEqual(compare, set))
                    {
                        list.Add(start);
                    }
                    if (set[s[start]] > 0)
                        set[s[start]]--;
                    else set.Remove(s[start]);

                    start++;
                }
            }

            return list;
        }
       
        public static bool IsDictionaryEqual(Dictionary<char, int> compare, Dictionary<char, int> set)
        {
            foreach (var kvp in compare)
            {
                if (!set.ContainsKey(kvp.Key) || set[kvp.Key] != kvp.Value)
                    return false;
            }
            return true;
        }
    }
}
