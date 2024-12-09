using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.GeneralProblems
{
    internal class ValidNumberFromString
    {
        public static void Main(string[] args)
        {

            string s = "Infinity";
            Console.WriteLine(IsNumber(s));
        }
        public static bool IsNumber(string s)
        {
            try
            {
                Convert.ToInt32(s);
                return true;
            }
            catch (Exception)
            {
                return IsValidDecimal(s);
            }
        }
        public static bool IsValidDecimal(string s)
        {
            try
            {
                Convert.ToDecimal(s);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
