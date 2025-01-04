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