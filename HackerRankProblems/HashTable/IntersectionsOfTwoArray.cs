using System;

namespace HackerRankProblems.HashTable
{
    internal class IntersectionsOfTwoArray
    {
        //public static void Main(string[] args)
        //{

        //    //int[] num1 = { 1, 2, 2, 1 };
        //    //int[] num2 = { 2, 2 };
        //    //var result = Intersect(num1, num2);
        //    //foreach (var item in result)
        //    //{
        //    //    Console.WriteLine(item);
        //    //}


        //    int[] num3 = { 4, 9, 5 };
        //    int[] num4 = { 9, 4, 9, 8, 4 };
        //    var result = Intersect(num3, num4);
        //    foreach (var item in result)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            System.Array.Sort(nums1);
            System.Array.Sort(nums2);

            int index = 0;
            var list = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (index >= nums2.Length) break;
                if (nums1[i] == nums2[index])
                {
                    list.Add(nums1[i]);
                    index++;
                }
            }
            return list.ToArray();
        }
    }
}
