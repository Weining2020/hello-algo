/*
//零钱兑换：动态规划。
int CoinChangeDP(int[] coins, int amt)
{
    int n = coins.Length;
    int MAX = amt + 1;
    int[,] dp = new int[n + 1, amt + 1];

    //dp[XXX, 0]的这一列不用特殊赋初始值，初始化时已经是0了。
    //dp[0，XXX]是硬币为0，无效解，值设置为amt+1。
    for (global::System.Int32 a = 1; a <= amt; a++)
    {
        dp[0, a] = MAX;
    }

    //第二步，应用状态转移公式。
    for (global::System.Int32 i = 1; i <= n; i++)
    {
        for (global::System.Int32 a = 1; a <= amt; a++)
        {
            if (coins[i - 1] > a)
            {
                dp[i, a] = dp[i - 1, a]; //当硬币 coins[i - 1] > a（当前硬币无法凑成金额 a）时：当前硬币面值coins[i−1] 不能参与凑成金额a 的选择。此时，我们只能依赖前i−1 种硬币来凑成金额a，因此：dp[i,a]=dp[i−1,a]。

            }
            else
            {
                dp[i, a] = Math.Min(dp[i - 1, a], dp[i, a - coins[i - 1]] + 1);
            }
        }
    }

    return dp[n, amt] != MAX ? dp[n, amt] : -1;
}
*/
/*

//零钱兑换：空间优化后的动态规划。
int CoinChangeDPComp(int[] coins, int amt)
{
    int n = coins.Length;
    int MAX = amt + 1;
    int[] dp = new int[ amt + 1];

    //dp[XXX, 0]的这一列不用特殊赋初始值，初始化时已经是0了。
    //dp[0，XXX]是硬币为0，无效解，值设置为amt+1。
    dp[0] = MAX;

    //第二步，应用状态转移公式。
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
                dp[a] = Math.Min(dp[a], dp[a - coins[i - 1]] + 1);
            }
        }
    }

    return dp[amt] != MAX ? dp[amt] : -1;
}
*/