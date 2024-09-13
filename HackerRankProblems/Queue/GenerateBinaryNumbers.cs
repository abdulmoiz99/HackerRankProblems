class GenerateBinaryNumbers
{
    public List<string> generate(int N)
    {
        List<string> binaryNumbers = new List<string>();
        if (N <= 0) return binaryNumbers;

        for (int i = 1; i <= N; i++)
        {
            string number = Convert.ToString(i, 2);
            binaryNumbers.Add(number);
        }
        return binaryNumbers;
    }
}