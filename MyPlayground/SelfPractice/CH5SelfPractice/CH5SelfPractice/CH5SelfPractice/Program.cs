using CH5SelfPractice.utils;

public class ArrayQueue
{
    public int[] nums;
    public int front;
    public int queueSize;
    public ArrayQueue(int capacity)
    {
        nums = new int[capacity];
        front = 0;
        queueSize = 0;
    }

    public int Capacity()
    {
        return nums.Length;
    }
    public int Size()
    {
        return queueSize;
    }
    public bool IsEmpty()
    {
        return Size() == 0;
    }
    public int Peek()
    {
        if (IsEmpty())
        {
            throw new Exception();
        }
        return nums[front];
    }
    public void Push(int num)
    {
        if (Size() == queueSize)
        {
            Console.WriteLine("full!");
            return;
        }

        int rear = (front + Size()) % Capacity();
        nums[rear] = num;
        queueSize++;
    }
    public int Pop()
    {
        int peek = Peek();
        front = (front + 1) & queueSize;
        queueSize--;
        return peek;
    }
    public int[] ConvertToArray()
    {
        if (IsEmpty())
        {
            throw new Exception();
        }

        int[] resArray = new int[Size()];
        for (int i = 0, j = front; i < resArray.Length; i++, j++)
        {
            resArray[i] = nums[j % queueSize];
        }
        return resArray;
    }
}




