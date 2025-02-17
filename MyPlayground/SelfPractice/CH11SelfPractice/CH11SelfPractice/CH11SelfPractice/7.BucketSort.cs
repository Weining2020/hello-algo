/*
//不是基于比较的，不是基于分治思想的。



void BucketSort(float[] nums)
{
    int n = nums.Length;
    int k = n / 2;  //桶的数量。
    List<List<float>> buckets = new List<List<float>>();
    for (global::System.Int32 i = 0; i < k; i++)
    {
        buckets.Add(new List<float>());
    }

    foreach (var num in nums)
    {
        int bucketNo = (int)(num * k);
        buckets[bucketNo].Add(num);
    }

    foreach (var bucket in buckets)
    {
        bucket.Sort();
    }

    int externalIndex = 0;
    foreach (var bucket in buckets)
    {
        foreach (var num in bucket)
        {
            nums[externalIndex] = num;
            externalIndex++;
        }
    }
}
*/