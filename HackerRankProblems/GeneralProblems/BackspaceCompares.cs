namespace HackerRankProblems.GeneralProblems
{
    internal class BackspaceCompares
    {
        public bool BackspaceCompare(string s, string t)
        {
            var stack1 = new Stack<char>();
            var stack2 = new Stack<char>();

            foreach (var item in s)
            {
                if (item == '#')
                {
                    if (stack1.Count > 0) stack1.Pop();
                }
                else stack1.Push(item);
            }
            foreach (var item in t)
            {
                if (item == '#')
                {
                    if (stack2.Count > 0) stack2.Pop();
                }
                else stack2.Push(item);

            }
            if (stack1.Count != stack2.Count) return false;

            while (stack1.Count > 0)
            {
                if (stack1.Pop() != stack2.Pop()) return false;
            }

            return true;
        }
    }
}
