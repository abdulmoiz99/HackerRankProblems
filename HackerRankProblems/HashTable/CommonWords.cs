using System.Text.RegularExpressions;

namespace HackerRankProblems.HashTable
{
    internal class CommonWords
    {
        //public static void Main(string[] args)
        //{
        //    string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
        //    string[] strings = { "hit" };
        //    MostCommonWord(paragraph, strings);
        //}
        public static string MostCommonWord(string paragraph, string[] banned)
        {
            string[] words = ExtractLowercaseWords(paragraph);
            var dictionary = new Dictionary<string, int>();
            foreach (var item in words)
            {
                if (dictionary.ContainsKey(item))
                    dictionary[item]++;
                else dictionary.Add(item, 1);
            }
            var bannedWords = new HashSet<string>(banned);
            int max = Int32.MinValue;
            string result = "";
            foreach (var item in dictionary)
            {
                if (!bannedWords.Contains(item.Key) && item.Value > max)
                {
                    max = item.Value;
                    result = item.Key;
                }
            }
            return result;
        }

        static string[] ExtractLowercaseWords(string paragraph)
        {
            var regex = new Regex(@"\b\w+\b");

            return regex.Matches(paragraph)
                        .Cast<Match>()
                        .Select(m => m.Value.ToLower())
                        .ToArray();
        }
    }
}
