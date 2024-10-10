namespace HackerRankProblems.Array
{
    internal class RotateArrayLeft
    {
        //public static void Main(string[] args)
        //{
        //    var list = rotateLeft(4, new List<int> { 1, 2, 3, 4, 5 });
        //    Console.WriteLine(list);
        //}
        public static List<int> rotateLeft(int d, List<int> arr)
        {
            for (int i = 0; i < d; i++)
            {
                arr = rotate(arr);
            }
            return arr;
        }
        public static List<int> rotate(List<int> arr)
        {
            for (int i = 0; i < arr.Count(); i++)
            {
                if (i + 1 < arr.Count())
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
            return arr;
        }
    }
}
