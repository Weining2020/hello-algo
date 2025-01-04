/*
int ClimbingStairsConstraintDP(int n)
{
    if (n == 1 || n == 2)
    {
        return n;
    }

    int[,] dp = new int[n + 1, 3]; //初始化二维数组，第一维的大小是 n + 1，表示有n+1 行，索引范围是 0, 1, 2, ..., n。第二维的大小是 3，表示有3 列，索引范围是 0, 1, 2。
    dp[1, 1] = 1;
    dp[1, 2] = 0;
    dp[2, 1] = 0;   //确实是0，因为绝不可能从0阶跳一步到1阶，再从1阶跳一步到2阶，这违反规则了。
    dp[2, 2] = 1;
    for (global::System.Int32 i = 0; i < n + 1; i++)
    {
        dp[i, 1] = dp[i - 1, 2];
        dp[i, 2] = dp[i - 2, 1] + dp[i - 2, 2];
    }
    return dp[n, 1] + dp[n, 2];
}
*/