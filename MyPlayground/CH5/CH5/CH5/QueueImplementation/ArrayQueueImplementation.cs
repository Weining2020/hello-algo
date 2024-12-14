/*
//基于环形数组实现的队列。

public class ArrayQueue
{
    int[] nums; //本队列的实现基于这个数组。
    int front;
    int queSize;
    public ArrayQueue(int capacity)
    {
        nums = new int[capacity];
        front = 0;
        queSize = 0;//在教程代码中，queSize 表示队列中当前有效元素的数量（即队列实际有多少个元素）。在队列刚初始化时，队列是空的，所以 queSize = 0。如果这里代码从 queSize 被初始化为0 修改成 queSize 被初始化为 capacity，这意味着队列一开始就被认为已经“满了”，这是不符合逻辑的，因为刚创建的队列实际上是空的。之后再联动Pop()和Push()来调整 队列元素的数量。
    }

    //获取队列的容量。
    public int Capacity()
    {
        return nums.Length;
    }
    //获取队列的长度。
    public int Size()
    {
        return queSize;
    }
    // 判断队列是否为空。
    public bool IsEmpty()
    {
        return queSize == 0;
    }
    //入队。
    public void Push(int n)
    {
        if (Size() == Capacity())
        {
            Console.WriteLine("队列已满");
            return;
        }
        int rear = (front + queSize) % Capacity(); //注意！！0%10 = 0。而对于空队列，第一个元素的索引从0开始是真理。通过nums[0]给第一个队列元素赋值，即Push()入队。这里没有判断是否为空队列，b/c无论空还是不空这里都能处置。
        nums[rear] = n;
        queSize++;
    }
    //出队。
    public int Pop()
    {
        if (IsEmpty()) throw new Exception();
        int res = Peek();
        front = (front + 1) % Capacity(); //别忘记队首指针向右移动一位，也是有可能越过数组尾部的，要做这种情况的处置。
        queSize--;
        return res;
    }
    //访问队首元素。
    public int Peek()
    {
        if (IsEmpty()) throw new Exception();
        return nums[front];
    }
    //返回数组。
    public int[] ToArray()
    {
        //if (IsEmpty()) return Array.Empty<int>(); //教程中的 ToArray() 方法没有检查队列是否为空，可能是基于以下逻辑和设计选择:在教程中，ToArray() 方法直接创建一个长度为 queSize 的新数组，并按队列中的元素顺序将数据复制到新数组中。即使队列为空时,queSize == 0，因此生成的新数组的长度也是 0,for 循环不会执行任何操作（因为循环条件 i < queSize 不满足）,最终返回一个空数组。
        int[] res = new int[Size()];
        for (int i = 0, j = front; i < Size(); i++, j++)
        {
            res[i] = nums[j % Capacity()]; //我仔细思考过了，我们遍历队列元素时，索引 j 可能会超过nums数组的长度, b/c i从0增长而j从front增长。这时，需要通过 j % Capacity() 让索引正确地循环到数组的起始位置。我看过ChatGPT给的具体的nums[j]可能会越界的例子，说服了我确实是这样的问题。
        }
        return res;
    }

}
*/