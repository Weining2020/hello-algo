using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH5
{
    internal class _5321
    {
        /*
//双向链表节点
class ListNode(int val)
{
    public int val = val;       // 节点值
    public ListNode? next = null; // 后继节点引用
    public ListNode? prev = null; // 前驱节点引用
}
//基于双向链表实现的双向队列
public class LinkedListDeque
{
    ListNode? front;    // 头节点 front, 尾节点 rear
    ListNode? rear;
    int queSize = 0;    // 双向队列的长度

    public LinkedListDeque()
    {
        front = null;
        rear = null;
    }
    //获取双向队列的长度
    public int Size()
    {
        return queSize;
    }
    //判断双向队列是否为空
    public bool IsEmpty()
    {
        return queSize == 0;
    }
    //入队操作
    void Push(int num, bool isFront)
    {
        ListNode node = new(num);
        // 若链表为空，则令 front 和 rear 都指向 node
        if (IsEmpty())
        {
            front = node;
            rear = node;
        }
        // 队首入队操作
        else if (isFront)
        {
            // 将 node 添加至链表头部
            front!.prev = node;
            node.next = front;
            front = node; // 更新头节点                           
        }
        // 队尾入队操作
        else
        {
            // 将 node 添加至链表尾部
            rear!.next = node;
            node.prev = rear;
            rear = node;  // 更新尾节点
        }

        queSize++; // 更新队列长度
    }
    //队首入队
    public void PushFirst(int num)
    {
        Push(num, true);
    }
    //队尾入队
    public void PushLast(int num)
    {
        Push(num, false);
    }
    //出队操作
    int? Pop(bool isFront)
    {
        if (IsEmpty())
            throw new Exception();
        int? val;
        // 队首出队操作
        if (isFront)
        {
            val = front?.val; // 暂存头节点值 //队列不为空 → front != null 且 rear != null（不变量保证）。所以 front?.val 里的 ? 完全是多余的防御，直接写 front!.val 或者断言后写更准确。
            // 删除头节点
            ListNode? fNext = front?.next;  

            if (fNext != null)  //这一步判断确实有必要，这里处理的是只有一个节点的边界情况，fNext 是 null，fNext.prev会触发NullReferenceException。
            {
                fNext.prev = null;
                front!.next = null;
            }
            front = fNext;   // 更新头节点
        }
        // 队尾出队操作
        else
        {
            val = rear?.val;  // 暂存尾节点值 //同理，所以 rear?.val 里的 ? 完全是多余的防御，直接写 rear!.val 或者断言后写更准确。
            // 删除尾节点
            ListNode? rPrev = rear?.prev;   
            if (rPrev != null)
            {
                rPrev.next = null;
                rear!.prev = null;
            }
            rear = rPrev;    // 更新尾节点
        }

        queSize--; // 更新队列长度
        return val;
    }
    //队首出队
    public int? PopFirst()
    {
        return Pop(true);
    }

    //队尾出队
    public int? PopLast()
    {
        return Pop(false);
    }
    //PeekFirst() 和 PeekLast() 的逻辑极其简单,两者之间没有任何共用逻辑，唯一的区别就是访问 front 还是 rear。没有必要强行封装一个int? Peek(bool isFront)。
    //访问队首元素
    public int? PeekFirst()
    {
        if (IsEmpty())
            throw new Exception();
        return front?.val;
    }

    //访问队尾元素
    public int? PeekLast()
    {
        if (IsEmpty())
            throw new Exception();
        return rear?.val;
    }

    //返回数组用于打印  //我完全理解教科书的写法。当然了，那些int?[]和ListNode?是教科书写法下 必要的妥协，因为教科书方法一上来没有用IsEmpty()来判空，因此双向队列确实有可能为空，也就得考虑双向队列为空的情况。
    public int?[] ToArray()
    {
        ListNode? node = front;
        int?[] res = new int?[Size()];
        for (int i = 0; i < res.Length; i++)
        {
            res[i] = node?.val;
            node = node?.next;
        }

        return res;
    }
}
*/
    }
}
