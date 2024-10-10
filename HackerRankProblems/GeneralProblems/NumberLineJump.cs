using System;

namespace HackerRankProblems.NumberLineJump
{
    internal class NumberLineJump
    {
        // public static void Main(string[] args)
        // {
        //     Console.WriteLine(kangaroo(0, 3, 4, 2));

        //     Console.WriteLine(kangaroo(0, 2, 5, 3));
        // }
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 > v2 && x1 > x2 || v2 > v1 && x2 > x1)
            {
                return "NO";
            }

            // Case 2: If the kangaroos are moving at the same speed but started at different positions
            if (v1 == v2)
            {
                return x1 == x2 ? "YES" : "NO";
            }
            int relativePosition = Math.Abs(x2 - x1);
            int relativeSpeed = Math.Abs(v1 - v2);

            // If the relative position is divisible by the relative speed, they will meet
            if (relativePosition % relativeSpeed == 0)
            {
                return "YES";
            }

            return "NO";
        }
    }
}
