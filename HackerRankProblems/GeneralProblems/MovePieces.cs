namespace HackerRankProblems.GeneralProblems
{
    internal class MovePieces
    {

        public static void Main(string[] args)
        {
            string start = "_L__R__R_";
            string target = "L______RR";
            Console.WriteLine(CanChange(start, target));
        }

        public static bool CanChange(string start, string target)
        {
            if (start.Length != target.Length) return false;

            (int sLeft, int sRight) = CountLR(start);
            (int tLeft, int tRight) = CountLR(target);

            if (sLeft != tLeft && sRight != tRight) return false;


            char[] str1 = start.ToCharArray();
            int lastLeftIndex = -1;
            for (int i = 0; i < start.Length; i++)
            {
                var value = new string(str1);
                if (value.Equals(target))
                    return true;

                if (str1[i] != target[i])
                {
                    if (str1[i] == '_' && target[i] == 'L')
                    {
                        int index = GetLeftIndex(i, start, lastLeftIndex);
                        if (index == -1) return false;
                        lastLeftIndex = index;
                        (str1[index], str1[i]) = (str1[i], str1[index]);
                    }
                    if (str1[i] == 'R' && target[i] == '_')
                    {
                        int index = GetRightIndex(i, start);
                        if (index == -1) return false;

                        (str1[index], str1[i]) = (str1[i], str1[index]);
                    }
                }

            }
            return false;
        }
        public static int GetLeftIndex(int startIndex, string start, int lastLeftIndex)
        {
            if (lastLeftIndex != -1) startIndex = lastLeftIndex;

            for (int i = startIndex; i < start.Length; i++)
            {
                if (start[i] == 'R') return -1;
                else if (start[i] == 'L') return i;
            }
            return -1;
        }
        public static int GetRightIndex(int startIndex, string start)
        {
            int index = startIndex;
            for (int i = startIndex; i < start.Length; i++)
            {
                if (start[i] == 'L')
                {
                    return startIndex == i ? -1 : i;
                }
                index++;
            }
            return index - 1;
        }
        public static (int, int) CountLR(string value)
        {
            int left = 0; int right = 0;
            foreach (var c in value)
            {
                if (c == 'L') left++;
                else if (c == 'R') right++;
            }
            return (left, right);
        }
    }
}
