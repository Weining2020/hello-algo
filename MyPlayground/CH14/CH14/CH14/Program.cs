int EditDistanceDP(string s, string t)
{
    if (s == null && t == null)
    {
        return 0;
    }
    int n = s.Length;
    int m = t.Length;
    int[] dp = new int[m + 1];

    for (global::System.Int32 j = 1; j <= m; j++)
    {
        dp[j] = j;
    }
    for (global::System.Int32 i = 1; i <= n; i++)
    {
        int leftup = dp[0];
        dp[0] = i;
        for (global::System.Int32 j = 1; j <= m; j++)
        {
            int temp = dp[j]; //dp[j]马上要被更新为本行的dp[j]值了，我们马上要丢失上一行的dp[j]值了，即对于内层for循环的下一列来说马上要丢失左上角值了。因此先在暂时保存。
            if (s[i - 1] == t[j - 1])
            {
                dp[j] = dp[j - 1];
            }
            else
            {
                dp[j] = Math.Min(Math.Min(dp[j - 1], dp[j]), leftup) + 1;
            }
            leftup = temp;
        }
    }

    return dp[m];
}