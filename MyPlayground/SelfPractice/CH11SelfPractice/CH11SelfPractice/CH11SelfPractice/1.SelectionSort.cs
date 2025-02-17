/*
//是基于比较的，不基于分治思想的。
//用k标记最小值的索引，然后交换。用到两层嵌套for。
void SelectionSort(int[] nums)
{
    int n = nums.Length;
    for (global::System.Int32 i = 0; i < n - 1; i++)    //我认为右端最后一个元素不必遍历，直接就剩个最大值了。
    {
        int k = i; //k用来记录最小值索引。
        for (global::System.Int32 j = i + 1; j < n; j++)
        {
            if (nums[j] < nums[k])  //k动态更新记录最小值索引。
            {
                k = j;
            }
        }
        (nums[i], nums[k]) = (nums[k], nums[i]);
    }
}
*/