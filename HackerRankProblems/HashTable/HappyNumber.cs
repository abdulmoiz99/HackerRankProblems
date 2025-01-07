public class HappyNumber {
  public bool IsHappy(int n) {
    var map = new Dictionary<int, int>();

    var numbers = NumbersIn(n);
    int sum = 0;
    for (int j = 0; j < 10; j++) {
      for (int i = 0; i < numbers.Length; i++) {
        if(map.ContainsKey(numbers[i])){
            sum+= map[numbers[i]];
        }
        else{
            int square = Convert.ToInt32(Math.Pow(Convert.ToDouble(numbers[i]), 2));
            map.Add(numbers[i], square);
            sum += square;
        }
      }
      //if(sum == 1) return true;
      //  sum += Convert.ToInt32(Math.Pow(Convert.ToDouble(numbers[i]), 2));
      //numbers = NumbersIn(sum);
      //sum =0;
    }

    return false;
  }
  public int[] NumbersIn(int value) {
    var numbers = new Stack < int > ();

    for (; value > 0; value /= 10)
      numbers.Push(value % 10);

    return numbers.ToArray();
  }
}