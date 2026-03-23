using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH5
{
    internal class _5322
    {
        /*
//基于环形数组实现的双向队列
public class ArrayDeque
{
    int[] nums;  // 用于存储双向队列元素的数组
    int front;   // 队首指针，指向队首元素
    int queSize; // 双向队列长度

    public ArrayDeque(int capacity)
    {
        nums = new int[capacity];
        front = 0;
        queSize = 0;
    }
    //获取双向队列的容量
    int Capacity()
    {
        return nums.Length;
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
    //计算环形数组索引
    int Index(int i)
    {
        // 通过取余操作实现数组首尾相连
        // 当 i 越过数组尾部后，回到头部 //这个好理解，不赘述。
        // 当 i 越过数组头部后，回到尾部 //我想过了，还真是这样，具体例子为front为0时，执行头部入队（不是头部出队），越过头部，front-1=-1了，没有-1这个索引，因此得先+Capacity()才能到底层数组尾部去，然后正常进行取余操作。
        return (i + Capacity()) % Capacity();
    }
    //队首入队
    public void PushFirst(int num)
    {
        if (Size() == Capacity())
        {
            Console.WriteLine("Full!");
            return;
        }

        // 队首指针向左移动一位
        // 通过取余操作实现 front 越过数组头部后回到尾部
        front = Index(front - 1);   //这里很容易写错成front + 1。
        // 将 num 添加至队首
        nums[front] = num;
        queSize++;
    }
    //队尾入队
    public void PushLast(int num)
    {
        if (Size() == Capacity())
        {
            Console.WriteLine("Full!");
            return;
        }

        // 计算队尾指针，指向队尾索引 + 1
        int rear = Index((front + queSize));
        // 将 num 添加至队尾
        nums[rear] = num;
        queSize++;
    }

    //队首出队
    public int PopFirst()
    {
        int num = PeekFirst();
        // 队首指针向后移动一位
        front = Index(front + 1);
        queSize--;
        return num;
    }
    //队尾出队
    public int PopLast()
    {
        int num = PeekLast();
        queSize--;
        return num;
    }
    //访问队首元素
    public int PeekFirst()
    {
        if (IsEmpty())
        {
            throw new Exception();
        }

        return nums[front];
    }
    //访问队尾元素
    public int PeekLast()
    {
        if (IsEmpty())
        {
            throw new Exception();
        }

        // 计算尾元素索引
        int last = Index(front + queSize - 1);  //这里很容易错误地直接写成last = front + queSize - 1，必须得考虑到尾部索引可能需要越过数组尾部。
        return nums[last];
    }
    //返回数组用于打印
    public int[] ToArray()
    {
        int[] res = new int[queSize];
        for (int i = 0, j = front; i < queSize; i++, j++)
        {
            res[i] = nums[Index(j)];
        }
        return res;
    }
}
*/
    }
}
