using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH9
{
    internal class _922
    {/*
public class Vertex
{
    public int val;
    public Vertex(int val)
    {
        this.val = val;
    }
}
public class GraphAdjList
{
    public Dictionary<Vertex, List<Vertex>> adjList;

    public GraphAdjList(Vertex[][] edges)
    {
        adjList = [];
        foreach (Vertex[] edge in edges)
        {
            AddVertex(edge[0]);
            AddVertex(edge[1]);
            AddEdge(edge[0], edge[1]);
        }
    }
    int Size()
    {
        return adjList.Count;
    }
    void AddVertex(Vertex vet)
    {
        if (adjList.ContainsKey(vet))
        {
            return;
        }
        adjList[vet] = new List<Vertex>();
    }
    void RemoveVertex(Vertex vet)
    {
        if (!adjList.ContainsKey(vet))
        {
            return;
        }
        adjList.Remove(vet);
        foreach (List<Vertex> list in adjList.Values)
        {
            list.Remove(vet);
        }
    }
    void AddEdge(Vertex v1, Vertex v2)
    {
        if (!adjList.ContainsKey(v1) || !adjList.ContainsKey(v2) || v1 == v2)  //20260426补充：v1 == v2 在 C# 中对 class 类型比较的是对象引用地址，不是 val 值。这里其实是正确的——邻接表用 Vertex 对象本身做 key，同一个对象才算同一个顶点，两个 val 相同但不同对象的顶点是合法的不同顶点。但你要清楚这是有意为之，不是巧合。
        {
            throw new InvalidOperationException();
        }
        adjList[v1].Add(v2);    //20260426补充：这adjList[v1]可是个列表，理论上直接Add()有可能导致重复添加，，但这份代码在构造函数的调用顺序下不会触发，目前的代码逻辑设计很好。它依赖调用方自律，而不是代码自己守护。
        adjList[v2].Add(v1);
    }
    void RemoveEdge(Vertex v1, Vertex v2)
    {
        if (!adjList.ContainsKey(v1) || !adjList.ContainsKey(v2) || v1 == v2)   
        {
            throw new InvalidOperationException();
        }
        adjList[v1].Remove(v2);
        adjList[v2].Remove(v1);
    }

    public void Print()
    {
        Console.WriteLine("邻接表 =");
        foreach (KeyValuePair<Vertex, List<Vertex>> pair in adjList)
        {
            List<int> tmp = [];
            foreach (Vertex vertex in pair.Value)
                tmp.Add(vertex.val);
            Console.WriteLine(pair.Key.val + ": [" + string.Join(", ", tmp) + "],");
        }
    }
}
*/
    }
}
