/*
using System;

public class BinarySearchTree
{
    TreeNode root;
    //查找节点。
    TreeNode? Search(int sum) //我写的实现也对，和教程不完全一样，我没用到break。
    {
        TreeNode? cur = root; //TreeNode? cur = root; 定义中使用了 可空类型（nullable type） 是为了处理二叉搜索树的查找过程中，可能出现的 空节点（null）。
        while (cur != null)
        {
            if (cur.val == sum)
            {
                return cur;
            } 
            else if (cur.val < sum)
            {
                cur = cur.right;
            }
            else
            {
                cur = cur.left;
            }
        }
        return null;
    }
    //插入节点。
    void Insert(int num)
    {
        if (root == null)   //别忘了考虑一开始树就是空的 这种情况。
        {
            root = new TreeNode(num);
            return;
        }
        TreeNode? cur = root;
        TreeNode? pre = null;
        while (cur != null)
        {
            if (cur.val == num)
            {
                return;
            }
            else if (cur.val < num)
            {
                pre = cur;
                cur = cur.right;
            }
            else
            {
                pre = cur;
                cur = cur.left;
            }
        }
        TreeNode newTreeNode = new TreeNode(num);
        pre.right = newTreeNode;
        if(pre.val < num) //确实需要这个判断来决定到底插入在pre的左子节点还是右子节点。b/c num可能远小于pre.Value，而pre的左右都没有节点，此时需要判断把新节点插入在pre的左子节点还是右子节点。
        {
            pre.right = newTreeNode;
        }
        else
        {
            pre.left = newTreeNode;
        }
    }

    //删除节点。
    //别看这方法内部有Remove()递归调用，其实在用户发起Remove这个操作后，Remove()一共就会执行两次，能看懂。最后还有个我自己举的例子。
    void Remove(int num)
    {
        // 若树为空，直接提前返回
        if (root == null)
            return;
        TreeNode? cur = root, pre = null;
        // 循环查找，越过叶节点后跳出
        while (cur != null)
        { //整个while块是为了找到目标节点。
          // 找到待删除节点，跳出循环
            if (cur.val == num) //只有当break触发，才是真的找到了要删除的目标节点。如果是因为cur == null而跳出while循环，则说明树中没有这个目标节点，直接返回的逻辑在while块之下有写。
                break;
            pre = cur;
            // 待删除节点在 cur 的右子树中
            if (cur.val < num)
                cur = cur.right;
            // 待删除节点在 cur 的左子树中
            else
                cur = cur.left;
        }
        // 若无待删除节点，则直接返回
        if (cur == null)
            return;  //即上面的while是因为 cur == null而跳出的，而不是由cur.val == num找到目标节点而break的。此时说明树中没有这个目标节点，直接返回。
                     // 子节点数量 = 0 or 1
                     //找到目标节点后，需要分析目标节点的degree是什么情况。
        if (cur.left == null || cur.right == null)
        { //好理解，只要左右节点有任何一个是null，就说明cur的degree不是2。
          // 当子节点数量 = 0 / 1 时， child = null / 该子节点
            TreeNode? child = cur.left ?? cur.right;
            // 删除节点 cur
            if (cur != root)
            {
                if (pre!.left == cur) //这个if else是具体进行删除操作的步骤。判断条件pre!.left == cur是为了查出到底cur是pre的左子节点还是右子节点，好进行删除。
                    pre.left = child; //把child赋给pre的子节点就像当于做了 节点替换。就算child是null，把null给pre的子节点，也相当于是删除了cur节点。
                else
                    pre.right = child;
            }
            else
            {
                // 若删除节点为根节点，则重新指定根节点
                root = child;
            }
        }
        // 子节点数量 = 2
        else
        {
            //接下来需要找到cur的右子树中的最小节点。
            // 获取中序遍历中 cur 的下一个节点
            TreeNode? tmp = cur.right; //这里这么写是因为我们在用cur的右子树的最小节点来替换cur，以实现删除。你也可以选择用cur的左子树的最大节点来替换cur，以实现删除。这是为了保持二叉搜索树“左子树 <根节点 <右子树”的性质。Question:我不明白为什么TreeNode是可空？明明cur的degree一定是2？
            while (tmp.left != null)
            { //之所以这么写while块，是因为直到我们找到一个 左子节点为空的tmp节点，才算是确认了tmp是cur的右子树的最小节点，因为没有更小的节点了。
                tmp = tmp.left;
            }
            //找到cur的右子树中的最小节点了，把这个最小节点的值赋给cur以作替换，还需要把这个最小节点删除了。
            // 递归删除节点 tmp

            Remove(tmp.val!.Value); //这个太妙了！这一步是跳出了while，即此时tmp节点的左子节点是空（Question：我们为什么要一直更新tmp节点直到tmp节点的左子节点为空？答：b/c 当某节点的左子节点为空时，这个节点是cur右子树的最小节点，不信你可看图观察观察），我们该用这个tmp节点去替换cur节点了，也就等于 我们需要把这个tmp节点也从树上删除，那我们直接递归调用Remove()来完成删除操作！
                                    // 用 tmp 覆盖 cur
            cur.val = tmp.val; //cur.val = tmp.val; 的作用是 将要删除的节点的值替换为其后继节点的值，从而间接实现删除。
        }
    }

}
public class TreeNode
{
    public int? val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int n)
    {
        val = n;
    }
}
*/