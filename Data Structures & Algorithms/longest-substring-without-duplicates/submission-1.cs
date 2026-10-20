public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> hs = new ();
        int right =0,n=s.Length,maxLenght =0;

        for(int i=0;i<n;i++){
            while(right<n && hs.Add(s[right])){
                right++;
            }
            maxLenght = Math.Max(maxLenght,hs.Count());
            hs.Remove(s[i]);
        }

        return maxLenght;
    }
}
