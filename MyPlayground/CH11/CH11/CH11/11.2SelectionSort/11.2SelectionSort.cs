/*
int[] Selection(int[] nums)
{
    int n = nums.Length;
    for (global::System.Int32 i = 0; i < n - 1; i++)
    {
        int k = i;
        for (global::System.Int32 j = i + 1; j < n; j++)
        {
            if (nums[j] < nums[k])
            {
                k = j;
            }
        }
        (nums[i], nums[k]) = (nums[k], nums[i]);
    }
    return nums;
}
*/