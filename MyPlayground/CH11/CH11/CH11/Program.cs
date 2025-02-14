void Swap(int[] nums, int i, int j)
{
    (nums[i], nums[j]) = (nums[j], nums[i]);
}

int Partition(int[] nums, int left, int right)
{
    int i = left;
    int j = right;
    int bas = nums[left];
    while (i < j)   //=的时候呢？
    {
        while (i < j && nums[j] >= bas)
        {
            j--;
        }
        while (i < j && nums[i] <= bas)
        {
            i++;
        }
        Swap(nums, i, j);
    }
    Swap(nums, i, left);
    return i;
}