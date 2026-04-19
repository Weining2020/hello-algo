using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH7
{
    internal class _753
    {
    }/*
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

    void Insert(int val)
    {
        root = InsertHelper(root, val);
    }

    TreeNode? InsertHelper(TreeNode? node, int val)
    {
        if (node == null)
        {
            return new TreeNode(val);
        }

        if (node.val < val)
        {
            node.right = InsertHelper(node.right, val);
        }
        else if (node.val > val)
        {
            node.left = InsertHelper(node.left, val);
        }
        else
        {
            return node;
        }

        UpdateHeight(node);
        node = Rotate(node);
        return node;
    }

    void Remove(int val)
    {
        root = RemoveHelper(root, val);
    }
    TreeNode? RemoveHelper(TreeNode? node, int val)
    {
        if (node == null)
        {
            return null;
        }

        if (node.val < val)
        {
            node.right = RemoveHelper(node.right, val);
        }
        else if (node.val > val)
        {
            node.left = RemoveHelper(node.left, val);
        }
        else
        {
            if (node.left == null || node.right == null)
            {
                TreeNode? child = node.left ?? node.right;
                if (child == null)
                {
                    return null;
                }
                else
                {
                    node = child;
                }
            }
            else
            {
                TreeNode temp = node.right;
                while (temp.left != null)
                {
                    temp = temp.left;
                }
                node.right = RemoveHelper(node.right, temp.val.Value);
                node.val = temp.val;
            }
        }

        UpdateHeight(node);
        node = Rotate(node);
        return node;
    }
}
*/

}
