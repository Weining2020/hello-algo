
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