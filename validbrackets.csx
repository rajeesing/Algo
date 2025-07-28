bool AreBracketsBalanced(string input)
{
    Stack<char> stack = new Stack<char>();
    foreach (char c in input)
    {
        if (c == '(' || c == '{' || c == '[')
        {
            stack.Push(c);
        }
        else if (c == ')' || c == '}' || c == ']')
        {
            if (stack.Count == 0) return false;
            char open = stack.Pop();
            if (!IsMatchingPair(open, c)) return false;
        }
    }
    return stack.Count == 0;
}


bool IsMatchingPair(char open, char close)
{
    return (open == '(' && close == ')') ||
           (open == '{' && close == '}') ||
           (open == '[' && close == ']');
}
Console.WriteLine(AreBracketsBalanced("()){}[]"));
