namespace HackerRankProblems.Array.Stack
{
    internal class Waiter
    {
        //public static void Main(string[] args)
        //{
        //    List<int> h1 = new List<int> { 3, 4, 7, 6, 5 };
        //    waiter(h1, 1);

        //}
        public static int[] GeneratePrimes(int n)
        {
            List<int> primes = new List<int>();
            int number = 2; // Start with the first prime number

            while (primes.Count < n)
            {
                if (IsPrime(number))
                {
                    primes.Add(number);
                }
                number++;
            }

            return primes.ToArray();
        }
        private static bool IsPrime(int number)
        {
            if (number < 2) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
        public static List<int> waiter(List<int> number, int q)
        {
            List<int> answers = new List<int>();
            var B = new Stack<int>();
            int[] prime = GeneratePrimes(q);
            number.Reverse();
            for (int i = 0; i < q; i++)
            {
                for (int j = 0; j < number.Count(); j++)
                {
                    if (number[j] % prime[i] == 0)
                    {
                        B.Push(number[j]);
                        number.RemoveAt(j);
                        j--;
                    }
                }
                number.Reverse();
                while (B.Count() > 0)
                {
                    answers.Add(B.Pop());
                }
            }
            answers.AddRange(number);
            return answers;
        }
    }
}
