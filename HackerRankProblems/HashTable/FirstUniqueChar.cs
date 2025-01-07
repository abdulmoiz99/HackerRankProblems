using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.HashTable
{
    internal class FirstUniqueChar
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine(FirstUniqChar("aabb"));
        //}
        public static int FirstUniqChar(string s)
        {
            var dictionary = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dictionary.ContainsKey(s[i]))
                    dictionary[s[i]]++;
                else
                {
                    dictionary.Add(s[i], 1);
                }
            }
            char? c = null;
            foreach (var item in dictionary)
            {
                if (item.Value == 1)
                {
                    c = item.Key;
                    break;
                }
            }
            if (c != null)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == c) return i;
                }
            }
            return -1;
        }
    }
}