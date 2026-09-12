public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // if(strs.Length ==1){
        //     return strs.ToList();
        // }
        var res = new Dictionary<string,List<string>>();

        foreach (string s in strs){
            int[] arr = new int[26];
            foreach(char c in s){
                arr[c - 'a']++;
            }

            string key = string.Join(",",arr);

            if(!res.ContainsKey(key)){
                res[key] = new List<string>();
            }

            res[key].Add(s);
        }
    
        return res.Values.ToList<List<string>>();
    }
    
}
