namespace HackerRankProblems.HashTable
{
    internal class NextGreaterElementClass
    {
        //public static void Main(string[] args)
        //{
        //    int[] nums1 = { 4, 1, 2 };
        //    int[] nums2 = { 1, 3, 4, 2 };

        //    var result = NextGreaterElement(nums1, nums2);
        //    Console.WriteLine("---");
        //}
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var dictionary = new Dictionary<int, int>();
            var length = nums2.Length;

            for (int i = 0; i < length; i++)
            {
                dictionary.Add(nums2[i], nextGenerator(nums2, i + 1, nums2[i]));
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = dictionary[nums1[i]];
            }
            return nums1;
        }


        public static int nextGenerator(int[] nums, int startIndex, int value)
        {
            int result = -1;
            for (int i = startIndex; i < nums.Length; i++)
            {
                if (nums[i] > value)
                {
                    result = nums[i];
                    break;
                }
            }
            return result;
        }
    }
}
