/*
//最小路径和：暴力搜索。
int MinPathSumDFS(int[][] grid, int i, int j)
{
    if (i == 0 && j == 0)
    {
        return grid[0][0];
    }

    if (i < 0 || j < 0)
    {
        return int.MaxValue;
    }

    int up = MinPathSumDFS(grid, i - 1, j);
    int down = MinPathSumDFS(grid, i, j - 1);
    return Math.Min(up, down) + grid[i][j];
}
*/

/*
//最小路径和：记忆化搜索。
int MinPathSumDFSMem(int[][] grid, int[][] mem, int i, int j)
{
    if (i == 0 && j == 0)
    {
        return grid[i][j];
    }

    if (i < 0 || j < 0)
    {
        return int.MaxValue;
    }

    if (mem[i][j] != -1)
    {
        return mem[i][j];
    }

    int up = MinPathSumDFSMem(grid, mem, i - 1, j);
    int left = MinPathSumDFSMem(grid, mem, i, j - 1);
    mem[i][j] = Math.Min(up, left) + grid[i][j];

    return mem[i][j];
}
*/