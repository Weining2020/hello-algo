/*
//完全背包：动态规划。
int UnboundedKnapsackDP(int[] wgt, int[] val, int cap)
{
    int n = wgt.Length;

    int[,] dp = new int[n + 1, cap + 1];

    for (global::System.Int32 i = 1; i <= n; i++)
    {
        for (global::System.Int32 c = 1; c <= cap; c++)
        {
            if (wgt[i - 1] > c)
            {
                dp[i, c] = dp[i - 1, c];
            }
            else
            {
                dp[i, c] = Math.Max(dp[i - 1, c], dp[i, c - wgt[i - 1]] + val[i - 1]);
            }
        }
    }
    return dp[n, cap];
}
*/
/*
//完全背包：空间优化后的动态规划。
int UnboundedKnapsackDPComp(int[] wgt, int[] val, int cap)
{
    int n = wgt.Length;

    int[] dp = new int[cap + 1];

    for (global::System.Int32 i = 1; i <= n; i++)
    {
        for (global::System.Int32 c = 1; c <= cap; c++)
        {
            if (wgt[i - 1] > c)
            {
                dp[c] = dp[c];
            }
            else
            {
                dp[c] = Math.Max(dp[c], dp[c - wgt[i - 1]] + val[i - 1]);
            }
        }
    }
    return dp[cap];
}
*/