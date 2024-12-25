/*
int[] nums = { 1, 3, 6, 8, 12, 15, 23, 26, 31, 35 };


int BinarySearchInsertionSimple(int[] nums, int target)
{
    int i = 0;
    int j = nums.Length - 1;
    while (i <= j) //必须得是i<=j而不能是i<j，e.g.int[] nums = { 1, 3, 5, 6 };int target = 7; 如果是i<j，则i=j=3时直接退出，return i = 3,这是错误的。
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
            return m;
        }
    }
    return i;
}
*/