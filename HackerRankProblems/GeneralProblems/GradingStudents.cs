using System;

namespace HackerRankProblems.GeneralProblems
{
    internal class GradingStudents
    {
        // public static void Main(string[] args)
        // {
        //     var list = new List<int> { 73, 67, 38, 33 };
        //     list = gradingStudents(list);
        //     foreach (var item in list)
        //     {
        //         // System.Console.WriteLine(CalculateNextMultipleOfFive(item));
        //         Console.Write(item + ",");
        //     }
        //     Console.WriteLine();
        // }
        public static int CalculateNextMultipleOfFive(int number)
        {
            var result = Convert.ToInt32(Math.Round((double)number / 5.0) * 5);
            return result > number ? result : number;
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] >= 38)
                {
                    int result = CalculateNextMultipleOfFive(grades[i]);
                    if (result - grades[i] < 3)
                        grades[i] = result;
                }
            }
            return grades;
        }
    }
}
