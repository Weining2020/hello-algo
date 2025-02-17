/*
//是基于比较的，基于分治思想的。
//有基准数优化，尾递归优化。
//用到两层嵌套循环。

void Swap(int[] nums, int i, int j)
{
    (nums[i], nums[j]) = (nums[j], nums[i]);
}
int MedianThree(int[] nums, int left, int mid, int right)
{
    int l = nums[left];
    int r = nums[right];
    int m = nums[mid];
    if ((m >= l && l >= r) || (m <= l && l <= r))
    {
        return left;
    }
    if ((l >= m && m >= r) || (l <= m && m <= r))
    {
        return mid;
    }
    return right;
}
int Partition(int[] nums, int left, int right)
{
    int med = MedianThree(nums, left, left + (right - left) / 2, right);
    Swap(nums, left, med);

    int i = left;
    int j = right;
    int bas = nums[left];
    while (i < j)
    {
        while (i < j && nums[j] >= bas) //先写右侧的查询索引操作。
        {
            j--;
        }
        while (i < j && nums[i] <= bas)
        {
            i++;
        }
        Swap(nums, i, j);
    }
    Swap(nums, i, left);
    return i;
}
void QuickSort(int[] nums, int left, int right)
{
    while (left < right)
    {
        int n = nums.Length;
        int pivot = Partition(nums, left, right);
        if (pivot - left < right - pivot)
        {
            QuickSort(nums, left, pivot - 1);
            left = pivot + 1;
        }
        else
        {
            QuickSort(nums, pivot + 1, right);
            right = pivot - 1;
        }
    }
}
*/