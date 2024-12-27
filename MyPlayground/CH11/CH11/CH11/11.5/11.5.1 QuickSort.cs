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

void QuickSort(int[] nums, int left, int right)
{
    if (left >= right) //left == right：说明子数组的长度为 1，只有一个元素。对于长度为 1 的数组，不需要进行任何划分或排序，直接返回即可。left > right：说明输入的范围是无效的（比如 QuickSort(nums, 5, 4)），这种情况下也不需要做任何操作，直接返回即可。
    {
        return;
    }
    int pivot = Partition(nums, left, right);
    QuickSort(nums, left, pivot - 1); //这两句的顺序无所谓。
    QuickSort(nums, pivot + 1, right);

}
*/