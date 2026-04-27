using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH9
{
    internal class _931
    {/*
List<Vertex> GraphBFS(GraphAdjList graph, Vertex startVet)
{
    List<Vertex> res = [];
    HashSet<Vertex> visited = new() { startVet };
    Queue<Vertex> queue = [];
    queue.Enqueue(startVet);
    while (queue.Count > 0)
    {
        Vertex vet = queue.Dequeue();
        res.Add(vet);   //20260426补充：出队时才记录在res中。
        foreach (Vertex ver in graph.adjList[vet]) //20260426补充：graph.adjList[vet]是List<Vertex>。
        {
            if (visited.Contains(ver))  //20260426补充：保证一个顶点只能入队一次。
            {
                continue;
            }
            queue.Enqueue(ver);
            visited.Add(ver);
        }
    }

    return res;
}
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
}
*/
    }
}
