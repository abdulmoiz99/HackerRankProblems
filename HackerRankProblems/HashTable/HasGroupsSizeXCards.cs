namespace HackerRankProblems.HashTable
{
    internal class HasGroupsSizeXCards
    {
        //public static void Main(string[] args)
        //{
        //    int[] deck = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3 };
        //    Console.WriteLine(HasGroupsSizeX(deck));
        //}
        public static bool HasGroupsSizeX(int[] deck)
        {
            var set = new Dictionary<int, int>();
            foreach (var item in deck)
            {
                if (set.ContainsKey(item))
                    set[item]++;
                else set.Add(item, 1);
            }

            bool allEven = true;
            foreach (var item in set.Values)
            {
                if (item % 2 != 0)
                {
                    allEven = false;
                    break;
                }
            }
            if (allEven) return true;

            return true;
        }

    }
}
