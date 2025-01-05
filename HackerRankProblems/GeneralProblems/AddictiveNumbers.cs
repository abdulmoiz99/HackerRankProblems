namespace HackerRankProblems.GeneralProblems
{
    internal class AddictiveNumbers
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine(IsAdditiveNumber("011112"));
        //}
        public static bool IsAdditiveNumber(string num)
        {
            if (num.Length < 3) return false;

            int index = 1, length = 1;
            int value1 = Convert.ToInt32(num[0].ToString());

            while (index < num.Length)
            {
                string value2 = num.Substring(index, length);
                if (value2[0] == '0') return false;
                int sum = value1 + Convert.ToInt32(value2);
                if (index + length + sum.ToString().Length > num.Length) return false;
                var total = num.Substring(index + length, sum.ToString().Length);
                if (sum == Convert.ToInt32(total))
                {
                    if (index + length + sum.ToString().Length == num.Length) break;
                    
                    index = index + length;
                    value1 = Convert.ToInt32(value2);
                    length = 1;
                }
                else length++;
            }

            return true;
        }
    }
}
