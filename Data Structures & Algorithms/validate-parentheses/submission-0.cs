public class Solution {
    public bool IsValid(string k) {
        Stack<char> s = new Stack<char>();
        Dictionary<char,char> pairs = new Dictionary<char,char>{
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach(char c in k){
            if(c== '{' || c=='[' || c=='('){
                s.Push(c);
            }
            else if(c== '}' || c==']' || c==')'){
                if(s.Count ==0){
                    return false;
                }
                if(pairs[c]!=s.Peek()){
                    return false;
                }
                s.Pop();
            }
        }

        if(s.Count() != 0){
            return false;
        }

        return true;
    }
}
