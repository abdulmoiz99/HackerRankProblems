using static System.Net.Mime.MediaTypeNames;

namespace HackerRankProblems.GeneralProblems
{
    internal class KMPStringMatchingAlgorithim
    {
        public class Solution
        {
            public IList<string> StringMatching(string[] words)
            {
                var result = new HashSet<string>();

                System.Array.Sort(words, (a, b) => a.Length.CompareTo(b.Length));

                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[j].Contains(words[i]))
                        {
                            result.Add(words[i]);
                            break;
                        }
                    }
                }
                return result.ToList();
            }
            bool ContainsSubstring(string word, string pattern)
            {
                int n = word.Length;
                int m = pattern.Length;
                var lps = _getLPS(pattern);

                int i = 0, j = 0;

                while (i < n)
                {
                    if (pattern[j] == word[i])
                    {
                        i++; j++;
                    }
                    if (j == m) return true;
                    else if (i < n && pattern[j] != word[i])
                    {
                        if (j != 0)
                        {
                            j = lps[j - 1];
                        }
                        else i++;
                    }

                }
                return false;
            }
            int[] _getLPS(string pattern)
            {
                int[] lps = new int[pattern.Length];

                int i = 1, len = 0;

                while (i < pattern.Length)
                {
                    if (pattern[i] == pattern[len])
                    {
                        len++;
                        lps[i] = len;
                    }
                    else
                    {
                        if (len != 0)
                            len = lps[len - 1];
                        else lps[i] = 0;
                    }
                    i++;
                }
                return lps;
            }
        }
    }
}
