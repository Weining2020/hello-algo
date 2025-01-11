//归并排序。
void Merge(int[] nums, int left, int mid,int right)
{
    int i = left;
    int j = mid + 1;
    int[] tmp = new int[right - left + 1];
    int k = 0;

    while (i <= mid && j <= right)
    {
        if (nums[i] <= nums[j])
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

    while (i <= mid)
    {
        tmp[k] = nums[i];
        i++;
        k++;
    }
    while (j <= right)
    {
        tmp[k] = nums[j];
        j++;
        k++;
    }

    for (global::System.Int32 m = 0; m < tmp.Length; m++)
    {
        nums[m + left] = tmp[m];
    }
}
void MergeSort(int[] num, int left, int right)
{
    if (left >= right)
    {
        return;
    }

    int mid = left + (right - left) / 2;
    MergeSort(num, left, mid);
    MergeSort(num, mid + 1, right);

    Merge(num, left, mid, right);
}