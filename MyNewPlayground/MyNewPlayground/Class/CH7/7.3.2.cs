using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH7
{
    internal class _732
    {/*
public class ArrayBinaryTree
{
    List<int?> tree;
    public ArrayBinaryTree(List<int?> arr)
    {
        tree = new(arr);
    }

    public int Size()
    {
        return tree.Count;
    }

    public int? Val(int i)
    {
        if (i < 0 || i >= Size())
        {
            return null;
        }
        return tree[i];
    }

    public int Left(int i)
    {
        return 2 * i + 1;
    }
    public int Right(int i)
    {
        return 2 * i + 2;
    }
    public int Parent(int i)
    {
        return (i - 1) / 2;
    }
    public List<int> LevelOrder()
    {
        List<int> res = [];
        for (int i = 0; i < Size(); i++)
        {
            if (Val(i).HasValue)
            {
                res.Add(Val(i)!.Value);
            }
        }
        return res;
    }
    void DFS(int i, string order, List<int> res)
    {
        if (!Val(i).HasValue)
        {
            return;
        }
        if (order == "pre")
        {
            res.Add(Val(i).Value);
        }
        DFS(Left(i), order, res);
        if (order == "in")
        {
            res.Add(Val(i).Value);
        }
        DFS(Left(i), order, res);
        if (order == "post")
        {
            res.Add(Val(i).Value);
        }
    }
    public List<int> PreOrder()
    {
        List<int> res = [];
        DFS(0, "pre", res);
        return res;
    }
    public List<int> InOrder()
    {
        List<int> res = [];
        DFS(0, "in", res);
        return res;
    }
    public List<int> PostOrder()
    {
        List<int> res = [];
        DFS(0, "post", res);
        return res;
    }
}
*/
    }
}
