/*
public class MaxHeap
{
    List<int> maxHeap;
    //构造函数，根据输入列表建堆。
    public MaxHeap(IEnumerable<int> nums)
    {
        maxHeap = new List<int>(nums);
        var size = Parent(Size() - 1); //这句代码目的：找到最后一个非叶子节点的索引，记为 size。Size() - 1 得到最后一个节点的index。Parent(Size() - 1)得到 得到最后一个节点的 父节点的index。
        for (int i = size; i >= 0; i--) //从最后一个非叶子节点 向堆顶 开始遍历节点，并对遍历到的节点进行从顶至底堆化。
        {
            SiftDown(i);
        }

    }
    void SiftDown(int i) //从顶至底堆化。
    {
        while (true)
        {
            int ma = i; //设m变量，使m为l,r,i三者中值最小的值。
            int l = Left(i);
            int r = Right(i);
            if (l < Size() && maxHeap[l] > maxHeap[ma])
            {
                ma = l;
            }
            if (r < Size() && maxHeap[r] > maxHeap[ma])
            {
                ma = r;
            }
            Swap(i, ma);
            i = ma;
        }
    }
    //访问堆顶元素。
    int Peek()
    {
        return maxHeap[0];
    }
    //交换元素。
    void Swap(int i, int p) //这是教程没写的，但是在教程Github有代码。应该是简单的集合内元素互换。
    {
        (maxHeap[i], maxHeap[p]) = (maxHeap[p], maxHeap[i]);
    }
    //获取堆大小。 //这是教程没写的，但是在教程Github有代码。应该是简单的集合内元素互换。
    public int Size()
    {
        return maxHeap.Count;
    }

    //判断堆是否为空。
    public bool IsEmpty()
    {
        return Size() == 0;
    }
    //将索引映射公式封装成函数，方便后续使用：
    //获取左子节点的索引。
    int Left(int i)
    {
        return 2 * i + 1;
    }
    //获取右子节点的索引。
    int Right(int i)
    {
        return 2 * i + 2;
    }
    //获取父节点的索引。
    int Parent(int i)
    {
        return (i - 1) / 2; // 向下整除
    }

}
}
*/