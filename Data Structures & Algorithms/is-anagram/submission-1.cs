public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

       Dictionary<char,int> dt = new Dictionary<char,int>();

       foreach (char ch in s){
            dt[ch] = dt.GetValueOrDefault(ch,0) + 1;
       } 

       foreach (char ch in t){
            dt[ch] = dt.GetValueOrDefault(ch,0) - 1;
       }

       foreach (var pair in dt){
        if(pair.Value != 0){
            return false;
        }
       }
       return true;
    }
}