public int FindRightBoundary(int[] nums, int target)
{
    double fakeTarget = target + 0.5;
    int n = nums.Length;
    int i = 0;
    int j = n - 1;
    while (i <= j)
    {
        int mid = i + (j - i) / 2;
        if (nums[mid] > fakeTarget)
        {
            j = mid - 1;
        }
        else if (nums[mid] < fakeTarget)
        {
            i = mid + 1;
        }
        else
        {
            j = mid - 1;
        }
    }

    if (j == -1 )
    {
        
    }
}