using System;
namespace HackerRankProblems.HashTable
{
    internal class FindWords
    {
        public string[] FindWord(string[] words)
        {
            var dictionary = new Dictionary<char, int>();
            var row1 = new HashSet<char>("qwertyuiop");
            var row2 = new HashSet<char>("asdfghjkl");
            var row3 = new HashSet<char>("zxcvbnm");

            var list = new List<string>();
            foreach (var word in words)
            {
                if (IsValidRow(word.ToLower(), row1) || IsValidRow(word.ToLower(), row2) || IsValidRow(word.ToLower(), row3))
                    list.Add(word);
            }
            return list.ToArray();
        }
        public bool IsValidRow(string word, HashSet<char> set)
        {
            foreach (var c in word)
            {
                if (!set.Contains(c)) return false;
            }
            return true;
        }
    }
}
