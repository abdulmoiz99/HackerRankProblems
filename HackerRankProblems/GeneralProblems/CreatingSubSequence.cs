namespace HackerRankProblems.GeneralProblems
{
    internal class CreatingSubSequence
    {
        //public static void Main(string[] args)
        //{
        //    string s1 = "ab";
        //    string s2 = "d";
        //    Console.WriteLine(CanMakeSubsequence(s1, s2));
        //}
        public static bool CanMakeSubsequence(string str1, string str2)
        {
            int i = 0, j = 0;
            while (j < str2.Length && i < str1.Length)
            {
                if (str1[i] == str2[j])
                {
                    i++; j++;
                }
                else
                {
                    char c = GetNextChar(str1[i]);
                    if (c == str2[j])
                    {
                        i++; j++;
                    }
                    else i++;
                }
            }
            return j == str2.Length;
        }
        public static  char GetNextChar(char c)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            char[] values = letters.ToCharArray();
            int index = ((c - 'a') + 1) % 26;
            return values[index];
        }
    }
}
