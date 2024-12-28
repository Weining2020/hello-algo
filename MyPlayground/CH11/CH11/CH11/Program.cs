void Merge(int[] nums, int left, int mid, int right)
{
    int[] tmp = new int[right - left + 1];
    int i = left;
    int j = mid + 1;
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
    while (j <= mid)
    {
        tmp[k] = nums[j];
        j++;
        k++;
    }

    for (global::System.Int32 x = 0; x < tmp.Length; x++)
    {
        nums[x + left] = tmp[x];
    }
}
void MergeSort(int[] nums, int left, int right)
{
    if (left >= right)
    {
        return;
    }

    int mid = left + (right - left) / 2;

    MergeSort(nums, left, mid);
    MergeSort(nums, mid + 1, right);

    Merge(nums, left, mid, right);
}