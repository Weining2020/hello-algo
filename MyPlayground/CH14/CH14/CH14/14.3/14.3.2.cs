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
/*
//动态规划。
int MinPathSumDP(int[][] grid)
{
    int n = grid.Length; //获取grid的行数。
    int m = grid[0].Length; //获取grid的列数。
    int[,] dp = new int[n, m]; // 创建一个大小为 n x m 的二维数组 dp。
    dp[0, 0] = grid[0][0];

    for (global::System.Int32 i = 1; i < n; i++) //给dp的首列赋值。
    {
        dp[i, 0] = dp[i - 1, 0] + grid[i][0];
    }
    for (global::System.Int32 j = 1; j < m; j++) //给dp的首行赋值。
    {
        dp[0, j] = dp[0, j - 1] + grid[0][j];
    }
    for (global::System.Int32 y = 1; y < n; y++)
    {
        for (global::System.Int32 z = 1; z < m; z++)
        {
            dp[y, z] = Math.Min(dp[y - 1, z], dp[y, z - 1]) + grid[y][z];
        }
    }

    return dp[n - 1, m - 1]; //返回了最右下角这个点的解。
}
*/

/*
//动态规划之空间优化后的版本。
int MinPathSumDP(int[][] grid)
{
    int n = grid.Length;
    int m = grid[0].Length;
    int[] dp = new int[m];
    dp[0] = grid[0][0];

    for (global::System.Int32 j = 1; j < m; j++)
    {
        dp[j] = dp[j - 1] + grid[0][j];
    }

    //对于其他行（从二行开始,一行已经在上面for处理过了）。
    for (global::System.Int32 i = 1; i < n; i++)
    {
        dp[0] = dp[0] + grid[i][0];
        for (global::System.Int32 j = 1; j < m; j++)
        {
            dp[j] = Math.Min(dp[j - 1], dp[j]) + grid[i][j];
        }
    }


    return dp[m - 1]; //返回了最右下角这个点的解。
}
*/