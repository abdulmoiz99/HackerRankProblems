
namespace HackerRankProblems._1WeekPreparationKit.Day1
{
    internal class MinMaxSum
    {
        //public static void Main(string[] args)
        //{

        //    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        //    MinMaxSumResult.miniMaxSum(arr);
        //}
    }
    public class MinMaxSumResult
    {

        public static void miniMaxSum(List<int> arr)
        {


            long min = 0, max = 0, sum = 0;
            arr.Sort();
            foreach (var item in arr)
            {
                sum += item;
            }
            min = sum - arr[arr.Count - 1];
            max = sum - arr[0];
            Console.Write(min.ToString() + " " + max.ToString());

        }

    }
}
