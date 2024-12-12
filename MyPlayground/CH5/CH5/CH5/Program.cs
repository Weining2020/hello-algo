
//使用链表实现栈。

//在教程这个地方，没有ListNode这个类的代码。我写在这里是为了后面代码不报错。
public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int n)
    {
        val = n;
    }
}
public class LinkedListStack
{
    ListNode? stackPeek;
    int stkSize = 0;
    public LinkedListStack()
    {
        stackPeek = null;
    }
    public int Size()
    {
        return stkSize;
    }
    //判断栈是否为空。
    public bool IsEmpty()
    {
        return Size() == 0;
    }
    //入栈。
    public void Push(int n)
    {
        ListNode listNode = new ListNode(n)
        {
            next = stackPeek
        };
        stackPeek = listNode;
        stkSize++;
    }
    //出栈。
    public int Pop()
    {
        int res = Peek();
        stackPeek = stackPeek!.next;
        stkSize--;
        return res;
    }
    //访问栈顶元素。
    public int Peek()
    {
        if (IsEmpty())
        {
            throw new Exception();
        }
        return stackPeek!.val;
    }
    //将List转化为Array并返回。
    public int[] ToArray()
    {
        if (stackPeek == null)
        {
            return [];
        }
        ListNode? listNode = stackPeek;
        int[] res = new int[Size()];
        for (int i = stkSize - 1; i >= 0; i--)
        {
            res[i] = listNode!.val;
            listNode = listNode!.next;
        }
        return res;
    }
}
//////////////