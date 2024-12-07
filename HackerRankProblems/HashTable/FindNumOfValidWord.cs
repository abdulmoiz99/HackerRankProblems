namespace HackerRankProblems.HashTable
{
    internal class FindNumOfValidWord
    {
        public IList<int> FindNumOfValidWords(string[] words, string[] puzzles)
        {
            var list = new List<int>();

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

        public bool IsMatch(string puzzle, string word)
        {
            var set = new HashSet<char>(puzzle);
            foreach (var letter in word)
            {
                if (!set.Contains(letter)) return false;
            }
            return true;
        }
        public bool Contains(string word, char letter)
        {
            var set = new HashSet<char>(word);

            return set.Contains(letter);
        }
    }
}
