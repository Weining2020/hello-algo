/*
int[] nums = { 1, 3, 6, 8, 12, 15, 23, 26, 31, 35 };



int BinarySearchInsertion(int[] nums, int target) //我写的和教程写的不完全一样。
{
    int tmpTarget = target + 1; //设置tmpTarget以 根据用户输入target 来模拟tmpTarget。
    int i = 0;
    int j = nums.Length - 1;
    while (i <= j) 
    {
        int m = i + (j - i) / 2;
        if (nums[m] < tmpTarget)
        {
            i = m + 1;
        }
        else if (nums[m] > tmpTarget)
        {
            j = m - 1;
        }
        else
        {
            j = m - 1; 
        }
    }
    if (j < 0 || nums[j] != target) //前一个判断，当目标值 target 比数组中所有元素都小（即target不存在于数组中），会返回i = 0,此时j = i - 1 = -1 < 0。后一个判断，当插入位置的元素值不是target，即数组中没找到target元素，也得返回-1。
    {
        return -1;
    }
    else
    {
        return j;
    }
}
*/

/*
//20250213 我认为我这个写法也对。
int BinarySearch(int[] nums, int target)
{
    int i = 0, j = nums.Length - 1;
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

int FindRightBoundary(int[] nums, int target)
{
    int i = BinarySearch(nums, target + 1);
    int j = i - 1;
    if (j < nums.Length && nums[j] == target)
    {
        return j;
    }
    return -1;
}
*/