/*
//方法一
//转换为找最右一个target的位置。
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
            i = m + 1;
        }
    }
    return j;
}
int BinarySearchRightEdge(int[] nums, int target)    //代码和教程不完全一致，但是效果完全一致。
{
    int j = BinarySearchInsertion(nums, target);    //i值有三种结果。1) i为nums.Length,这已越界，这是因为target大于所有nums元素。 2.1) i为0（0当然未越界），这可能是因为target小于所有nums元素,也可能是因为最左一个target真的碰巧在索引0上。2.2)i值为某个非0的合法索引值，这可能是因为i指向第一个大于target的元素，也可能是因为最左一个target在i索引上。
    if (j == -1)   //用来处理当target大于nums所有元素时的情况。
    {
        return -1;
    }
    if (nums[j] == target) //用来处理真的找到最左一个target的情况。
    {
        return j;
    }
    return -1;  //其他所有情况，都说明没找到target。
}
*/

/*
//方法二
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
int BinarySearchRightEdge(int[] nums, int target)    //代码和教程不完全一致，但是效果完全一致。
{
    int i = BinarySearchInsertion(nums, target + 1);
    int j = i - 1;
    if (j == -1)   //if (j == -1) 主要用于处理 target + 1 比 nums 所有元素都小的情况，但它也能间接处理 target 本身比所有 nums 元素都小的情况。
    {
        return -1;
    }
    if (nums[j] == target) 
    {
        return j;
    }
    return -1;  //其他所有情况，都说明没找到target。
}
*/

/*
//方法三。
int BinarySearchInsertion(double[] nums, double target)
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
int BinarySearchRightEdge(int[] nums, int target)
{
    return BinarySearchInsertion(Array.ConvertAll(nums, x => (double)x), target + 0.5) - 1;
}
int BinarySearchLeftEdge(int[] nums, int target)
{
    return BinarySearchInsertion(Array.ConvertAll(nums, x => (double)x), target - 0.5);
}
*/