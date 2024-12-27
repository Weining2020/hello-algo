/*
//1.选择排序。

void SelectionSort(int[] nums)
{
    int n = nums.Length;
    for (global::System.Int32 i = 0; i < n - 1; i++)
    {
        int k = i; //在j循环开始前，要把k设置成i，因为未排序空间为[i, n-1], 即nums[i]也得参与比较，我们用k来接着i。
        for (global::System.Int32 j = i + 1; j < n; j++)
        {
            if (nums[j] < nums[k])
            {
                k = j;
            }
        }
        (nums[k], nums[i]) = (nums[i], nums[k]);
    }
}
*/

/*
//2.冒泡排序。
void BubbleSort(int[] nums)
{
    int n = nums.Length;
    for (global::System.Int32 i = n - 1; i > 0; i--)
    {
        for (global::System.Int32 j = 0; j < i; j++)
        {
            if (nums[j] > nums[j+1])
            {
                (nums[j], nums[j+1]) = (nums[j+1], nums[j]);
            }
        }
    }
}
*/
/*
//3.插入排序。
void InsertionSort(int[] nums)
{
    for (global::System.Int32 i = 1; i < nums.Length; i++)
    {
        int bas = nums[i];
        int j = i - 1;
        while (j >= 0 && nums[j]>bas)
        {
            nums[j + 1] = nums[j]; //没错我想过了，如果上来 已排序区域最右边（最大值）元素就比bas大，则这个最大值直接就被 后移 到i （即j+1）上，而本来的nums[i]有bas接着无需担心，最后把bas插入合适位置就行。且i索引也相当于排序完成，成了已排序区域的一部分，没问题。
            j--;
        }
        nums[j+1] = bas; 
    }
}
*/
