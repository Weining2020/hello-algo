//编辑距离：空间优化后的动态规划。
int EditDistanceDPComp(string s, string t)
{
    int n = s.Length;
    int m = t.Length;

    int[] dp = new int[m + 1];

    for (global::System.Int32 j = 1; j <= m; j++)   //我觉得j=0还是j=1开始，在效果上都是一样的效果。j=0稍显冗余，b/c 初始化时就是0了。
    {
        dp[j] = j;
    }

    for (global::System.Int32 i = 1; i <= n; i++)
    {
        int leftup = dp[0]; //这是新的一行的最开始，我们用上一行的第一个元素初始化leftup。这个leftup变量会在每一行遍历列时充当左上角值。
        dp[0] = i;  //dp[0]在每一行是不一样的值。这个很好理解。
        for (global::System.Int32 j = 1; j <= m; j++)
        {
            int temp = dp[j]; //此时的dp[j]依然为上一行计算全部结束时的dp[j]，即属于上一行的结果。我们暂存的目的是，dp[j]马上要在本行的遍历列中，更新为本行的计算结果了。但我们又需要上一行的dp[j]结果来充当 本行j+1位置的左上角值，因此暂存。
            if (s[i -1] == t[j-1])
            {
                dp[j] = leftup; //由leftup变量充当左上角值。
            }
            else
            {
                dp[j] = Math.Min(Math.Min(dp[j - 1], dp[j]), leftup) + 1; //同理，由leftup变量充当左上角值。
            }
            leftup = temp;  //下一个要进行的是j+1位置的dp值计算，即对于本行的j+1位置，我们需要上一行的dp[j]（左上角）值，那么我们就把temp赋给leftup作为j+1位置的左上角值,b/c 此时temp依然保持为上一行的dp[j]值呢。
        }
    }
    return dp[m];
}