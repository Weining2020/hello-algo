/*


int MinCostClimbingStairsDP(int[] cost)
{
    int n = cost.Length - 1; //没错，一共还是n阶，共n + 1个元素（其中index为0的元素是0阶的代价，无意义）。
    if (n == 1 || n == 2)
    {
        return cost[n];
    }

    int[] dp = new int[n + 1]; //没错，一共还是n阶，共n + 1个元素（其中index为0的元素是0阶，无意义）。
    dp[1] = cost[1];
    dp[2] = cost[2];
    for (global::System.Int32 i = 3; i < n + 1; i++)
    {
        dp[i] = Math.Min(dp[i - 1], dp[i - 2]) + cost[i];
    }
    return dp[n];
}
*/
/*
//空间复杂度优化后写法：
int MinCostClimbingStairsDP(int[] cost)
{
    int n = cost.Length - 1;
    cost[1] = 1; cost[2] = 10;
    if (n == 1 || n == 2)
    {
        return cost[n]; //cost[1]和cost[2]就相当于dp[1]和dp[2]。
    }

    int a = cost[1]; //这里a和b就相当于dp[1]和dp[2]。要用中间变量实现变量滚动，需要用到dp[1]和dp[2]。
    int b = cost[2];
    for (global::System.Int32 i = 0; i < n; i++)
    {
        int tmp = b;
        b = Math.Min(a, tmp) + cost[i];
        a = tmp;
    }
    return cost[n];
}
*/