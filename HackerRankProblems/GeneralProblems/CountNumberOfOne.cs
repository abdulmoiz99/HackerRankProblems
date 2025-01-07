using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.GeneralProblems
{
    internal class CountNumberOfOne
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine(CountDigitOne(824883294));
        //}
        public static int CountDigitOne(int n)
        {
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                count += CountOnes(i);
            }
            return count;
        }
        static int CountOnes(int number)
        {
            string numberString = number.ToString();
            int count = 0;
            foreach (char digit in numberString)
            {
                if (digit == '1')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
