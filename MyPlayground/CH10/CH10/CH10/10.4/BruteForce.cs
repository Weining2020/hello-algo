//方法一：暴力枚举。

int[] TwoSumBruteForce(int[] nums, int target)
{
    for (global::System.Int32 i = 0; i < nums.Length; i++)  //这里可以就写成i < nums.Length而不是i < nums.Length - 1。即使 i = nums.Length - 1 时进入外层循环，内层循环 j 无法进入有效范围，外层循环的最后一次迭代不会影响结果。因此，直接写 i < nums.Length 是安全的。
    {
        for (global::System.Int32 j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                return new int[] { i, j };
            }
        }
    }
    return Array.Empty<int>();
}