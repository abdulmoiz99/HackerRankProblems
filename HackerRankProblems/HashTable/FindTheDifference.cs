using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.HashTable
{
    internal class FindTheDifference
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(FindTheDifference1("a", "aa"));
        }
        public static char FindTheDifference1(string s, string t)
        {
            var dictionary = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (dictionary.ContainsKey(item))
                    dictionary[item]++;
                else dictionary.Add(item, 1);
            }
            foreach (var item in t)
            {
                if (dictionary.ContainsKey(item) && dictionary[item] > 0)
                    dictionary[item]--;
                else return item;
            }
            return ' ';
        }

    }
}
