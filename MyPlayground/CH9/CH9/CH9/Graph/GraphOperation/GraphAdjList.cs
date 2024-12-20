/*
//基于邻接表实现的无向图类。我没找到Vertex这个类的声明，怀疑至少有int val这个字段。
using System.Collections.Generic;

class GraphAdjList
{
    // 邻接表，key：顶点，value：该顶点的所有邻接顶点
    public Dictionary<Vertex, List<Vertex>> adjList;

    //构造函数。
    public GraphAdjList(Vertex[][] edges) //用户传入一个锯齿状数组，其中每一条边由 边的两个顶点 来表示。我认为其实Vertex[][]的第一个[]没什么意义，只能表示后面的Vertex[]（即具体的某边）是这个Vertex[][]的具体第几个边而已，没什么用，b/c每条边在Vertex[][]的index无所谓，用不到。
    {
        adjList = [];
        // 添加所有顶点和边
        foreach (Vertex[] edge in edges) //拿到具体每条边。对每条边这个Vertex[]类型的信息，进行顶点和边的加入。
        {
            AddVertex(edge[0]);
            AddVertex(edge[1]);
            AddEdge(edge[0], edge[1]);
        }
    }

    //获取顶点数量。
    int Size()
    {
        return adjList.Count;
    }

    //添加边。
    public void AddEdge(Vertex vet1, Vertex vet2)
    {
        if (!adjList.ContainsKey(vet1) || !adjList.ContainsKey(vet2) || vet1 == vet2) //别忘了输入两个相同顶点也不行。
            throw new InvalidOperationException();
        // 添加边 vet1 - vet2
        adjList[vet1].Add(vet2);
        adjList[vet2].Add(vet1);
    }
    //删除边 。    //和AddEdge()非常类似。

    public void RemoveEdge(Vertex vet1, Vertex vet2)
    {
        if (!adjList.ContainsKey(vet1) || !adjList.ContainsKey(vet2) || vet1 == vet2)
            throw new InvalidOperationException();
        // 删除边 vet1 - vet2
        adjList[vet1].Remove(vet2);
        adjList[vet2].Remove(vet1);
    }


    //添加顶点。
    public void AddVertex(Vertex vet)
    {
        if (adjList.ContainsKey(vet))
            return; //确实，当顶点已存在时不该抛异常而是直接返回。
        // 在邻接表中添加一个新链表
        adjList.Add(vet, []); //确实，新顶点对应的邻接列表应该为空列表，因为只加了新顶点，没有加边。
    }


    //删除顶点。//这个很直观。
    public void RemoveVertex(Vertex vet)
    {
        if (!adjList.ContainsKey(vet))
            throw new InvalidOperationException();
        // 在邻接表中删除顶点 vet 对应的链表
        adjList.Remove(vet);
        // 遍历其他顶点的链表，删除所有包含 vet 的边
        foreach (List<Vertex> list in adjList.Values)
        {
            list.Remove(vet);
        }
    }
     //打印邻接表。 //我甚至觉得教程方法写的有点啰嗦了。
    public void Print()
    {
        Console.WriteLine("邻接表 =");
        foreach (KeyValuePair<Vertex, List<Vertex>> pair in adjList)
        {
            List<int> tmp = [];
            foreach (Vertex vertex in pair.Value)
                tmp.Add(vertex.val); //这是根据Vertex类声明来的，但是我找不到Vertex类声明。
            Console.WriteLine(pair.Key.val + ": [" + string.Join(", ", tmp) + "],");
        }
    }
}

*/