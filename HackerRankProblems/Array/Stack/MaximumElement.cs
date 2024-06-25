

namespace HackerRankProblems.Array.Stack
{
    internal class MaximumElement
    {
        public static void Main(string[] args)
        {
            
        }
        public static List<int> getMax(List<string> operations)
        {
            List<int> list = new List<int>();
            Stack<int> maxStack = new Stack<int>();
            foreach (var item in operations)
            {
                string[] strings = item.Split(' ');
               
                if (strings[0] == "1") // Push
                {
                    maxStack.Push(int.Parse(strings[1]));
                }
                else if (strings[0] == "2") // Pop 
                {
                    maxStack.Pop();
                }
                else if(strings[0] == "3") // getMax
                {
                    list.Add(maxStack.Max());
                }
            }
            return list;
        }
    }
}
