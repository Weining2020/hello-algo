/*
int[] TwoSumHashTable(int[] nums, int target) //和教程不完全一样，但是也正确。
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    foreach (var num in nums)
    {
        if (!dict.ContainsKey(target - num))
        {
            dict.Add(target - num, num);
        }
        else
        {
            return new int[2] {num, dict[target - num]};
        }
    }
    return Array.Empty<int>();
}
*/