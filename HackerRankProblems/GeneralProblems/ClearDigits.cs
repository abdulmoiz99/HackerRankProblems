using System.Text;

namespace HackerRankProblems.GeneralProblems
{
    internal class ClearDigits
    {
        public string ClearDigitsSol(string s)
        {
            var sb = new StringBuilder();
            foreach (var c in s)
            {
                if (char.IsDigit(c))
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                else sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
