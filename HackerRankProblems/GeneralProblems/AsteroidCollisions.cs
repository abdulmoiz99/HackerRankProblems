
namespace HackerRankProblems.GeneralProblems
{
    internal class AsteroidCollisions
    {
        //public static void Main(string[] args)
        //{
        //    int[] nums = { -2, -1, 1, 2 };
        //    Console.WriteLine(AsteroidCollision(nums));
        //}
        public int[] AsteroidCollision(int[] asteroids)
        {
            var stack = new Stack<int>();

            foreach (var asteroid in asteroids)
            {
                bool destroyed = false;

                while (stack.Count > 0 && asteroid < 0 && stack.Peek() > 0)
                {
                    int top = stack.Pop();
                    if (Math.Abs(asteroid) == top)
                    {
                        destroyed = true;
                        break;
                    }
                    else if (Math.Abs(asteroid) < top)
                    {
                        stack.Push(top);
                        destroyed = true;
                        break;
                    }
                }

                if (!destroyed)
                {
                    stack.Push(asteroid);
                }
            }

            return stack.Reverse().ToArray();
        }
    }
}
