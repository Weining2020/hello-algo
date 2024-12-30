void Move(List<int> src, List<int> tar)
{
    int pan = src[src.Count - 1];
    src.RemoveAt(src.Count - 1);
    tar.Add(pan);
}
void DFS(int i, List<int> src, List<int> buf, List<int> tar)
{
    if (i == 1)
    {
        Move(src, tar);
        return;
    }
    DFS(i - 1, src, tar, buf);
    Move(src, tar);
    DFS(i - 1, buf, src, tar);
}
void SolveHanota(List<int> A, List<int> B, List<int> C)
{
    int n = A.Count;
    DFS(n, A, B, C);
}