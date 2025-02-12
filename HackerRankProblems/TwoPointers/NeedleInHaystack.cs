namespace HackerRankProblems.TwoPointers
{
    internal class NeedleInHaystack
    {
        //public static void Main(string[] args)
        //{
        //    var s = "aaa";
        //    var p = "aaaa";
        //    Console.WriteLine(StrStr(s, p));
        //}
        public static int StrStr(string haystack, string needle)
        {
            int j = 0, needleLength = needle.Length;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[j])
                {
                    int start = i;
                    while (start < haystack.Length)
                    {
                        if (haystack[start] == needle[j])
                        {
                            start++;
                            j++;
                        }
                        else
                        {
                            break;
                        }
                        Console.WriteLine(j);
                        if (j == needleLength) return i;
                    }
                    j = 0;
                }
            }
            return -1;
        }
    }
}
