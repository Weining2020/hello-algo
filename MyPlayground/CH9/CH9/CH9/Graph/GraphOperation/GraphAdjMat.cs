/*
//基于邻接矩阵实现的无向图类。
//基于邻接矩阵实现的无向图类。
class GraphAdjMat
{
    List<int> vertices;     // 顶点列表，元素代表“顶点值”，索引代表“顶点索引”
    List<List<int>> adjMat; // 邻接矩阵，行列索引对应“顶点索引” //e.g. adjMat[0]的数据代表第一个顶点的数据，其中0是第一个顶点的顶点索引（这个顶点的顶点值是vertice[0]）。而adjMat[0][1]代表adiMat[0]这个列表的第一个元素，是边里的信息，这里具体是第一个顶点（由[0]得到）和第二个顶点（由[1]得到）之间的边的信息。
    //构造函数。
    public GraphAdjMat(int[] vertices, int[][] edges)
    { //这个方法有点绕。edges作为构造器的第二个参数，是一个int[][] 锯齿状数组datatype，内部每个元素都是独立的一条边的信息，以int[]的形式展现。每个 int[] 是一条边的抽象表示，其中包含了边的两个顶点的索引。所以这两个顶点的信息也体现在每个int[]内部的元素中，即int[0]和int[1]是每条边所对应两个顶点的索引值。
        this.vertices = [];
        this.adjMat = [];
        // 添加顶点
        foreach (int val in vertices)
        { //AddVertex()方法声明在下面。
            AddVertex(val);
        }
        // 添加边
        // 请注意，edges 元素代表顶点索引，即对应 vertices 元素索引
        foreach (int[] e in edges)
        {
            AddEdge(e[0], e[1]); //AddEdge()方法声明在下面。//每个e都是一条边，每条边不会重复。
        }
    }

    //获取顶点数量。
    int Size()
    {
        return vertices.Count;
    }

    //添加顶点。//总的原理是，对于vertices，加入一个新的顶点值。对于adjMat,先加入一个新行（即新List，List内的元素数量与其他List的元素数量相同），再把所有adjMat的行（即List元素）都加入一个0值。
    public void AddVertex(int val)
    {
        int n = Size(); //n代表了添加新顶点之前的顶点数，不能先vertices.Add(XXX)再求n值。//拿到n，b/c需要n值来帮助构建一个新的列表List，以添加该列表List进入adjMat作为一个新的元素。adjMat里的元素们都是列表。
        // 向顶点列表中添加新顶点的值
        vertices.Add(val);
        // 在邻接矩阵中添加一行
        List<int> newRow = new(n); //这里就是借助n值来帮助构建一个新的列表List。
        for (int j = 0; j < n; j++)
        { //这个for好理解，是为了给 这个我们想加入adjMat的新List 配置好内部的元素值，即配置好新顶点与其他顶点之间的边的信息（1代表有边，0代表无边）。此时还是只添加n个值进新List，理论上应该添加n+1个值，因为每个list中也应该包括 某顶点自己与自己之间的边的信息，没错这最后一个值会在下面foreach做到。
            newRow.Add(0); //本AddVertex()方法只是添加一个顶点，没有同时添加边，因此新列表中元素值全部给0就代表该顶点与其他顶点不相连。
        }
        adjMat.Add(newRow); //这里就是添加该列表List进入adjMat作为一个新的元素。
        // 在邻接矩阵中添加一列
        foreach (List<int> row in adjMat)
        { //这个foreach好理解，就是为了给adjMat的每个列表元素，都添加一个新的0值，用于表达每个已存在的顶点（包括新顶点）与新顶点的边的信息。
            row.Add(0);
        }
    }


    //删除顶点。  //总的原理是，对于vertices，删除特定的顶点值。对于adjMat,先先删除特定顶点值所对应的一整行（即一整个List），再把所有adjMat的行（即List元素）都删除一个特定顶点值所对应的边信息值。
    public void RemoveVertex(int index)
    { //这里的参数index指的是我们想删除的顶点的索引。
        if (index >= Size()) //别忘了考虑非法操作。
            throw new IndexOutOfRangeException();
        // 在顶点列表中移除索引 index 的顶点
        vertices.RemoveAt(index); //这是在顶点列表vertices中作删除，不是在邻接矩阵adjMat中作删除。
        // 在邻接矩阵中删除索引 index 的行
        adjMat.RemoveAt(index); //和添加顶点类似，先删除某一整行，再在foreach中删除每一行中的具体这一列。
        // 在邻接矩阵中删除索引 index 的列
        foreach (List<int> row in adjMat)
        {
            row.RemoveAt(index);
        }
    }

    //添加边。//本方法的意思应该是给两个顶点，在这两个顶点间加个边。
    // 参数 i, j 对应 vertices 元素索引
    public void AddEdge(int i, int j)
    { //两个参数是我们先加边的两个顶点的分别index。即有了这两个参数，我们就知道是在哪两个顶点间加边了。
        // 索引越界与相等处理 //别忘了i==j也是非法情况。
        if (i < 0 || j < 0 || i >= Size() || j >= Size() || i == j)
            throw new IndexOutOfRangeException();
        // 在无向图中，邻接矩阵关于主对角线对称，即满足 (i, j) == (j, i)
        adjMat[i][j] = 1;
        adjMat[j][i] = 1;
    }

    //删除边。
    // 参数 i, j 对应 vertices 元素索引
    public void RemoveEdge(int i, int j)
    {
        // 索引越界与相等处理
        if (i < 0 || j < 0 || i >= Size() || j >= Size() || i == j)
            throw new IndexOutOfRangeException();
        adjMat[i][j] = 0;
        adjMat[j][i] = 0;
    }

    //打印邻接矩阵。
    public void Print()
    {
        Console.Write("顶点列表 = ");
        PrintUtil.PrintList(vertices);
        Console.WriteLine("邻接矩阵 =");
        PrintUtil.PrintMatrix(adjMat);
    }
}
*/