/*

List<int> maxHeap = new List<int> { 9, 8, 6, 6, 7, 5, 2, 1, 4, 3, 6, 2 }; //这个教程没有，是我根据图8-2写的列表来表示堆，用于配合展示教程里其他相关的 堆的操作，不然会报错，maxHeap没有声明。之所以用列表，是考虑到可能相关操作包括插入节点。

//为了展示 堆的相关操作，我们声明一个MaxHeap类，底层用列表实现，这是教程没写的，但是在教程Github有代码。
public class MaxHeap
{
    List<int> maxHeap;

    //构造函数，建立空堆。
    public MaxHeap() //这是教程没写的，但是在教程Github有代码。应该是简单的集合内元素互换。
    {
        maxHeap = [];
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
    //元素入堆。
    void Push(int val)
    {
        // 添加节点
        maxHeap.Add(val);
        // 从底至顶堆化
        SiftUp(Size() - 1); //确实是从第(Size() - 1)个节点（即最后一个节点）开始堆化，没错。
    }
    //从节点 i 开始，从底至顶堆化 //这个方法不难写，只是需要 想到利用这些方法才行。
void SiftUp(int i)
{
    while (true)
    {
        // 获取节点 i 的父节点
        int p = Parent(i); //这是调用映射公式。
                           // 若“越过根节点”或“节点无须修复”，则结束堆化
        if (p < 0 || maxHeap[i] <= maxHeap[p])
            break;
        // 交换两节点
        Swap(i, p); //这是在集合内交换两个元素。
                    // 循环向上堆化
        i = p;
    }
}

//元素出堆。
int Pop()
{
    // 判空处理。//别忘了处理堆为空的情况。
    if (IsEmpty())
        throw new IndexOutOfRangeException();
    int res = maxHeap[0];
    // 交换根节点与最右叶节点（交换首元素与尾元素）
    Swap(0, Size() - 1);

    // 删除节点。
    int val = maxHeap.Last(); //没见过这个Last()方法。拿到值准备在最后返回出方法。
    maxHeap.RemoveAt(Size() - 1); //嗯，得用RemoveAt()。

    // 从顶至底堆化
    SiftDown(0);

    // 返回堆顶元素
    return val;
}
//从节点 i 开始，从顶至底堆化。
void SiftDown(int i)
{
    while (true)
    {
        // 判断节点 i, l, r 中值最大的节点，记为 ma。三者间比较取最大值，这个写法我得多看看学会才行。
        int l = Left(i), r = Right(i), ma = i;
        if (l < Size() && maxHeap[l] > maxHeap[ma])
            ma = l;
        if (r < Size() && maxHeap[r] > maxHeap[ma])
            ma = r;

        // 若“节点 i 最大”或“越过叶节点”，则结束堆化
        if (ma == i) //这里我详细讲一下。ma == i有多种来源。第一种，当上面两个if都不满足时，ma会保持i值，这也许是因为左子节点值和右子节点值都没比本节点值大，因此不需要交换，即节点 i 最大的情况。第二种，当上面两个if都不满足时，ma会保持i值，这也许是因为左子节点和右子节点都>=了Size()，因此不需要交换，即越过叶节点情况。这两种情况会导致ma == i，即我们不需要继续堆化。
            break;

        // 交换两节点
        Swap(i, ma);
        // 循环向下堆化
        i = ma; //这里是把ma这个索引值 赋给 i，帮助更新i这个索引值，以便开启下次while循环。即下次while循环时，i为ma现在的值了（e.g. i从索引值0变成索引值1了，而此时索引值1上的元素值是我们之前的堆顶，b/c Swap()），这样下次while循环就是对着此时索引值1的元素接着进行判断三个节点中最大节点的这个过程了。
        }
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



*/