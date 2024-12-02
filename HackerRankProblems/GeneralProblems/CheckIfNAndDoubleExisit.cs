namespace HackerRankProblems.GeneralProblems
{
    internal class CheckIfNAndDoubleExisit
    {
        //public static void Main(string[] args)
        //{
        //    int[] nums = { 10, 2, 5, 3 };
        //    Console.WriteLine(CheckIfExist(nums));
        //}
        public static bool CheckIfExist(int[] arr)
        {
            var set = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int key = arr[i] * 2;
                if (!set.ContainsKey(key))
                    set.Add(key, i);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int key = arr[i];
                if (set.ContainsKey(key) && set[key] != i)
                    return true;
            }
            return false;
        }
    }
}
