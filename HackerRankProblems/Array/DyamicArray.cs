namespace HackerRankProblems.Array
{
    internal class DyamicArray
    {
        public static void Main(string[] args)
        {
            List<List<int>> list = new List<List<int>>();
            list.Add(new List<int> { 1, 0, 5 });
            list.Add(new List<int> { 1, 1, 7 });
            list.Add(new List<int> { 1, 0, 3 });
            list.Add(new List<int> { 2, 1, 0 });
            list.Add(new List<int> { 2, 1, 1 });


            var list1 = dynamicArray(2, list);


            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

        }
        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            List<List<int>> seqList = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                seqList.Add(new List<int>());
            }
            int lastAns = 0, idx = 0, x = 0, y = 0, query = 0;

            List<int> result = new List<int>();

            foreach (var list in queries)
            {
                query = list[0];
                x = list[1];
                y = list[2];

                idx = (x ^ lastAns) % n;

                if (query == 1)
                {
                    seqList[idx].Add(y);
                }
                else if (list[0] == 2)
                {
                    int size = seqList[idx].Count;
                    lastAns = seqList[idx][y % size];
                    result.Add(lastAns);
                }
            }
            return result;
        }
    }
}
