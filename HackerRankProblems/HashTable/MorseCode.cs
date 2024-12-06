using System.Text;

namespace HackerRankProblems.HashTable
{
    internal class MorseCode
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            var set = new HashSet<string>();
            foreach (var word in words)
            {
                set.Add(GetMorseCode(word));
            }
            return set.Count();
        }
        public string GetMorseCode(string word)
        {
            string[] code = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            var result = new StringBuilder();
            foreach (char c in word)
            {
                int index = c - 'a';
                result.Append(code[index]);
            }
            return result.ToString();
        }
    }
}
