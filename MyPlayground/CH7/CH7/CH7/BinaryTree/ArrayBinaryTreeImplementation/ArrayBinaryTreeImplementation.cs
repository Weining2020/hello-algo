/*

//教程上的一个 可空数组表示任意二叉树 的例子。只是例子，和之后代码无关。
int?[] tree = [1, 2, 3, 4, null, 6, 7, 8, 9, null, null, 12, null, null, 15];

//数组表示下的二叉树类。
public class ArrayBinaryTree //这个类是用数组表示法实现的二叉树。
{
    List<int?> tree; //List<int?> 用来存储二叉树节点的值，其中 null 表示空节点。
    public ArrayBinaryTree(List<int?> arr)
    {
        tree = arr;
    }
    //列表容量。
    public int Size() //列表的容量并不等于树的实际节点数量，而是等于数组表示法中使用的所有下标总数，包括空节点 (null) 的位置。在数组表示法中，树的节点数量是非空节点的个数，而列表的容量等于整个数组的长度。
    {
        return tree.Count;
    }
    //获取索引为 i 节点的值。
    public int? Val(int i)
    {
        // 若索引越界，则返回 null ，代表空位。
        if (i < 0 || i >= Size()) //别忘了考虑索引越界的问题。另外这里条件是index>=Size()，看清楚，没有错。
        {
            throw new Exception();
        }
        return tree[i];
    }
    //获取索引为 i 节点的左子节点的索引。
    public int Left(int i)
    {
        return 2*i + 1; //映射公式。
    }
    //获取索引为 i 节点的右子节点的索引
    public int Right(int i)
    {
        return 2 * i + 2; //映射公式。
    }
    //获取索引为 i 节点的父节点的索引。
    public int Parent(int i)
    {
        return (i - 1) / 2; //映射公式。
    }
    //层序遍历。
    public List<int> LevelOrder() //Question:为啥LevelOrder()只返回不为空的节点的值？答：LevelOrder() 方法只返回不为空的节点的值是为了简化结果，并且符合通常的使用场景。在大多数情况下，我们对二叉树的遍历只关心非空节点的值，而不是空节点的位置。null 节点表示树中的空位，它们通常没有实际意义。因此，LevelOrder() 通过过滤掉 null 节点，返回一组有意义的结果。过滤掉空节点后，结果更简洁、更直观，也更适合直接用于其他操作。例如：打印输出。进一步处理（比如求和、查找某个值）。
    {
        List<int> res = new List<int>();
        foreach (int? i in tree) //我自己的实现用foreach代替了教程的for。
        {
            if (i.HasValue)
            {
                res.Add(i.Value);
            }
        }
        return res;
    }
    //深度优先遍历。
    //讲解：懂了。得把DFS(),PreOrder(),InOrder(),PostOrder()综合起来一起看。首先，用户是调用PreOrder(),InOrder(),PostOrder()，而不是调用DFS()。DFS()这个方法是为了 合理地 借助control of flow把前序，中序，后续遍历综合起来，使一个DFS()能够同时处理三种遍历的情况，即使得DFS()可以根据用户选择来执行相应的遍历操作。e.g. 当用户选择PreOrder()时，DFS()内部逻辑变成了，先检查是否为空，再把当前索引保存的值加入res中，再依次执行该索引所对应的这个节点的左子节点和右子节点的DFS()，即通过control of flow使DFS() 和 我们之前 跟着教程 借助列表+自己写过的TreeNode 对前序遍历的实现 非常接近。而三个对order的判断放置的位置非常巧妙，刚好形成完美的control of flow, 根据用户选择的遍历方式 排出 合适的 父节点，左子节点，右子节点 三者间的 逻辑执行顺序。真牛逼啊。
    void DFS(int i, string order, List<int> res) //根据用户指定的深度优先遍历法来进行深度优先遍历。
    {
        if (!tree[i].HasValue)
        {
            return;
        }
        if (order == "pre")
        {
            res.Add(tree[i].Value);
        }
        DFS(Left(i), order, res);
        if (order == "in")
        {
            res.Add(tree[i].Value);
        }
        DFS(Right(i), order, res);
        if(order == "post")
        {
            res.Add(tree[i].Value);
        }
    }
    //前序遍历。
    public List<int> PreOrder()
    {
        List<int> res = new List<int> ();
        DFS(0, "pre", res);
        return res;
    }
    //中序遍历。
    public List<int> InOrder()
    {
        List<int> res = new List<int> ();
        DFS(0, "in", res);
        return res;
    }
    //后序遍历。
    public List<int> PostOrder()
    {
        List<int> res = new List<int> ();
        DFS(0, "post", res);
        return res;
    }

}
*/