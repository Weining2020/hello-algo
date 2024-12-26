/*
//我自己写的冒泡排序，和教程完全不同，但是也对。
void BubbleSort(int[] nums)
{
    int n = nums.Length;
    int k = n - 1;
    while (k > 0)
    {
        for (global::System.Int32 i = 0; i < k; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
            }
        }
        k--;
    }
}
*/
/*

//教程的写法。
void BubbleSort(int[] nums)
{
    for (global::System.Int32 i = nums.Length - 1; i > 0; i--)
    {
        for (global::System.Int32 j = 0; j < i; j++)
        {
            if (nums[j] > nums[j + 1])
            {
                (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
            }
        }
    }
}
*/