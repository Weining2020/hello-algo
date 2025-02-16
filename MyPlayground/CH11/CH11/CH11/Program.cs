void CountingSort(int[] nums)
{
    int n = nums.Length;

    int max = 0;
    foreach (var num in nums)
    {
        max = Math.Max(max, num);
    }

    int[] counter = new int[max + 1];
    foreach (var num in nums)
    {
        counter[num]++;
    }

    //构造前缀和数组。
    int[] prefix = new int[counter.Length];
    prefix[0] = counter[0];
    for (global::System.Int32 i = 0; i < counter.Length - 1; i++)
    {
        prefix[i + 1] = prefix[i] + counter[i + 1];
    }

    int[] res = new int[n];
    for (global::System.Int32 i = n - 1; i >= 0; i--)
    {
        int num = nums[i];
        res[prefix[num] - 1] = num;
        prefix[num]--;
    }

    for (global::System.Int32 i = 0; i < n; i++)
    {
        nums[i] = res[i];
    }
}