namespace HackerRankProblems.HashTable
{
    internal class ShortestCompletingWordClass
    {
        //public static void Main(string[] args)
        //{
        //    string[] words = { "measure", "other", "every", "base", "according", "level", "meeting", "none", "marriage", "rest" };
        //    Console.WriteLine(ShortestCompletingWord("GrC8950", words));
        //}
        public static string ShortestCompletingWord(string licensePlate, string[] words)
        {
            var dictionary = wordToDictionary(licensePlate);
            var list = new List<string>();
            foreach (var word in words)
            {
                if (IsValidWord(dictionary, word))
                {
                    list.Add(word);
                }
            }
            return FindShortestWord(list);
        }
        private static string FindShortestWord(List<string> list)
        {
            if(list.Count == 1) return list[0];

            int min = Int32.MaxValue;
            string result = "";

            foreach (var word in list)
            {
                int length = word.Length;
                if (length < min)
                {
                    result = word;
                    min = length;
                }
            }
            return result;
        }
        private static bool IsValidWord(Dictionary<char, int> dictionary, string word)
        {
            var dictionaryCopy = dictionary.ToDictionary(entry => entry.Key, entry => entry.Value);
            foreach (var c in word)
            {
                if (dictionaryCopy.ContainsKey(c))
                    dictionaryCopy[c]--;
            }
            foreach (var value in dictionaryCopy.Values)
                if (value != 0) return false;

            return true;
        }
        private static Dictionary<char, int> wordToDictionary(string word)
        {
            var dictionary = new Dictionary<char, int>();
            word = word.ToLower();
            foreach (char c in word)
            {
                if (char.IsLetter(c))
                {
                    if (dictionary.ContainsKey(c))
                        dictionary[c]++;
                    else dictionary.Add(c, 1);
                }

            }
            return dictionary;
        }
    }
}
