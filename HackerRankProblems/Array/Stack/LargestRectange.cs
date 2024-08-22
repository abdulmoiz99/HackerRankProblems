using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Array.Stack
{
    internal class LargestRectange
    {
        //public static void Main()
        //{
        //    //List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
        //    //Console.WriteLine(largestRectangle(ints));

        //    List<int> int1 = new List<int> { 11, 11, 10, 10, 10 };
        //    Console.WriteLine(largestRectangle(int1));
        //}
        public static long largestRectangle(List<int> h)
        {
            long maxRectange = long.MinValue;
            for (int i = 0; i < h.Count; i++)
            {
                int area = 1;
                for (int j = i; j >= 0; j--)
                {
                    long multipler = h[i] > h[j] ? h[j] : h[i];
                    long value = multipler * area;
                    area++;
                    if (value > maxRectange)
                    {
                        maxRectange = value;
                    }
                }
            }
            return maxRectange;

        }

    }
}
