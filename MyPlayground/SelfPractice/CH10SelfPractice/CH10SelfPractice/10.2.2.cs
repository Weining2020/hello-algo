/*
//转换为找最左一个target的位置。
int BinarySearchInsertion(int[] nums, int target)
{
    int n = nums.Length;
    int i = 0;
    int j = n - 1;
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
        else if (nums[m] == target)
        {
            j = m - 1;
        }
    }
    return i;
}
*/