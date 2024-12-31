/*
using hello_algo.utils;
List<List<TreeNode>> res = []; //教程上没加这个，我加在这里防止报错。
List<TreeNode> path = new List<TreeNode>();
void PreOrder(TreeNode? root)
{
    if(root == null)
    {
        return;
    }
    path.Add(root);
    if(root.val == 7)
    {
        res.Add(new List<TreeNode>(path));
    }
    PreOrder(root.left);
    PreOrder(root.right);
    path.RemoveAt(path.Count - 1);

}
*/