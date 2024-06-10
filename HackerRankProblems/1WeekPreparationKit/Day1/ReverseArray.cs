namespace HackerRankProblems._1WeekPreparationKit.Day1
{
    internal class ReverseArray
    {
        public static List<int> reverseArray(List<int> a)
        {
            int startIndex = 0;
            int endIndex = a.Count - 1;

            for (int i = 0; i < a.Count(); i++)
            {
                if (startIndex >= endIndex) break;

                int temp = a[startIndex];
                a[startIndex] = a[endIndex];
                a[endIndex] = temp;

                startIndex++;
                endIndex--;

            }
            return a;
        }
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> res = reverseArray(arr);

            textWriter.WriteLine(String.Join(" ", res));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
