/*
//0-1 背包：暴力搜索。
int KnapsackDFS(int[] weight, int[] val, int i, int c) //Knapsack是背包的意思，这个单词来源于德语。
{
    //终止条件。
    if (i == 0 || c == 0)
    {
        return 0;
    }

    //剪枝。
    if (weight[i - 1] > c)
    {
        return KnapsackDFS(weight, val, i - 1, c); //因为超重，无法放入第i个物品，因此正确的做法是直接跳过这个物品，转移到下一个状态。
    }

    //返回值部分的代码。
    // 对于选择 **不把第 i 个物品放入背包** 的情况：在这种情况下，在物品i处的解是“包里仅有前 i-1 个物品，并且背包容量保持为 c 的最大价值”。
    int lastStateSimple = KnapsackDFS(weight, val, i - 1, c);
    // 对于选择 **把第 i 个物品放入背包** 的情况：在这种情况下，在物品i处的解是“包里有前 i-1 个物品，包的容量减少为 c - weight[i-1] 时 的最大价值”加上第 i 个物品本身的价值 val[i-1]。
    int lastStateComplex = KnapsackDFS(weight, val, i - 1, c - weight[i - 1]) + val[i - 1];

    return Math.Max(lastStateSimple, lastStateComplex);
}
*/
/*
//0-1 背包：记忆化搜索。
int KnapsackDFSMem(int[] weight, int[] val, int[][] mem, int i, int c) //这个方法的设计是，方法内部无需构建mem数组，b/c是用户传进来的。方法内部只需更新mem数组。
{
    if (i == 0 || c == 0)
    {
        return 0;
    }

    if (weight[i - 1] > c)
    {
        return KnapsackDFSMem(weight, val, mem, i - 1, c); //在KnapsackDFSMem(weight, val, mem, i - 1, c);内部，不会对mem[i, c]赋值，而是对mem[i -1, c]赋值。只是这个mem[i -1, c]这个值会被作为结果 从 KnapsackDFSMem(weight, val, mem, i , c)这个调用中返回出去。
    }

    if (mem[i][c] != -1)
    {
        return mem[i][c];
    }

    //更新mem数组。

    int no = KnapsackDFSMem(weight, val, mem, i - 1, c);
    int yes = KnapsackDFSMem(weight, val, mem, i - 1, c - weight[i - 1]) + val[i - 1];
    mem[i][c] = Math.Max(no, yes);
    return mem[i][c];
}

*/
/*
//0-1 背包：动态规划。
int KnapsackDP(int[] weight, int[] val, int cap) //特点是没有用户输入的物品i了。因为dp表会包含所有状态的解。
{
    int n = weight.Length;
    int[,] dp = new int[n + 1, cap + 1]; //dp中每一行的元素们，都是针对 在同一物品处的各状态的解。


    ////首行。//对于dp[0, XXXX]的值。
    //for (global::System.Int32 j = 0; j < cap + 1; j++)
    //{
    //    dp[0, j] = 0;
    //}
    ////首列。//对于dp[XXXX, 0]的值。
    //for (global::System.Int32 i = 0; i < n + 1; i++)
    //{
    //    dp[i, 0] = 0;
    //}

    //第二步，递推公式。
    for (global::System.Int32 i = 1; i < n + 1; i++)
    {
        for (global::System.Int32 j = 1; j < cap + 1; j++) //j为所有可能的cap值。
        {
            if (weight[i - 1] > j)
            {
                dp[i, j] = dp[i - 1, j]; //当物品i 超重时（即weight[i - 1] > j），dp[i, j] 的值应该是继承上一行的结果。
            }
            else
            {
                int no = dp[i - 1, j];
                int yes = dp[i - 1, j - weight[i - 1]] + val[i - 1];
                dp[i, j] = Math.Max(no, yes);
            }

        }
    }
    return dp[n, cap];
}
*/
/*
//0-1 背包：空间优化后的动态规划。这个比教程应该更加简洁合理了。
int KnapsackDPComp(int[] weight, int[] val, int cap)
{
    int n = weight.Length;
    // dp 数组记录当前背包容量对应的最大价值
    int[] dp = new int[cap + 1];

    for (int i = 1; i <= n; i++) // 遍历每个物品
    {
        for (int j = cap; j >= weight[i - 1]; j--) // 从大到小遍历背包容量 //这里设置条件是j >= weight[i - 1]，和教程不一样。
        {
            // 状态转移：选择不放或放入当前物品
            dp[j] = Math.Max(dp[j], dp[j - weight[i - 1]] + val[i - 1]);
        }
    }
    // 返回背包容量为 cap 时的最大价值
    return dp[cap];
}
*/