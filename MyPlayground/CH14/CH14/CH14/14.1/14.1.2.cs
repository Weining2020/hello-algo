/*
int DFS(int i, int[] mem)
{
    if (i == 1 || i == 2)
    {
        return i;
    }
    if (mem[i] != -1) //呼应最开始填充-1。
    {
        return mem[i];
    }
    int count = DFS(i - 1, mem) + DFS(i - 2, mem);
    mem[i] = count;
    return count;
}
int ClimbingStairsDFS(int n)
{
    int[] mem = new int[n + 1];  //没错，就得是n+1。
    Array.Fill(mem, -1);    //别忘了先都填充成-1。这是为了后续好判断是否曾经保存过计算结果。
    return DFS(n, mem);
}
*/