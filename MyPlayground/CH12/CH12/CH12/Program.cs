void Move(List<int> src, List<int> des)
{
    int pillar = src[src.Count - 1];
    src.RemoveAt(src.Count - 1);
    des.Add(pillar);
}
void DFS(int n, List<int> src, List<int> aux, List<int> des)
{
    if (n == 1)
    {
        Move(src, des);
        return;
    }

    DFS(n - 1, src, des, aux);

    Move(src, des);

    DFS(n - 1, aux, src, des);
}
void SolveHanota(List<int> src, List<int> aux, List<int> des)
{
    int n = src.Count;

    return DFS(n, src, aux, des);
}