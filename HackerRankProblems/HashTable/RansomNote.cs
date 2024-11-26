

namespace HackerRankProblems.HashTable
{
    internal class RansomNote
    {
        public static void Main(string[] args)
        {
            string ransomNote = "bg";
            string magazine = "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj";
            Console.WriteLine(CanConstruct(ransomNote, magazine));
        }
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            int[] charCounts = new int[26];
            foreach (char item in magazine)
            {
                charCounts[item - 'a']++;
            }
            foreach (char item in ransomNote)
            {
                if (charCounts[item - 'a'] > 0)
                {
                    charCounts[item - 'a']--;
                }
                else return false;
            }
            return true;
        }
    }
}
