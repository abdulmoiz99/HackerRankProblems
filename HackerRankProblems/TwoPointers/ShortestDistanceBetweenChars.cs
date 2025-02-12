using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.TwoPointers
{
    internal class ShortestDistanceBetweenChars
    {
        public int[] ShortestToChar(string s, char c)
        {
            var result = new int[s.Length];

            int index = FindE(0, s, c);
            int indexNew = index;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    index = i;
                    indexNew = FindE(i + 1, s, c);
                    result[i] = 0;
                }
                else
                {
                    int val = Math.Min(Math.Abs(index - i), Math.Abs(indexNew - i));
                    result[i] = val;
                }
            }
            return result;
        }
        public int FindE(int startIndex, string s, char c)
        {
            for (int i = startIndex; i < s.Length; i++)
            {
                if (s[i] == c) return i;
            }
            return -1;
        }
    }
}
