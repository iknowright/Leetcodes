public class Solution {
    public int ScoreOfParentheses(string s) {
        Stack<int> stack=new();
        foreach(char c in s) {
            if(c is '(') stack.Push(-1);
            else {
                int sum=0;
                while(stack.Count>0 && stack.Peek() != -1) {
                    sum += stack.Pop();
                }

                stack.Pop();
                stack.Push((sum==0)? 1: 2*sum);
            }
            
        }

        int res=0;
        while(stack.Count>0) res+= stack.Pop();
        return res;
    }
}