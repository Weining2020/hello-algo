/*
//层序遍历。//层序遍历的本质是一层一层遍历，对于遍历到的节点，如果有子节点，则加入到队列中等着该遍历下一层级时一起遍历。
List<int> LevelOrder(TreeNode root) //方法起名字叫做LevelOrder。
{
    //初始化队列，加入根节点。
    Queue<TreeNode> queue = new Queue<TreeNode>();
    queue.Enqueue(root); //queue.Enqueue(root); 并不是用整颗树来构建队列实例，而是将树的根节点（root）作为一个元素，加入到队列中。在层序遍历中，队列的作用是保存当前需要访问的节点。通过不断从队列中取出节点并将其子节点加入队列，可以实现按层遍历树的所有节点。取出节点的操作在while的第一行；将其子节点加入队列的操作在while里面的if里面。也就是说最开始queue生成后，queue里只有一个根节点，取出节点后节点数量为0了，要再执行if判断是否能再加入节点进入queue。当然if有可能加入左右共两个节点进入queue，没关系之后由Dequeue()执行按先进先出的顺序把节点取出队列。

    //初始化一个列表，用来保存遍历序列，最后还要return出去。
    List<int> list = new List<int>();
    while (queue.Count != 0) //到了最后所有queue里的节点都取出了，且无子节点需要进入queue，则遍历结束了。
    {
        TreeNode node = queue.Dequeue(); //这是从queue中取出节点的操作。
        list.Add(node.val!.Value); //注意！！这里不能写成list.Add(node.val);, b/c 这里的node.val根据声明是int?类型，而List<int> 不支持直接添加 null 或 int? 类型的值。为了避免类型不匹配，必须将 node.val 转换为 int 类型。注意！！有总结，Value属性 是 可空类型（即Nullable<T>）的值提取器。如果 node.val 是非空的，可以通过 node.val.Value 获取实际的整数值。可空类型（即Nullable<T>）还有一个很有用的属性是HasValue。如果 node.val 是 null，直接访问 Value 会引发运行时异常 InvalidOperationException。因此list.Add(node.val!.Value);表示：编译器： 我确信 node.val 不会是 null，请提取其中的整数值。运行时： 从 node.val 中提取整数值，并将其添加到列表中。
        if (node.left != null) 
        {
            queue.Enqueue(node.left); //这是把子节点加入queue中准备被遍历代码 从queue中再取出。这不是把子节点加入 我们最终要返回的列表！
        }
        if(node.right != null)
        {
            queue.Enqueue(node.right); //这是把子节点加入queue中准备被遍历代码 从queue中再取出。这不是把子节点加入 我们最终要返回的列表！
        }
    }
    return list;
}
public class TreeNode //写在这防止报错。
{
    public int? val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int? x)
    {
        val = x;
    }
}
*/