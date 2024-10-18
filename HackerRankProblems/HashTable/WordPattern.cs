public class WordPattern {
    public Dictionary<char, string> map = new Dictionary<char, string>();

    public bool WordPatternCheck(string pattern, string s) {
        var array = s.Split(" ");
        if(array.Length != pattern.Length) return false;
        for(int i = 0; i < pattern.Length; i++) {
           if(map.ContainsKey(pattern[i]) ){
                if(array[i] != map[pattern[i]])
                   return false;
           }
           else {
                if(validateIfValueExist(array[i])){
                    return false;
                }
                else map.Add(pattern[i] ,array[i]);
           }
        }
        return true;
    }
    public bool validateIfValueExist(string value){
        foreach(var item in map){
            if(item.Value == value) return true;
        }
        return false;
    }
}