/*
using CH12.utils;

TreeNode? DFS(int[] preorder, Dictionary<int, int> inorderMap, int i, int l, int r) //i为根节点索引。l,r为这整棵树的左右区间。不要弄混了，i是根节点在preorder数组中的索引，而l和r是这棵树在inorder数组中的索引的左右区间。
{
    
    if (l - r > 0)
    {
        return null;
    }
    TreeNode root = new TreeNode(preorder[i]);
    //m是根节点在inorder数组中的索引。要得到这个索引值，得从inorderMap中查询才行。
    int m = inorderMap[preorder[i]];
    //得到m了，我们就进而得到了在inorder数组中，根节点m下的左子树区间[l, m - 1]和右子树区间[m + 1, r]了。我们根据公式，可以得到 根节点m下的左子树 的根节点 在preorder的索引为 i + 1， 可以得到 根节点m下的右子树 的根节点 在preorder的索引为 i + 1 + (m - l)。母树的左区间索引起始(即l)和右区间索引终点(即r)可以直接用于两个子树的左区间索引起始和右区间索引终点，保持不变，因为子树也是母树区间的一部分。
    root.left = DFS(preorder, inorderMap, i + 1, l, m - 1);
    root.right = DFS(preorder, inorderMap, i + 1 + (m - l), m + 1, r);

    return root;
}
TreeNode? BuildTree(int[] preorder, int[] inorder)
{
    Dictionary<int, int> inorderMap = new Dictionary<int, int>();
    for (global::System.Int32 i = 0; i < inorder.Length; i++) //这个inorderMap哈希表中会保存上每个节点在inorder中的索引值，我们是想要从inorderMap中查询出每次根节点在inorder数组中的索引值，根节点在preorder中的索引值i不需要查询,根节点在 preorder 中的索引 i 是通过递归直接传递的，不需要查询。
    {
        inorderMap.TryAdd(inorder[i], i);
    }

    TreeNode? root = DFS(preorder, inorderMap, 0, 0, preorder.Length - 1);
    return root;
}
*/