//方法二：哈希查找。

int[] TwoSumHashTable(int[] nums, int target)
{
   Dictionary<int, int> myDict = new Dictionary<int, int>();
    for (global::System.Int32 i = 0; i < nums.Length; i++)
    {
        if (myDict.ContainsKey(target - nums[i]))
        {
            int theOtherIndex = myDict[target - nums[i]];
            return new int[] {i, theOtherIndex};
        }
        myDict.Add(nums[i], i);
    }
    return Array.Empty<int>();
}