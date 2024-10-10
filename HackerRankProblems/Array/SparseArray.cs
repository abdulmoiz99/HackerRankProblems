namespace HackerRankProblems.Array
{
    internal class SparseArray
    {
        //public static void Main(string[] args)
        //{
        //    var list = matchingStrings(new List<string> { "ab", "ab", "abc" }, new List<string> { "ab", "abc", "bc" });
        //    Console.WriteLine(list);
        //}
        public static List<int> matchingStrings(List<string> stringList, List<string> queries)
        {
            var list = new List<int>();

            foreach (var query in queries)
            {
                int count = 0;

                foreach(var item in stringList)
                {
                    if(item == query)
                        count++;
                }
                list.Add(count);
            }

            return list;
        }
    }
}
