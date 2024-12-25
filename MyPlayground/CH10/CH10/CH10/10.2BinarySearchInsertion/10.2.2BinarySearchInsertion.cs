/*
int[] nums = { 1, 3, 6, 8, 12, 15, 23, 26, 31, 35 };



int BinarySearchInsertion(int[] nums, int target) //整个方法不是在寻找 最后一个小于 target的元素，而是在寻找第一个target元素，因为第一个target元素的位置才是我们要插入的位置。
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
            j = m - 1; //nums[m] = target了，即最后一个比target小的元素应在m左边，即在[i, m-1]的区间内，因此把j更新为m-1。此后再进行的while循环，直到i越过j时，i必为第一个target元素，此时跳出循环了，返回i了，结束。
        }
    }
    return i;
}
*/