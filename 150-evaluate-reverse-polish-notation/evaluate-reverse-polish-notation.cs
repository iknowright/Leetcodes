public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack=new();
        int num;
        foreach(string token in tokens) {
            if(token is "+") {
                num = stack.Pop()+stack.Pop();
                stack.Push(num);
            }
            else if(token is "-") {
                num = -1*stack.Pop() + stack.Pop();
                stack.Push(num);
            }
            else if(token is "*") {
                num = stack.Pop()*stack.Pop();
                stack.Push(num);
            }
            else if(token is "/") {
                num = (int)(Math.Pow(stack.Pop(), -1)* stack.Pop());
                stack.Push(num);
            }
            else stack.Push(int.Parse(token));
        }
        return stack.Pop();
    }
}