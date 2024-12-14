/*
//基于链表的实现。
public class ListNode //教程没写，我写了，为了不报错。
{
    public int val;
    public ListNode? next;
    public ListNode(int n)
    {
        val = n;
    }
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
    //这里要说一下，下面这个Push()声明是我自己写的，我问了ChatGPT这个写法没有错。if (IsEmpty()) 处理了队列为空的情况，对于非空队列，直接将 rear.next 指向新节点，再更新 rear，不需要多余的 else if 判断。那我保留我的写法。
    public void Push(int n)
    {
        ListNode listNode = new ListNode(n);
        if (IsEmpty())
        {
            front = listNode;
            rear = listNode;
        }
        rear.next = listNode;
        rear = listNode;
        queSize++;
    }

    //出队。
    public int Pop()
    {
        //if (IsEmpty()) throw new Exception(); //这一行确实不用写，因为Peek()有判断是否队列为空队列。
        int res = Peek();
        front = front.next;
        queSize--; //别忘了队列长度减一。
        return res;
    }

    //访问队首元素。
    public int Peek()
    {
        if (IsEmpty()) throw new Exception();
        int res = front.val;
        return res;
    }

    //将链表转化为队列并返回。
    public int[] ToArray() //我自己就写出来了，不难。
    {
        if (IsEmpty())
        {
            return Array.Empty<int>();
        }
        int[] array = new int[Size()];
        ListNode listNode = front;
        for (int i = 0; i < queSize; i++)
        {
            array[i] = listNode.val;
            listNode = listNode.next;
        }
        return array;
    }
}
*/