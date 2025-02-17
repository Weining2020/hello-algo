/*
//是基于比较的，基于分治思想的。
//用到二叉树相关公式来做堆化。
//用到并列2循环 和 单独1循环。

void Swap(int[] nums, int left, int right)
{
    (nums[left], nums[right]) = (nums[right], nums[left]);
}
void SiftDown(int[] nums, int n, int i)
{
    while (true)
    {
        int l = 2 * i + 1;
        int r = 2 * i + 2;
        int ma = i;
        if (l < n && nums[l] > nums[ma])
        {
            ma = l;
        }
        if (r < n && nums[r] > nums[ma])
        {
            ma = r;
        }
        if (ma == i)
        {
            break;
        }
        Swap(nums, i, ma);
        i = ma;
    }
}
void HeapSort(int[] nums)
{
    int n = nums.Length;

    //初始建堆阶段。
    for (global::System.Int32 i = n / 2 - 1; i >= 0; i--)
    {
        SiftDown(nums, n, i);
    }

    //排序阶段。
    for (global::System.Int32 i = n - 1; i >= 1; i--)
    {
        Swap(nums, 0, i);
        SiftDown(nums, i, 0);
    }
}
*/