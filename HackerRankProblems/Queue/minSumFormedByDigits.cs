namespace minSumFormedByDigits
{
    class Diver
    {
        // static void Main(String[] args)
        // {

        //     Solution solution = new Solution();

        //     // Example test case
        //     int[] arr = { 9, 8, 4, 6, 4, 8, 9, 2 };
        //     int n = arr.Length;

        //     long result = solution.minSum(arr, n);

        //     Console.WriteLine("The minimum sum is: " + result);
        // }
    }
    class Solution
    {
        //Complete this function
        public long minSum(int[] arr, int n)
        {
            Array.Sort(arr);
            string number1 = "";
            string number2 = "";


            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    number1 += arr[i];
                }
                else number2 += arr[i];
            }
            long variable1 = 0, variable2 = 0;
            if (!number1.Equals(""))
            {
                variable1 = long.Parse(number1);
            }
            if (!number2.Equals(""))
            {
                variable2 = long.Parse(number2);
            }
            return variable1 + variable2;
        }
    }

}