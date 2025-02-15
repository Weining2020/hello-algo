using System;

class QuickSortOptimized
{
    /* 交换元素 */
    static void Swap(int[] nums, int i, int j)
    {
        (nums[i], nums[j]) = (nums[j], nums[i]);
    }

    /* 三数取中法（Median-of-Three）选择基准索引 */
    static int MedianThree(int[] nums, int left, int right)
    {
        int mid = left + (right - left) / 2;
        int a = nums[left], b = nums[mid], c = nums[right];

        if ((a <= b && b <= c) || (a >= b && b >= c))
            return mid;   // b 是中位数
        if ((b <= a && a <= c) || (b >= a && a >= c))
            return left;  // a 是中位数
        return right;     // c 是中位数
    }

    /* 哨兵划分（Hoare Partition） */
    static int Partition(int[] nums, int left, int right)
    {
        // 选择基准数索引（使用三数取中法）
        int pivotIndex = MedianThree(nums, left, right);
        Swap(nums, left, pivotIndex); // 交换基准数到最左侧
        int pivot = nums[left];

        int i = left, j = right;
        while (i < j)
        {
            while (i < j && nums[j] >= pivot) j--;  // 从右向左找第一个 < pivot 的数
            while (i < j && nums[i] <= pivot) i++;  // 从左向右找第一个 > pivot 的数
            if (i < j) Swap(nums, i, j);
        }
        Swap(nums, left, i);  // 交换基准数到最终位置
        return i;  // 返回基准数最终位置
    }

    /* 尾递归优化的 QuickSort */
    static void QuickSort(int[] nums, int left, int right)
    {
        while (left < right)  // 使用循环代替递归
        {
            int pivotIndex = Partition(nums, left, right);

            // 优先递归较小的部分，循环处理较大的部分，减少递归深度
            if (pivotIndex - left < right - pivotIndex)
            {
                QuickSort(nums, left, pivotIndex - 1);
                left = pivotIndex + 1;  // 右侧用循环替代递归
            }
            else
            {
                QuickSort(nums, pivotIndex + 1, right);
                right = pivotIndex - 1;  // 左侧用循环替代递归
            }
        }
    }

    /* 测试 QuickSort */
    static void Main()
    {
        int[] nums = { 9, 3, 7, 5, 6, 2, 8, 1, 4 };
        QuickSort(nums, 0, nums.Length - 1);
        Console.WriteLine("排序后数组: " + string.Join(", ", nums));
    }
}
