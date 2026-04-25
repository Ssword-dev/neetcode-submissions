public class Solution {
    public int EvalRPN(string[] tokens) {
        var operands = new Stack<int>();

        foreach (var token in tokens) {
            if (
                token == "+" ||
                token == "-" ||
                token == "*" ||
                token == "/"
            ) {
                var rhs = operands.Pop();
                var lhs = operands.Pop();

                // the part where expressions are evaluated.
                var result = token switch {
                    "+" => lhs + rhs,
                    "-" => lhs - rhs,
                    "*" => lhs * rhs,

                    // the truncation thing comes naturally in c#
                    "/" => lhs / rhs,
                    _ => throw new NotImplementedException()
                };

                // push the same result into the operand stack
                // that way, it can be used by next operations or
                // returned later.
                operands.Push(result);
            } else {
                // an integer, not an operation, just push it.
                operands.Push(int.Parse(token));
            }
        }

        // the last operand is the final result.
        return operands.Pop();
    }
}
