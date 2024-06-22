namespace HackerRankProblems._1WeekPreparationKit.Day1
{
    internal class BreakingTheRecord
    {
        //public static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Convert.ToInt32(Console.ReadLine().Trim());

        //    List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        //    List<int> result = Result.breakingRecords(scores);

        //    textWriter.WriteLine(String.Join(" ", result));

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
        class Result
        {

            /*
             * Complete the 'breakingRecords' function below.
             *
             * The function is expected to return an INTEGER_ARRAY.
             * The function accepts INTEGER_ARRAY scores as parameter.
             */

            public static List<int> breakingRecords(List<int> scores)
            {
                List<int> highestScoreCountList = new List<int>();
                List<int> lowestScoreCountList = new List<int>();

                lowestScoreCountList.Add(scores[0]);
                highestScoreCountList.Add(scores[0]);

                for (int i = 1; i < scores.Count(); i++)
                {
                    if (scores[i] < lowestScoreCountList.Min())
                        lowestScoreCountList.Add(scores[i]);

                    if (scores[i] > highestScoreCountList.Max())
                        highestScoreCountList.Add(scores[i]);

                }


                List<int> result = new List<int>();
                result.Add(highestScoreCountList.Count() - 1);
                result.Add(lowestScoreCountList.Count() - 1);
                return result;
            }
        }
    }
}
