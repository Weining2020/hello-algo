/*
//元素交换。
void Swap(int[] nums, int i, int j)
{
    (nums[j], nums[i]) = (nums[i], nums[j]);
}
//哨兵划分。//别误解了，本函数目的是返回 基准数的索引。
int Partition(int[] nums, int left, int right)
{
    //本方法 是从 把nums[left]当做基准数 开始的。
    int i = left; 
    int j = right;
    while (i < j)
    {
        while (i < j && nums[j] >= nums[left]) //内层while，得加上i < j条件才行，不然在内层while会一直进行到i>=j的程度，就错了。
        {
            j--;
        }
        while (i < j && nums[i] <= nums[left])
        {
            i++;
        }
        Swap(nums, i, j); //交换i和j 索引上的元素，为了构建左子数组和右子数组，但还没进行基准数和分界线元素的交换。
    }
    Swap(nums, i, left); //这里才是进行基准数和分界线元素的交换。
    return i; //i是分界线的索引，left一直是左子数组的左边界，别弄混了。
}
*/