/*
int DFS(int i)
{
    if (i == 1 || i == 2)
    {
        return i;
    }
    int count = DFS(i - 1) + DFS(i - 2);
    return count;
}
int ClimbingStairsDFS(int n)
{
    return DFS(n);
}
*/