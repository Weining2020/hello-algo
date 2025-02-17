//不是基于比较的，不是基于分治思想的。



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

    for (global::System.Int32 i = 1; i < counter.Length; i++)
    {
        counter[i] += counter[i - 1];
    }

    int[] res = new int[n];
    for (global::System.Int32 i = n - 1; i >= 0; i--)
    {
        res[counter[nums[i]] - 1] = nums[i];
        counter[nums[i]]--;
    }

    for (global::System.Int32 i = 0; i < n; i++)
    {
        nums[i] = res[i];
    }
}