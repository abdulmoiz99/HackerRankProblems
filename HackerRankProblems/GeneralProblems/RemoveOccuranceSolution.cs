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
            int i = 0, j = 0;
            int length = part.Length;
            while (i < s.Length)
            {
                if (s[i] == part[j])
                {
                    int start = i;
                    while (start < s.Length && j < part.Length && s[start] == part[j])
                    {
                        start++; j++;
                    }

                    if (j == length)
                    {
                        s = s.Remove(i, j);
                        i = 0;
                    }
                    else
                    {
                        i++;
                    }
                    j = 0;

                }
                else i++;
            }
            return s;
        }
    }
}
