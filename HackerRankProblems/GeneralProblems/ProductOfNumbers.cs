namespace HackerRankProblems.GeneralProblems
{
    internal class ProductOfNumbers
    {
        List<int> values;
        public ProductOfNumbers()
        {
            values = new List<int>();
        }

        public void Add(int num)
        {
            values.Add(num); ;
        }

        public int GetProduct(int k)
        {
            var startIndex = (values.Count - k);
            int product = 1;
            for (int i = startIndex; i < values.Count; i++)
            {
                if (values[i] == 0) return 0;
                product *= values[i];
            }
            return product;
        }
    }
}
