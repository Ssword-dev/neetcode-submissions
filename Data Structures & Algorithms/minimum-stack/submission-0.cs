// Constraint specifically says
// "pop, top and getMin will always be called on non-empty stacks."
// so i wont even implement a guard here.
public class MinStack {
    private Stack<(int Value, int MinSoFar)> _stack;

    public MinStack() {
        _stack = [];    
    }
    
    public void Push(int val) {
        var previousMin = _stack.Count != 0 ? _stack.Peek().MinSoFar : int.MaxValue;
        var newMin = Math.Min(previousMin, val);
        _stack.Push((val, newMin));
    }
    
    public void Pop() {
        _stack.Pop();
    }
    
    public int Top() {
        var entry = _stack.Peek();
        return entry.Value;
    }
    
    public int GetMin() {
        var entry = _stack.Peek();
        return entry.MinSoFar;
    }
}
