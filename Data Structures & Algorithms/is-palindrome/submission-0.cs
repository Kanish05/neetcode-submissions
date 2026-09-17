public class Solution {
    public bool IsPalindrome(string s) {
        // char start = s[0];
        // char end = s[s.Length -1];
        int start = 0;
        int end = s.Length-1;
        while(start<end){
            if (!char.IsLetterOrDigit(s[start])) {
                start++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[end])) {
                end--;
                continue;
            }

            if(char.ToLower(s[start]) != char.ToLower(s[end])){
                return false;
            }
            else{
                start++;
                end--;
            }
        }
        return true;
    }
}
