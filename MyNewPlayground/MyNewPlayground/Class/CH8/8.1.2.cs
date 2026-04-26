using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH8
{
    internal class _812
    {/*
List<int> maxHeap = [];
/////////////////////////////
int Left(int i)
{
    return 2 * i + 1;
}
int Right(int i)
{
    return 2 * i + 2;
}
int Parent(int i)
{
    return (i - 1) / 2;
}
int Peek()
{
    return maxHeap[0];
}
void Push(int val)
{
    maxHeap.Add(val);
    SiftUp(Size() - 1);
}
void SiftUp(int i)
{
    while (true)
    {
        int p = Parent(i);
        if (p < 0 || maxHeap[i] <= maxHeap[p]) //20260425补充：入堆时新节点从堆底插入，然后执行从底至顶堆化（sift up）：每次只和父节点比较，满足条件就交换，不满足就停止。关键保证是：新节点插入之前，堆已经是一个合法的堆。 所以除了"新节点所在的那条路径"，其余所有节点的父子关系都没有被动过，它们仍然满足堆的性质。
        {
            break;
        }

        Swap(p, i);
        i = p;
    }
}
int Pop()
{
    if (IsEmpty())
    {
        throw new IndexOutOfRangeException();
    }
    Swap(0, Size() - 1);
    int last = maxHeap.Last();
    maxHeap.RemoveAt(Size() - 1));
    SiftDown(0);
    return last;
}
void SiftDown(int i)
{
    while (true)
    {
        int l = Left(i);
        int r = Right(i);
        int ma = i;
        if (l < Size() && maxHeap[l] > maxHeap[ma])  //三者取，我不会。
        {
            ma = l;
        }

        if (r < Size() && maxHeap[r] > maxHeap[ma])  //三者取，我不会。
        {
            ma = r;
        }

        if (ma == i)
        {
            break;
        }

        Swap(i, ma);
        i = ma;
    }
}
*/
    }
}
