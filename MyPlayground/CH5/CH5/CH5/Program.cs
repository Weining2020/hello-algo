//基于链表的实现。
public class ListNode //教程没写，我写了，为了不报错。
{
    public int val;
    public ListNode? next;
}
public class LinkedListQueue
{
    public ListNode? front;
    public ListNode? rear;
    public int queSize;
    //初始化。
    public LinkedListQueue()
    {
        front = null;
        rear = null;
    }
    //获取队列的长度。
    public int Size()
    {
        return queSize;
    }
    //判断队列是否为空。
    public bool IsEmpty()
    {
        return queSize == 0;
    }
    //入队。
    public void Add(int n)
    {
        if (IsEmpty())
        {
            
        }
        queSize++;
    }
}