namespace HackerRankProblems.Array
{
    internal class ArrayManipulation
    {
        //public static void Main(string[] args)
        //{
        //    List<List<int>> list = new List<List<int>>();
        //    list.Add(new List<int> { 1, 2, 100 });
        //    list.Add(new List<int> { 2, 5, 100 });
        //    list.Add(new List<int> { 3, 4, 100 });
        //    Console.WriteLine(arrayManipulation(5, list));
        //}
        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            var arr = new long[n];
            int a = 0, b= 0, k = 0;
            foreach (var list in queries)
            {
                a = list[0];
                b = list[1];
                k = list[2];
                for (int i = a; i < b; i++)
                {
                    arr[i] += k;
                }
            }
            return arr.Max();
        }
    }
}
