public class Solution {
    public int EvalRPN(string[] tokens) {
        var operands = new Stack<int>();
        var i = 0;

        int EvaluateOperation(string op) {
            var rhs = operands.Pop()!;
            var lhs = operands.Pop()!;

            return op switch {
                "+" => lhs + rhs,
                "-" => lhs - rhs,
                "*" => lhs * rhs,
                "/" => lhs / rhs,  // truncation always truncate towards 0 in c#
                _ => throw new NotImplementedException()
            };
        }

        while (i < tokens.Length) {
            var currentToken = tokens[i];

            // current token is an operator
            if (
                currentToken == "+" ||
                currentToken == "-" ||
                currentToken == "*" ||
                currentToken == "/"
            ) {
                operands.Push(EvaluateOperation(currentToken));
            } else {
                operands.Push(int.Parse(currentToken));
            }

            i++;
        }

        return operands.Pop();
    }
}
