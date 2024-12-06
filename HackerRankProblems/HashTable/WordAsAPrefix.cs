namespace HackerRankProblems.HashTable
{
    internal class WordAsAPrefix
    {
        public int IsPrefixOfWord(string sentence, string searchWord)
        {
            if (string.IsNullOrEmpty(sentence) || string.IsNullOrEmpty(searchWord))
                return -1;

            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].StartsWith(searchWord, StringComparison.OrdinalIgnoreCase))
                    return i + 1;
            }
            return -1;
        }
    }
}
