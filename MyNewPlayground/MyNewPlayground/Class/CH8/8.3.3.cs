using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH8
{
    internal class _833
    {/*
PriorityQueue<int, int> TopKHeap(int[] nums, int k)
{
    PriorityQueue<int, int> minHeap = new();    //对于“基于堆查找数组中最大的 k 个元素”问题，借助的是小顶堆。核心在于小顶堆的堆顶正好是堆内最小值，充当"门槛守卫"的角色，堆顶始终是堆内 k 个元素里最小的那个。每遇到一个新元素，只问一个问题："这个新元素比当前堆里最小的（堆顶）还大吗？"是 → 说明这个新元素有资格进入 top k，踢掉当前最小的（Dequeue），把新元素加进来（Enqueue）；否 → 这个新元素连堆里最小的都比不过，肯定进不了 top k，直接跳过。
    for (int i = 0; i < k; i++)
    {
        minHeap.Enqueue(nums[i], nums[i]);
    }

    for (int i = k; i < nums.Length; i++)
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
    }
}
