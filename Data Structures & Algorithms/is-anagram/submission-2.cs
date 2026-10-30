public class Solution
{
    public bool IsAnagram(string s, string t)
    {
       if(s.Length != t.Length){
        return false;
       }

       Dictionary<char,int> dt = new();

       foreach(char c in s){
        if(dt.ContainsKey(c)){
            dt[c] = dt[c] +1;
        }
        else{
            dt[c] = 1;
        }
       }

        foreach(char c in t){
        if(dt.ContainsKey(c)){
            dt[c] = dt[c] -1;
        }
        else{
            return false;
        }
       }

       foreach(var pair in dt){
        if(pair.Value !=0){
            return false;
        }
       }

        return true;
    }
}