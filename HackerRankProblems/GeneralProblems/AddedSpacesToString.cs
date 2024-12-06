using System.Text;

namespace HackerRankProblems.GeneralProblems
{
    internal class AddedSpacesToString
    {
        public class Solution
        {
            public string AddSpaces(string s, int[] spaces)
            {
                var set = new HashSet<int>(spaces);
                var result = new StringBuilder();
                for (int i = 0; i < s.Length; i++)
                {
                    if (set.Contains(i))
                        result.Append(" ");

                    result.Append(s[i]);
                }
                return result.ToString();
            }
        }
    }
}
