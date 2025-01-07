namespace HackerRankProblems.GeneralProblems
{
    internal class DailyTemperature
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            var stack = new Stack<int>();
            for (int i = 0; i < temperatures.Length; i++)
            {
                while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
                {
                    int prevIndex = stack.Pop();
                    temperatures[prevIndex] = i - prevIndex;
                }
                stack.Push(i);
            }
            while (stack.Count() > 0)
            {
                temperatures[stack.Pop()] = 0;
            }
            return temperatures;
        }
    }
}
