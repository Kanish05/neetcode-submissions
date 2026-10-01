public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> st = new Stack<int>();
        foreach(var c in tokens){
            if(int.TryParse(c,out int number)){
                st.Push(number);
            }
            else{
                int right = st.Pop();
                int left = st.Pop();
                if(c=="+" || c== "*"){
                    st.Push(c == "+" ? left + right : left * right);
                }
                else if(c=="-"){
                    st.Push(left-right);
                }
                else if (c == "/")
                {
                    st.Push(left / right);
                }
            }
        }
        return st.Peek();
    }
}
