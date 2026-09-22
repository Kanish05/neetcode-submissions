public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> hs = new ();
        int right =0,n=s.Length,maxLen =0;

        for(int i=0;i<n;i++){
            while(right<n && hs.Add(s[right])){
                right++;
            }
            maxLen = Math.Max(maxLen,hs.Count());
            hs.Remove(s[i]);
        }

        return maxLen;
    }
}
