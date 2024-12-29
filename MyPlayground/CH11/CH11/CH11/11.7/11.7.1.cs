/*
void SiftDown(int[] nums, int n, int i)
{
    while (true)
    {
        int l = 2 * i + 1;
        int r = 2 * i + 2;
        int ma = i;
        if (l < r && nums[l] > nums[ma])
        {
            ma = l;
        }
        if (l < r && nums[r] > nums[ma])
        {
            ma = r;
        }

        if(ma==i)
        {
            break;
        }

        (nums[i], nums[ma]) = (nums[ma], nums[i]);

        i = ma;

    }
}
void HeapSort(int[] nums)
{
    for (global::System.Int32 i = nums.Length / 2 - 1; i >= 0; i--) //从最后一个父节点开始做堆化。
    {
        SiftDown(nums, nums.Length, i);
    }
    for (global::System.Int32 i = nums.Length - 1; i > 0; i--)
    {
        (nums[i], nums[0]) = (nums[0], nums[i]);
        SiftDown(nums, i, 0);
    }
}
*/