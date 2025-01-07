public class MissingNumber {
    public int GetMissingNumbers(int[] nums) {
        for(int i = 0; i <= nums.Length; i++){
            if(!nums.Contains(i)) return i;
        }
        return -1;
    }
}