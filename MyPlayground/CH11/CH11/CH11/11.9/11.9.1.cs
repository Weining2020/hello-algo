/*
void CountingSortNaive(int[] nums)
{
    //找到最大元素m。
    int m = 0;
    foreach (int num in nums)
    {
        if (num > m)
        {
            m = num;
        }
    }

    //辅助数组counter。
    int[] counter = new int[m + 1];

    foreach (int num in nums)
    {
        counter[num]++;
    }

    int j = 0;
    for (global::System.Int32 num = 0; num < counter.Length; num++)
    {
        while (counter[num] > 0)
        {
            nums[j] = num;
            j++;
            counter[num]--;
        }
    }
}
*/