namespace HackerRankProblems.HashTable
{
    internal class UncommonWordsFromSentences
    {
        //public static void Main(string[] args)
        //{
        //    string s1 = "abcd def abcd xyz";
        //    string s2 = "ijk def ijk";
        //    UncommonFromSentences(s1, s2);
        //}
        public static string[] UncommonFromSentences(string s1, string s2)
        {
            var dictionary = new Dictionary<string, int>();
            foreach (var word in s1.Split(" "))
            {
                if (dictionary.ContainsKey(word))
                    dictionary[word]++;
                else dictionary.Add(word, 0);
            }
            foreach (var word in s2.Split(" "))
            {
                if (dictionary.ContainsKey(word))
                    dictionary[word]++;
                else dictionary.Add(word, 0);
            }
            var list = new List<string>();
            foreach (var item in dictionary)
            {
                if (item.Value == 0)
                    list.Add(item.Key);
            }
            return list.ToArray();
        }
    }
}
