/*
//是基于比较的，不基于分治思想的。
//用到两层嵌套循环。
void InsertionSort(int[] nums)
{
    int n = nums.Length;
    for (global::System.Int32 i = 1; i < n; i++)    //首元素视为有序。开始i这一轮循环前，i为无序。
    {
        int bas = nums[i];
        int j = i - 1;
        while (j >= 0 && nums[j] > bas)
        {
            nums[j + 1] = nums[j];
            j--;
        }
        nums[j + 1] = bas;
    }
}
*/