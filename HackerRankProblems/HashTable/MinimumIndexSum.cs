
namespace HackerRankProblems.HashTable
{
    internal class MinimumIndexSum
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            var dictionary = new Dictionary<string, int>();
            for (int i = 0; i < list1.Count(); i++)
            {
                dictionary.Add(list1[i], i);
            }
            int min = Int32.MaxValue;
            var dictionaryResult = new Dictionary<string, int>();

            for (int i = 0; i < list2.Count(); i++)
            {
                if (dictionary.ContainsKey(list2[i]))
                {
                    int sum = dictionary[list2[i]] + i;
                    if (sum <= min)
                    {
                        min = sum;
                        dictionaryResult.Add(list2[i], min);
                    }
                }
            }
            var result = new List<string>();
            foreach (var item in dictionaryResult)
            {
                if (item.Value == min)
                    result.Add(item.Key);
            }
            return result.ToArray();
        }
    }
}
