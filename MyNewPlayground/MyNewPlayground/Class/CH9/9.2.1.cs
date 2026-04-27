using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH9
{
    internal class _921
    {/*
public class GraphAdjMat
{
    List<int> vertices;
    List<List<int>> adjMat; //20260426补充：是“行列”的顺序，先进去第一层，是所有row行。再进去一层，是每一行的具体值，每一个元素对应该行某列。

    public GraphAdjMat(int[] vertices, int[][] edges)   //20260426补充：edges是一个由数组组成的数组。edges = [[0,1],[1,2]] ← 边：0-1 相连，1-2 相连。
    {
        this.vertices = [];
        this.adjMat = [];

        //添加顶点。
        foreach (var val in vertices)
        {
            AddVertex(val);
        }
        //添加边。
        foreach (int[] edge in edges)
        {
            AddEdge(edge[0], edge[1]);  //20260426补充：edge是一条边，edge[0]是边的一个顶点，edge[1]是边的另一个顶点。
        }
    }

    int Size()
    {
        return vertices.Count;
    }
    void AddVertex(int val)
    {
        int size = Size();
        vertices.Add(val);

        List<int> newRow = new(Enumerable.Repeat(0, size));
        adjMat.Add(newRow);
        foreach (List<int> row in adjMat)
        {
            row.Add(0);
        }
    }
    void RemoveVertex(int index)
    {
        if (index < 0||index>Size())
        {
            throw new IndexOutOfRangeException();
        }

        vertices.RemoveAt(index);
        adjMat.RemoveAt(index);
        foreach (var row in adjMat)
        {
            row.RemoveAt(index);
        }
    }
    void AddEdge(int i, int j)
    {
        if (i < 0 || j < 0 || i >= Size() || j >= Size() || i == j) //20260426补充：i==j的条件没有特殊含义，就是无向图中不允许边指向顶点本身。这叫自环（Self-loop），在无向简单图中不允许一个顶点连向自身，所以这个条件是合法性守卫，没有其他魔法含义。
        {
            throw new IndexOutOfRangeException();
        }

        adjMat[i][j] = 1;
        adjMat[j][i] = 1;
    }
    void RemoveEdge(int i, int j)
    {
        if (i < 0 || j < 0 || i >= Size() || j >= Size() || i == j) 
        {
            throw new IndexOutOfRangeException();
        }

        adjMat[i][j] = 0;
        adjMat[j][i] = 0;
    }
}
*/
    }
}
