namespace HackerRankProblems.HashTable
{
    internal class FindTheDifference
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine(FindTheDifference1("ae", "aea"));
        //}
        public static char FindTheDifference1(string s, string t)
        {
            char result = '\0';

            foreach (char c in s)
            {
                result ^= c;
            }
            foreach (char c in t)
            {
                result ^= c;
            }
            return result;
        }

    }
}
