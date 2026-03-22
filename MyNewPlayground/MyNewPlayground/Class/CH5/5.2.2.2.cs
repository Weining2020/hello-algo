using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH5
{
    internal class _5222
    {
        /*
//基于环形数组实现的队列
public class ArrayQueue
{
    int[] nums;
    int front;
    int queSize;

    public ArrayQueue(int capacity)
    {
        nums = new int[capacity];
        front = 0;
        queSize = 0;
    }

    public int Capacity()
    {
        return nums.Length;
    }

    public int Size()
    {
        return queSize;
    }

    public bool IsEmpty()
    {
        return queSize == 0;
    }

    public int Peek()
    {
        if (Size() == 0)
        {
            throw new Exception();
        }

        return nums[front];
    }

    public void Push(int num)
    {
        if (Size() == Capacity())
        {
            Console.WriteLine("Full!");
            return;
        }

        // 计算队尾指针，指向队尾索引 + 1
        // 通过取余操作实现 rear 越过数组尾部后回到头部
        int rear = (front + queSize) % Capacity();
        // 将 num 添加至队尾
        nums[rear] = num;
        queSize++;
    }

    public int Pop()
    {
        int num = Pop();
        front = (front + 1) % Capacity();
        queSize--;
        return num;
    }

    public int[] ToArray()
    {
        //教程中的 ToArray() 方法没有检查队列是否为空，可能是基于以下逻辑和设计选择:在教程中，ToArray() 方法直接创建一个长度为 queSize 的新数组，并按队列中的元素顺序将数据复制到新数组中。即使队列为空时,queSize == 0，因此生成的新数组的长度也是 0,for 循环不会执行任何操作（因为循环条件 i < queSize 不满足）,最终返回一个空数组。

        // 仅转换有效长度范围内的列表元素
        int[] res = new int[Size()];
        for (int i = 0, j = front; i < Size(); i++, j++)
        {
            res[i] = nums[j % Capacity()];
        }

        return res;
    }
}
*/
    }
}
