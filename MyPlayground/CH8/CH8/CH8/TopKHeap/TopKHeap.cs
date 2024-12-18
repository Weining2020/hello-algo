/*
PriorityQueue<int, int> TopKHeap(int[] nums, int k) //说实话这个算法真挺直白的。
{
    PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
    for (global::System.Int32 i = 0; i < k; i++) //先把前k个元素入堆，到此形成了一个小顶堆。
    {
        minHeap.Enqueue( nums[i], nums[i] );
    }
    for (global::System.Int32 i = k; i < nums.Length; i++) //如果下一个元素（从k+1元素起,inclusive），大于小顶堆的顶，则小顶堆应该出堆，这个元素应该入堆。直到遍历完nums,我们就得到了一个小顶堆，满足小顶堆的元素是 nums里前k个大的元素。
    {
        if (nums[i] > minHeap.Peek())
        {
            minHeap.Dequeue();
            minHeap.Enqueue(nums[i], nums[i]);
        }
    }
    return minHeap;
}
*/