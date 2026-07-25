public class MinStack {
    public Stack<int> stack, minStack;
    public int min;
    public MinStack() {
        stack=new(); minStack=new();
    }
    
    public void Push(int value) {
        stack.Push(value);
        min = minStack.Count==0? value : Math.Min(value, minStack.Peek());
        minStack.Push(min);
    }
    
    public void Pop() {
        stack.Pop(); minStack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(value);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */