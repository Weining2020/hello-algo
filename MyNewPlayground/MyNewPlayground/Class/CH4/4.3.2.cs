using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH4
{
    internal class _432
    {
/*
//列表类
public class MyList
{
    private int[] arr;           // 数组（存储列表元素）
    private int arrCapacity = 10;    // 列表容量
    private int arrSize = 0;         // 列表长度（当前元素数量）
    private readonly int extendRatio = 2;  // 每次列表扩容的倍数
    //构造方法
    public MyList()
    {
        
        arr = new int[arrCapacity];
    }
    //获取列表长度（当前元素数量）
    public int Size()
    {
        return arrSize;
    }

    //获取列表容量
    public int Capacity()
    {
        return arrCapacity;
    }

    //访问元素
    public int Get(int index)
    {
        // 索引如果越界，则抛出异常，下同
        if (index < 0 || index >= arrSize)
            throw new IndexOutOfRangeException("索引越界");
        return arr[index];
    }

    //更新元素
    public void Set(int index, int num)
    {
        if (index < 0 || index >= arrSize)
            throw new IndexOutOfRangeException("索引越界");
        arr[index] = num;
    }

    //在尾部添加元素
    public void Add(int num)
    {
        if (arrSize == arrCapacity)
        {
            ExtendCapacity();
        }
        arr[arrSize] = num;
        arrSize++;
    }

    //在中间插入元素
    public void Insert(int index, int num)
    {
        if (index < 0 || index >= arrSize)
            throw new IndexOutOfRangeException("索引越界");
        if (arrSize == arrCapacity)
        {
            ExtendCapacity();
        }
        for (int j = arrSize - 1; j >= index; j--)
        {
            arr[j + 1] = arr[j];
        }
        arr[index] = num;
        arrSize++;
    }

    //删除元素
    public int Remove(int index)
    {
        if (index < 0 || index > arrSize)
            throw new IndexOutOfRangeException("索引越界");
        int num = arr[index];
        for (int j = index; j < arrSize - 1; j++)
        {
            arr[j] = arr[j + 1];
        }
        arrSize--;
        return num;
    }

    //列表扩容
    public void ExtendCapacity()
    {
        Array.Resize(ref arr, arrSize);
        arrCapacity = arr.Length;
    }

    //将列表转换为数组
    public int[] ToArray()
    {
        // 仅转换有效长度范围内的列表元素
        int[] arr = new int[arrSize];
        for (int i = 0; i < arrSize; i++)
        {
            arr[i] = Get(i);
        }
        return arr;
    }
}
*/
    }
}
