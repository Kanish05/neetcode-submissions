public class Solution {
    public bool IsValid(string k) {
        Stack<char> st = new Stack<char>();
         Dictionary<char,char> dt = new Dictionary<char,char>{
            {')','('},
            {'}','{'},
            {']','['}
        };

        foreach(char c in k){
            if(c == '{' || c== '[' || c=='('){
                st.Push(c);
            }
            else if(c=='}' || c == ']' || c==')'){
                if(st.Count ==0){
                    return false;
                }

                if(dt[c] != st.Peek()){
                    return false;
                }

                st.Pop();
            }
        }

        if(st.Count() != 0){
            return false;
        }

        return true;
    }
}
