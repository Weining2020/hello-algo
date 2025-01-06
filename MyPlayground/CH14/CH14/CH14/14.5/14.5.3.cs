/*
//零钱兑换 II：动态规划。
int CoinChangeIIDP(int[] coins, int amt)
{
    int n = coins.Length;
    //构造2-D dp表。
    int[,] dp = new int[n + 1, amt + 1];

    //初始条件设置。
    for (global::System.Int32 i = 0; i <= n; i++)
    {
        dp[i, 0] = 1;
    }

    //应用状态转移公式。
    for (global::System.Int32 i = 1; i <= n; i++)
    {
        for (global::System.Int32 a = 1; a <= amt; a++)
        {
            if (coins[i - 1] > a)
            {
                dp[i, a] = dp[i - 1, a];
            }
            else
            {
                dp[i, a] = dp[i - 1, a] + dp[i, a - coins[i - 1]];
            }
        }
    }

    return dp[n, amt];
}
*/

/*
//零钱兑换 II：空间优化后的动态规划。
int CoinChangeIIDPComp(int[] coins, int amt)
{
    int n = coins.Length;
    int[] dp = new int[amt + 1];

    //初始状态dp[0] = 1，其他dp[a]全部为0。
    dp[0] = 1;


    for (global::System.Int32 i = 1; i <= n; i++)
    {
        for (global::System.Int32 a = 1; a <= amt; a++)
        {
            if (coins[i - 1] > a)
            {
                dp[a] = dp[a];
            }
            else
            {
                dp[a] = dp[a] + dp[a - coins[i - 1]];
            }
        }
    }

    return dp[amt];
}
*/