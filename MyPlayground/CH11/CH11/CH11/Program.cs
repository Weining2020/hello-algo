void CoutingSort(int[] nums)
{
    int m = 0;
    foreach (int num in nums)
    {
        m = Math.Max(m, num);
    }

    int[] counter = new int[m + 1];
    foreach (int num in nums)
    {
        counter[num]++;
    }

    int[] prefix = new int[counter.Length];
    prefix[0] = counter[0]; //想想吧，这个有必要。前缀和是元素值之和，不是元素索引之和。因此prefix上来第一个元素值不一定是0，而是取决于counter数组元素值。
    for (global::System.Int32 i = 1; i < prefix.Length; i++)
    {
        prefix[i] = prefix[i - 1] + counter[i];
    }

    int[] res = new int[nums.Length];
    for (global::System.Int32 i = nums.Length - 1; i >= 0; i--)
    {
        int num = nums[i]; //用num接着nums数组的元素。
        int lastIndex = prefix[num] - 1; // 找到 num 在结果数组中的位置
        res[lastIndex] = num; //填充nums的元素num到合适索引上。
        prefix[num]--; // 更新前缀和，确保稳定排序
    }

    for (global::System.Int32 i = 0; i < nums.Length; i++)
    {
        nums[i] = res[i];
    }
}