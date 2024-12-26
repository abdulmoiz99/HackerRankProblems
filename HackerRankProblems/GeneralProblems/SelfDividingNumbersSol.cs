namespace HackerRankProblems.GeneralProblems
{
    internal class SelfDividingNumbersSol
    {
        //public static void Main(string[] args)
        //{
        //    var left = 1;
        //    var right = 22;
        //    Console.WriteLine(SelfDividingNumbers(left, right));
        //}
        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            var list = new List<int>();
            var result = new List<int>();
            for (int i = left; i <= right; i++)
            {
                if (SelfDividing(i))
                    result.Add(i);
            }

            return result;
        }
        public static bool SelfDividing(int num)
        {
            int divder = num;
            while (divder > 0)
            {
                int value = divder % 10;
                if (value == 0) return false;

                if (num % value != 0) return false;
                divder = divder / 10;

            }
            return true;
        }
    }
}
