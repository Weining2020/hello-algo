using hello_algo.utils;
using System.Collections.Generic;

List<TreeNode> path = new List<TreeNode>();
List<List<TreeNode>> res = new List<List<TreeNode>>();
void PreOrder(TreeNode? root)
{
    if (root == null)
    {
        return;
    }

    path.Add(root);
    if (root.val == 7)
    {
        res.Add(new List<TreeNode>(path));
    }

    PreOrder()
}