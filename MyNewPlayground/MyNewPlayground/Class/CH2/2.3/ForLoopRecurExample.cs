/*
Console.WriteLine(ForLoopRecur(10));
int ForLoopRecur(int n)
{
    Stack<int> stack = new Stack<int>();
    int res = 0;
    for (global::System.Int32 i = n; i > 0; i--)
    {
        stack.Push(i);
    }
    while (stack.Count > 0)
    {
        res += stack.Pop();
    }
    return res;
}


*/