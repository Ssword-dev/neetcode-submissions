public class Solution {
    public static Dictionary<char, char> closeToOpenMap = new () {
        {')', '('},
        {'}', '{'},
        {']', '['}
    };

    public bool IsValid(string s) {
        var stack = new Stack<char>();

        foreach (var c in s) {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }

            else {
                var openPair = closeToOpenMap[c];

                if (stack.Count == 0 || stack.Pop() != openPair) {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
