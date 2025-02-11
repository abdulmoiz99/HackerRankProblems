using System.Text;

namespace HackerRankProblems.GeneralProblems
{
    internal class RemoveOccuranceSolution
    {
        //public static void Main(string[] args)
        //{
        //    string s = "eemckxmckx";
        //    string part = "emckx";

        //    Console.WriteLine(RemoveOccurrences(s, part));
        //}
        public static string RemoveOccurrences(string s, string part)
        {
            var sb = new StringBuilder();
            foreach (var c in s)
            {
                sb.Append(c);
                int length = part.Length;
                if(sb.Length >= part.Length && sb.ToString(sb.Length - length, length) == part)
                {
                    sb.Remove(sb.Length - length, length);
                }
            }
            return sb.ToString();

        }
    }
}
