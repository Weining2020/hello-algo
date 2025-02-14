/*
int[] nums = { 1, 3, 6, 8, 12, 15, 23, 26, 31, 35 };



int BinarySearchInsertion(int[] nums, int target) //我写的和教程写的不完全一样。
{
    int i = 0;
    int j = nums.Length - 1;
    while (i <= j) 
    {
        int m = i + (j - i) / 2;
        if (nums[m] < target)
        {
            i = m + 1;
        }
        else if (nums[m] > target)
        {
            j = m - 1;
        }
        else
        {
            j = m - 1; 
        }
    }
    if (i == nums.Length || nums[i] != target) 
    {
        return -1;
    }
    else
    {
        return i;
    }
}
*/

/*
//20250213 我仔细想了想又写了一种解法。
int BinarySearch(int[] nums, int target)
{
    int n = nums.Length;
    int i = 0;
    int j = n - 1;
    while (i <= j)
    {
        int mid = i + (j - i) / 2;
        if (nums[mid] > target)
        {
            j = mid - 1;
        }
        else if (nums[mid] < target) 
        {
            i = mid + 1;
        }
        else
        {
            j = mid - 1;
        }
    }

    return i;
}

int FindLeftBoundary(int[] nums, int target)
{
    int i = BinarySearch(nums, target);
    if (i <= nums.Length - 1 && nums[i] == target)
    {
        return i;
    }
    return -1;
}
*/