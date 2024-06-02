

namespace HackerRankProblems._1WeekPreparationKit.Day1
{
    internal class plusMinusProblem
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }
    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            double postive = 0.0, negative = 0.0, zero = 0.0;

            foreach (var number in arr)
            {
                if (number > 0) postive++;
                else if (number < 0) negative--;
                else zero++;
            }
            postive = postive / arr.Count();
            negative = negative / arr.Count();
            zero = zero / arr.Count();

            Console.WriteLine(string.Format("{0:0.000000}", postive));
            Console.WriteLine(string.Format("{0:0.000000}", negative));
            Console.WriteLine(string.Format("{0:0.000000}", zero));
        }
    }
}
