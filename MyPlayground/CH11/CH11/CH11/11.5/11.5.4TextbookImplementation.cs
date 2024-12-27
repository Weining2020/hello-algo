/*

//元素交换。
void Swap(int[] nums, int i, int j)
{
    (nums[j], nums[i]) = (nums[i], nums[j]);
}
//哨兵划分。//别误解了，本函数目的是返回 基准数的索引。
int Partition(int[] nums, int left, int right)
{
    //先根据MedianThree()来挑出个合适的基准元素。
    int med = MedianThree(nums, left, (left + (right - left) / 2), right);
    //把挑出来的更合适的基准元素放到left索引上。放到left索引上的元素才是基准元素。
    Swap(nums, left, med);

    //下面的操作和原版完全一样。
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

int MedianThree(int[] nums, int left, int mid, int right) //整个方法的意义是找到left, mid, right 三个索引上的元素中，大小居中的那个元素。我们left, mid, right这三个索引 是根据用户调用MedianThree()方法时user input来的，因此三者中任何一个索引上的元素都可能为居中元素。//总的目的是，我们可以返回一个索引值 指向 非极端元素值（e.g.最大值），来避免选中极端值来当基准数 使得 QuickSort恶化成O(n^2)。//本方法是返回索引值，不是返回元素值！
{
    int l = nums[left];
    int m = nums[mid];
    int r = nums[right];
    //这下面其实是三个if，分别处理left, mid, right索引上元素为居中元素的情况。不信的话，比划试试，确实是这几种条件。
    if ((l <= m && m <= r) || (r <= m && m <= l)) 
    {
        return mid;
    }
    if ((m <= l && l <= r) || (r <= l && l <= m))
    {
        return left;
    }
    return right;
}
void QuickSort(int[] nums, int left, int right)
{
    if(left >= right)
    {
        return;
    }
    int pivot = Partition(nums, left, right);
    QuickSort(nums, left, pivot - 1);
    QuickSort(nums, pivot + 1, right);
}
*/