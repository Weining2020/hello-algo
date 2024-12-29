/*
void BucketSort(float[] nums)
{
    int k = nums.Length / 2; //k个桶
    List<List<float>> buckets = new List<List<float>>();
    for (global::System.Int32 i = 0; i < k; i++)
    {
        buckets.Add(new List<float>());
    }
    foreach (float num in nums)
    {
        int i = (int)(num * k);
        buckets[i].Add(num);
    }
    foreach (List<float> bucket in buckets)
    {
        bucket.Sort();
    }
    int j = 0;
    foreach (List<float> bucket in buckets)
    {
        foreach (float num in bucket)
        {
            nums[j] = num;
            j++;
        }
    }
}
*/