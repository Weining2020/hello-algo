/*
//是基于比较的，基于分治思想的。
//用到并列4循环。
void Merge(int[] nums, int left, int mid, int right)
{

    int len = right - left + 1;
    int[] tmp = new int[len];
    int i = left;
    int j = mid + 1;    //为了把[left, right]分为[left, mid]和[mid + 1, right]两个子区间。
    int k = 0;
    while (i <= mid && j <= right)
    {
        if (nums[i] < nums[j])
        {
            tmp[k] = nums[i];
            i++;
            k++;
        }
        else
        {
            tmp[k] = nums[j];
            j++;
            k++;
        }
    }


    for (global::System.Int32 i1 = i; i1 <= mid; i1++)  //这正确，其实写成while可读性更强。
    {
        tmp[k] = nums[i1];
        k++;
    }


    for (global::System.Int32 j1 = j; j1 <= right; j1++)    //这正确，其实写成while可读性更强。
    {
        tmp[k] = nums[j1];
        k++;
    }

    for (global::System.Int32 k1 = 0; k1 < tmp.Length; k1++)
    {
        nums[left + k1] = tmp[k1];
    }

}
void MergeSort(int[] nums, int left, int right)
{
    if (left >= right)
    {
        return;
    }

    //划分阶段。
    int mid = left + (right - left) / 2;
    MergeSort(nums, left, mid);
    MergeSort(nums, mid + 1, right);

    //合并阶段。
    Merge(nums, left, mid, right);
}
*/