int[] HashSearch(int[] nums, int target)
{
    int n = nums.Length;
    Dictionary<int, int> dic = new Dictionary<int, int>();
    for (global::System.Int32 i = 0; i < n; i++)
    {
        if (dic.ContainsKey(target - nums[i]))
        {
            return new int[2] { dic[target - nums[i]], i };
        }
        dic.Add(target - nums[i], i);
    }

    return null;
}