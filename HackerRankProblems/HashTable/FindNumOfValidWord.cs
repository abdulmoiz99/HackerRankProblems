namespace HackerRankProblems.HashTable
{
    internal class FindNumOfValidWord
    {
        //public static void Main(string[] args)
        //{

        //    string[] words = { "aaaa", "asas", "able", "ability", "actt", "actor", "access" };
        //    string[] puzzles = { "aboveyz", "abrodyz", "abslute", "absoryz", "actresz", "gaswxyz" };
        //    Console.WriteLine(FindNumOfValidWords(words, puzzles));
        //}
        public static IList<int> FindNumOfValidWords(string[] words, string[] puzzles)
        {
            var list = new List<int>();
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = CreateBitMask(words[i]);
            }
            for (int i = 0; i < puzzles.Length; i++)
            {
                puzzles[i] = CreateBitMask(puzzles[i]);
            }
            foreach (var puzzle in puzzles)
            {
                int count = 0;
                char letter = puzzle[0];
                var puzzleSet = new HashSet<char>(puzzle);
                foreach (var word in words)
                {
                    if (!Contains(word, letter)) continue;
                    bool isValid = true;
                    foreach (var ch in word)
                    {
                        if (!puzzleSet.Contains(ch))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid) count++;
                }
                list.Add(count);
            }
            return list;
        }
        static string CreateBitMask(string input)
        {
            int mask = 0;

            foreach (char c in input)
            {
                if (c >= 'a' && c <= 'z')
                {
                    int bitPosition = c - 'a';  
                    mask |= (1 << bitPosition); 
                }
            }

            return Convert.ToString(mask, 2).PadRight(26, '0');  
        }

        public static bool Contains(string word, char letter)
        {
            var set = new HashSet<char>(word);

            return set.Contains(letter);
        }
    }
}
