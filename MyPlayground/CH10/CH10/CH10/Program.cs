int[] nums = { 1, 3, 6, 8, 12, 15, 23, 26, 31, 35 };
//int[] nums1 = { 1, 3, 7, 8, 12, 15, 23, 26, 31, 35 }; //我修改了数组，以验证整个二分查找i和j的变化过程。

//二分查找（双闭区间）。//嗯，我自己也写出来了。
int res = BinarySearch(nums, 6);
Console.WriteLine(res);
int BinarySearch(int[] nums, int target)
{
    // 初始化双闭区间 [0, n-1] ，即 i, j 分别指向数组首元素、尾元素
    int i = 0, j = nums.Length;
    // 循环，当搜索区间为空时跳出（当 i > j 时为空）
    while (i < j) //没错，最后跳出时，i=2,j=1。
    {
        int m = i + (j - i) / 2;   // 计算中点索引 m
        if (nums[m] < target)      // 此情况说明 target 在区间 [m+1, j] 中
            i = m + 1;
        else if (nums[m] > target) // 此情况说明 target 在区间 [i, m-1] 中
            j = m;
        else                       // 找到目标元素，返回其索引
            return m;
    }
    // 未找到目标元素，返回 -1
    return -1;
}