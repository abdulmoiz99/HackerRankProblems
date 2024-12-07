namespace HackerRankProblems.GeneralProblems
{
    internal class MovePieces
    {
        static int leftPointer, rightPointer;
        public static void Main(string[] args)
        {
            string start = "_R";
            string target = "R_";
            Console.WriteLine(CanChange(start, target));
        }

        public static bool CanChange(string start, string target)
        {
            if (start.Length != target.Length) return false;

            leftPointer = 0;
            rightPointer = start.Length - 1;

            foreach (var c in target)
            {
                if (c == 'L' && !HasValidLeft(start))
                {
                    return false;
                }
                else if (c == 'R' && !HasValidRight(start))
                {
                    return false;
                }
            }
            return true;

        }
        public static bool HasValidLeft(string value)
        {
            while (leftPointer < rightPointer)
            {
                if (value[leftPointer] == 'R') return false;

                else if (value[leftPointer] == 'L')
                {
                    leftPointer++;
                    return true;
                }
                leftPointer++;
            }
            return false;
        }

        public static bool HasValidRight(string value)
        {
            while (leftPointer < rightPointer)
            {
                if (value[rightPointer] == 'L') return false;

                else if (value[rightPointer] == 'R' && rightPointer - 1 > 0 && value[rightPointer - 1] == '_')
                {
                    rightPointer--;
                    return true;
                }
                rightPointer--;
            }
            return false;
        }
    }
}
