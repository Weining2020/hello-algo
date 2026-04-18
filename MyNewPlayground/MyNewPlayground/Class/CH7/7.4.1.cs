using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH7
{
    internal class _741
    {/*
TreeNode root = new(100); //我自己加的初始化。
TreeNode? Search(int num)
{
    TreeNode? cur = root;
    while (cur != null)
    {
        if (cur.val < num)
        {
            cur = cur.right;
        }
        else if (cur.val > num)
        {
            cur = cur.left;
        }
        else
        {
            break;
        }
    }
    return cur;
}

void INSERT(int num)
{
    if (root == null)
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

        pre = cur;
        if (cur.val < num)
        {
            cur = cur.right;
        }
        else
        {
            cur = cur.left;
        }
    }

    // 插入节点
    TreeNode node = new(num);
    if (pre != null)
    {
        if (pre.val < num)
            pre.right = node;
        else
            pre.left = node;
    }
}
void Remove(int num)
{
    if (root == null)
    {
        return;
    }

    TreeNode? cur = root;
    TreeNode? pre = null;
    while (cur != null)
    {
        if (cur.val == num)
        {
            break;
        }

        pre = cur;
        if (cur.val < num)
        {
            cur = cur.right;
        }
        else
        {
            cur = cur.left;
        }
    }

    //打破while循环，可能是cur为null，也可能是cur找到了目标（此时cur也可能就是根节点）。
    if (cur == null)
    {
        return;
    }

    //该节点的度为0或1时，我发现两种情况可以写在一起处理。
    if (cur.left == null || cur.right == null)
    {
        TreeNode? child = cur.left ?? cur.right;
        if (cur != root)
        {
            if (pre.left == cur)
            {
                pre.left = child;   //不要错写成null了，我就栽在这里了。
            }
            else
            {
                pre.right = child;  //不要错写成null了，我就栽在这里了。
            }
        }
        else
        {
            root = child;
        }
    }
    else //子节点数量为2。
    {
        TreeNode? tmp = cur.right; //直接把cur的右节点定位第一个tmp。
        while (tmp.left != null)    //这个while负责从第一个tmp开始直接寻找中序遍历中cur之后的下一个元素。
        {
            tmp = tmp.left;
        }
        //跳出while时，tmp为“中序遍历中cur之后的下一个元素”，tmp.left为null。
        Remove(tmp.val.Value);  //只需递归删除处理这个“中序遍历中cur之后的下一个元素”。
        cur.val = tmp.val; //最后，不要忘了最后一步处理，把cur的目标值替换成“中序遍历中cur之后的下一个元素”的目标值。
    }
}
public class TreeNode
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
    }
}
