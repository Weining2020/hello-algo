/*
//前序遍历。
List<int> preOrderList = new List<int>();
List<int> inOrderList = new List<int>();
void PreOrder(TreeNode? root)//依我看，PreOrder()会从用户输入的节点开始，把所有的左子节点一直处理，直到所有下面层级的左子节点处理完了，才会处理上一层级的右子节点。这个方法不返回一个列表，而是通过递归把所有节点值都加入到列表中，你想访问操作列表你就访问操作列表，但是这个方法不返回列表。
{
    if (root == null) //若输入的节点为空，则立刻返回。这是为了处理输入的节点为空（即上一个PreOrder中节点的子节点为空的情况，我这样说有点绕，不过不难理解）的情况。
    {
        return;
    }
    preOrderList.Add(root.val!.Value); //加入要返回的列表中。
    PreOrder(root.left); //处理完本节点了，该处理本节点的左子节点了，即继续递。如果本节点的左子节点为空，没关系PreOrder()内部会处理。
    PreOrder(root.right); //处理完本节点的左子节点了，该处理本节点的右子节点了，即继续递。如果本节点的右子节点为空，没关系PreOrder()内部会处理。    
}
void InOrder(TreeNode? root) //依我看，中序遍历有点类似，但中序遍历是先记录最底层左子节点，然后回溯到上一层的父节点来记录父节点，然后下递到该父节点的下一层右子节点记录该右子节点，不断重复以处理所有该父节点的子节点。等到该父节点及其子节点们被处理完，那么在向上回溯到 待在上一层的父节点，不断重复以记录所有节点。
{
    if (root == null) return;
    PreOrder(root.left);
    inOrderList.Add(root.val!.Value);
    PreOrder(root.right);
}
void PostOrder(TreeNode? root) //依我看，后序遍历有点类似，但后序遍历是先记录最底层左子节点，然后回溯到上一层的父节点 但不记录，而是下递到该父节点的下一层右子节点记录该右子节点，不断重复以处理所有该父节点的子节点。等到该父节点的子节点们被处理完，才记录父节点。然后向上回溯到 待在上一层的父节点但不记录，而是先从右边子节点向下递，不断重复以记录所有节点。
{
    if (root == null) return;
    PreOrder(root.left);
    PreOrder(root.right);
    inOrderList.Add(root.val!.Value);
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