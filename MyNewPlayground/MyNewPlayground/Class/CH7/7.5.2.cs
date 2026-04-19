using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH7
{
    internal class _753
    {/*
public class TreeNode
{
    public int? val;
    public int height;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int? x)
    {
        val = x;
    }

    //右旋操作
    TreeNode? RightRotate(TreeNode? node)
    {
        TreeNode? child = node?.left;
        TreeNode? grandChild = child?.right;
        // 以 child 为原点，将 node 向右旋转
        child.right = node;
        node.left = grandChild;  //grandChild值当然小于node值了，这是因为child本来是node的子节点，而grandChild是child的子节点，子节点当然比父节点要小，因此grandChild值小于node值。
        // 更新节点高度
        // Question：为什么不更新grandChild的高度？ 答：一个节点的高度 = 它自己到叶子节点的最长路径长度，由其左右子节点的高度决定，height(node) = 1 + max(height(left), height(right))。关键：高度只取决于子节点，与父节点无关。因为旋转操作完全没有修改 grandChild 的子节点，所以 grandChild 的高度根本没有变化，不需要更新。
        UpdateHeight(node);
        UpdateHeight(child);
        // 返回旋转后子树的根节点
        return child;
    }

    //左旋操作
    TreeNode? LeftRotate(TreeNode? node)
    {
        TreeNode? child = node?.right;
        TreeNode? grandChild = child?.left;
        child.right = node;
        node.left = grandChild;
        UpdateHeight(node);
        UpdateHeight(child);
        return child;
    }

    //执行旋转操作，使该子树重新恢复平衡
    TreeNode? Rotate(TreeNode? node)
    {
        int balanceFactor = BalanceFactor(node);
        if (balanceFactor > 1)  //左偏
        {
            if (BalanceFactor(node?.left) >= 0)
            {
                return RightRotate(node);
            }
            else
            {
                node.left = LeftRotate(node.left);
                return RightRotate(node);
            }
        }

        if (balanceFactor < -1) //右偏
        {
            if (BalanceFactor(node.right) <= 0)
            {
                return LeftRotate(node);
            }
            else
            {
                node.right = RightRotate(node.right);
                return LeftRotate(node);
            }
        }

        return node;
    }
}
*/

    }
}
