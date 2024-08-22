using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Array.Stack
{
    internal class EqualStack
    {
        //public static void Main(string[] args)
        //{
        //    List<int> h1 = new List<int> { 3, 2, 1, 1, 1 };
        //    List<int> h2 = new List<int> { 4, 3, 2 };
        //    List<int> h3 = new List<int> { 1, 1, 4, 1 };
        //    Console.WriteLine(equalStacks(h1, h2, h3));
        //}

        public static int equalStacks(List<int> h1, List<int> h2, List<int> h3)
        {
            int aSum = 0, bSum = 0, cSum = 0, height = 0;
            while (true)
            {
                aSum = h1.Sum();
                bSum = h2.Sum();
                cSum = h3.Sum();

                height = Math.Min(aSum, Math.Min(bSum, cSum));

                if (aSum == bSum && bSum == cSum) break;

                if (h1.Count == 0 || h2.Count == 0 || h3.Count == 0) return 0;

                if (aSum > height) h1.RemoveAt(0);
                if (bSum > height) h2.RemoveAt(0);
                if (cSum > height) h3.RemoveAt(0);
            }
            return height;
        }

    }
}
