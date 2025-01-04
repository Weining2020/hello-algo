/*
int ClimbingStairsDP(int n)
{
    if (n == 1 || n == 2)
    {
        return n;   //没错，就是返回n。本方法返回值是到达该阶有多少种方法。
    }
    int[] dp = new int[n + 1];
    dp[1] = 1;  //这里赋值直接是给dp[1]和dp[2]的，对应1阶和2阶。也就是说，整个ClimbingStarisDP()没有dp[0]的事，即没有0阶的事。
    dp[2] = 1;
    for (global::System.Int32 i = 3; i < n + 1; i++)    //i从3开始，因为3阶开始的结果需要计算。
    {
        dp[i] = dp[i - 2] + dp[i - 1];  //这里并不是递归调用，而是从dp数组中直接拿取之前已计算存储过得值。
    }
    return dp[n];
}
*/