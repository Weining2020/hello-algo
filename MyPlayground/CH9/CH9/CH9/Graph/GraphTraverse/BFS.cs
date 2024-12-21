using hello_algo.utils;

/*
//广度优先遍历。
// 使用邻接表来表示图，以便获取指定顶点的所有邻接顶点 //核心是 拿到出队的顶点元素，根据该顶点 找到其他连通顶点，遍历那些连通顶点加入到queue和visited中。到此这一个顶点算工作结束了，加入到return列表就行了。继续进行下一个该出队的顶点元素。
List<Vertex> GraphBFS(GraphAdjList graph, Vertex startVet)
{
    // 顶点遍历序列
    List<Vertex> res = [];
    // 哈希集合，用于记录已被访问过的顶点
    HashSet<Vertex> visited = [startVet]; //哈希集合规定不能有重复元素。
    // 队列用于实现 BFS
    Queue<Vertex> que = new(); //这个队列是根据Queue的先入先出性质，专门准备了一个队列来帮助循环访问所有顶点。我们先把起始顶点加入Queue，然后从这个顶点开始循环访问 该顶点所对应的List<Vertex>中的顶点，List<Vertex>里面都是该顶点 连通 的其他顶点。在循环访问List<Vertex>中的顶点时，把那些
    顶点也当做起始顶点加入队列，直至所有的List<Vertex> 中所有顶点都被访问过了，就算是循环访问完所有顶点了。
    que.Enqueue(startVet);
    // 以顶点 vet 为起点，循环直至访问完所有顶点
    while (que.Count > 0)
    {
        Vertex vet = que.Dequeue(); // 队首顶点出队
        res.Add(vet);               // 记录访问顶点 //这一行和整个foreach互换位置也可以。
        foreach (Vertex adjVet in graph.adjList[vet])
        {
            if (visited.Contains(adjVet))
            {
                continue;          // 跳过已被访问的顶点
            }
            que.Enqueue(adjVet);   // 只入队未访问的顶点
            visited.Add(adjVet);   // 标记该顶点已被访问 //将 visited.Add(adjVet) 放在 foreach 内部的主要目的是 避免重复入队，而不是为了定义顶点何时被正式访问。实际访问是通过 res.Add(vet) 在出队时记录的。
        }
    }

    // 返回顶点遍历序列
    return res;
}
*/
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
