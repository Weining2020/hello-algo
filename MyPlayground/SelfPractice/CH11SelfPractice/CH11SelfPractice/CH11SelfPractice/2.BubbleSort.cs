/*
//是基于比较的，不基于分治思想的。
//相邻两元素进行比较，右边大于左边时交换。用到两层嵌套for。
//存在flag优化。
void BubbleSort(int[] nums)
{
    int n = nums.Length;
    for (global::System.Int32 i = n - 1; i > 0; i++)    //最左边元素不用比较，自动就是nums最小元素。
    {
        bool flag = false;
        for (global::System.Int32 j = 0; j < i; j++)
        {
            if (nums[j] > nums[j + 1])
            {
                (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                flag = true;
            }
        }
        if (!flag)
        {
            break;
        }
    }
}
*/