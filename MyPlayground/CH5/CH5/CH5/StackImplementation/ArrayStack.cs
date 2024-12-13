/*
 

/// 基于数组实现的栈 

class ArrayStack
{
    List<int> stack;
    //初始化列表。
    public ArrayStack()
    {
        stack = new List<int>();
    }
    //获取栈的长度。
    public int Size()
    {
        return stack.Count;
    }
    //判断栈是否为空。
    public bool IsEmpty()
    {
        return stack.Count == 0;
    }
    //入栈。
    public void Add(int n)
    {
        stack.Add(n);
    }
    //出栈。
    public int Pop()
    {
        if (IsEmpty()) throw new Exception();
        int value = Peek();
        stack.RemoveAt(Size() - 1);
        return value;
    }
    //访问栈顶元素。
    public int Peek()
    {
        if (IsEmpty()) throw new Exception();
        return stack[Size() - 1];
    }
    //将List转化为Array并返回。
    public int[] ToArray()
    {
        return [.. stack]; //这个很巧妙，还得再看看。
    }

}
*/