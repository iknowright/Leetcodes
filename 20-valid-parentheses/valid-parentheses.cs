public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack=new();
        char top;
        foreach(char c in s) {
            if(c is '{' or '[' or '(') stack.Push(c);
            else {
                if(stack.Count==0) return false;
                top=stack.Pop();
                if(c is ')' && top is not '(') return false;
                else if(c is '}' && top is not '{') return false;
                else if(c is ']' && top is not '[') return false;
            }
        }
        return stack.Count==0;
    }
}