

//初始化二叉树。
TreeNode n1 = new TreeNode(1);
TreeNode n2 = new TreeNode(2);
TreeNode n3 = new TreeNode(3);
TreeNode n4 = new TreeNode(4);
TreeNode n5 = new TreeNode(5);
// 构建节点之间的引用（指针）
n1.left = n2;
n1.right = n3;
n2.left = n4;
n2.right = n5;

//插入与删除节点。
TreeNode P = new(0);
// 在 n1 -> n2 中间插入节点 P
n1.left = P; //注意！！两行代码顺序不能互换！！这个有点难解释，我也是问的chatGPT。比如就像图 7-3 那样把P插入到n1和n2之间。我们需要以 树本身的得失来考虑问题，要以树的安全为优先。如果先执行P.left = n2,则n1.left依然指向p2,此时如果进行n1.left相关操作可能会出大错。但是如果先执行n1.left=P，此时虽然n2从树上断开，但此时执行n1.left不会出错，因为n1.left引用已指向P，接着执行P.left = n2还能把n2节点接回来，没问题。
P.left = n2;
// 删除节点 P
n1.left = n2; //Question:删除节点时，P 的左子节点依然是 n2，但我们什么都不做？答：这是可以的，因为 P 会被垃圾回收（GC）。P 本身仍存在于内存中，且 P.left 依然是 n2，但 P 已不再被任何其他节点引用。在 C# 中，当对象不再被任何活动的引用所访问时，垃圾回收器（Garbage Collector, GC）会自动回收这部分内存。也就是说，虽然 P.left 依然指向 n2，但因为 P 自身不再是活动节点，其引用关系对于二叉树的逻辑已不再重要。

//二叉树节点类。
public class TreeNode //以前没见过。
{
    public int? val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int? x)
    {
        val = x;
    }
}