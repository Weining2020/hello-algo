/*
using hello_algo.utils;

//深度优先遍历辅助函数。//这个设计太牛了！
void DFS(GraphAdjList graph, HashSet<Vertex> visited, List<Vertex> res, Vertex vet)
{
    res.Add(vet);     // 记录访问顶点 //没错我想过了，第一次上来是把startVertex加入到res中。之后每次在这里加顶点到res都是 已经pass ifcheck的前提下了，即res里不可能有过该节点，不会重复，没问题。
    visited.Add(vet); // 标记该顶点已被访问
    // 遍历该顶点的所有邻接顶点
    foreach (Vertex adjVet in graph.adjList[vet])
    { //Question:我不能理解的报错？
        if (visited.Contains(adjVet))
        {
            continue; // 跳过已被访问的顶点                             
        }
        // 递归访问邻接顶点
        DFS(graph, visited, res, adjVet);
    }
}

//深度优先遍历。
// 使用邻接表来表示图，以便获取指定顶点的所有邻接顶点
List<Vertex> GraphDFS(GraphAdjList graph, Vertex startVet)
{
    // 顶点遍历序列
    List<Vertex> res = [];
    // 哈希集合，用于记录已被访问过的顶点
    HashSet<Vertex> visited = [];
    DFS(graph, visited, res, startVet);
    return res;
}
*/
using hello_algo.utils;

public class GraphAdjList
{
    // 邻接表，key：顶点，value：该顶点的所有邻接顶点
    public Dictionary<Vertex, List<Vertex>> adjList;

    /* 构造函数 */
    public GraphAdjList(Vertex[][] edges)
    {
        adjList = [];
        // 添加所有顶点和边
        foreach (Vertex[] edge in edges)
        {
            AddVertex(edge[0]);
            AddVertex(edge[1]);
            AddEdge(edge[0], edge[1]);
        }
    }

    /* 获取顶点数量 */
    int Size()
    {
        return adjList.Count;
    }

    /* 添加边 */
    public void AddEdge(Vertex vet1, Vertex vet2)
    {
        if (!adjList.ContainsKey(vet1) || !adjList.ContainsKey(vet2) || vet1 == vet2)
            throw new InvalidOperationException();
        // 添加边 vet1 - vet2
        adjList[vet1].Add(vet2);
        adjList[vet2].Add(vet1);
    }

    /* 删除边 */
    public void RemoveEdge(Vertex vet1, Vertex vet2)
    {
        if (!adjList.ContainsKey(vet1) || !adjList.ContainsKey(vet2) || vet1 == vet2)
            throw new InvalidOperationException();
        // 删除边 vet1 - vet2
        adjList[vet1].Remove(vet2);
        adjList[vet2].Remove(vet1);
    }

    /* 添加顶点 */
    public void AddVertex(Vertex vet)
    {
        if (adjList.ContainsKey(vet))
            return;
        // 在邻接表中添加一个新链表
        adjList.Add(vet, []);
    }

    /* 删除顶点 */
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

    /* 打印邻接表 */
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
