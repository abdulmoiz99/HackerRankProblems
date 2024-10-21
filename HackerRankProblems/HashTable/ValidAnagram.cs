public class ValidAnagram {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        
        var map = new Dictionary<char, int>();

        foreach(var item in s){
            if(map.ContainsKey(item)){
                map[item] +=1;
            }
            else{
                map.Add(item, 1);
            }
        }
        foreach(var item in t){
            if(map.ContainsKey(item) && map[item] > 0){
                map[item] -=1;
            }
            else{
               return false;
            }
        }
        return true;
    }
}