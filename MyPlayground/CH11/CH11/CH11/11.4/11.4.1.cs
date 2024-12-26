/*
void InsertionSort(int[] nums)
{
    int n = nums.Length;
    //已排序区域：[0, i - 1]。
    for (global::System.Int32 i = 1; i < n; i++)
    {
        //用于与bas比较大小的元素们 所在区域 就是 已排序区域。
        int j = i - 1;
        int bas = nums[i];
        while (j >= 0 && nums[j] > bas)
        {

            nums[j + 1] = nums[j];

            j--;
        }
        nums[j + 1] = bas;
    }
}
*/