/*
//和教程不完全一样，但是逻辑是一样的！！
void Backtract(List<int> state, int target, int[] choices, int start, List<List<int>> res)
{
    if (target == 0)
    {
        res.Add(new List<int>(state));
        return;
    }


    for (global::System.Int32 i = start; i < choices.Length; i++)
    {
        if (i > start && choices[i] == choices[i - 1]) //这里做到了 若当前元素与其左边元素相等则直接跳过当前元素，即做到了 我们需要限制相等元素在每一轮中只能被选择一次。这里的剪枝四，是针对于每一轮内的选择，因此i>start这个条件足够了，因为在本轮i就是从start开始一个一个被循环到的。如果是i>0反而错了，b/c i==start时不改进行判断，若此时判断则是把本轮和start-1这一绝不可能出现在本轮的选项 进行比较了，错误的。
        {
            continue;
        }


        int choice = choices[i];

        if (target - choice < 0)
        {
            break;
        }

        state.Add(choice);
        Backtract(state, target - choice, choices, i + 1, res); //这里做到了 设定下一轮从索引 i+1 开始向后遍历，即做到了 本题规定每个数组元素只能被选择一次。

        state.RemoveAt(state.Count - 1);
    }
}
List<List<int>> Permutations(int[] nums, int target)
{
    List<List<int>> res = new List<List<int>>();
    Array.Sort(nums);
    int start = 0;
    Backtract(new List<int>(), target, nums, start, res);
    return res;
}
*/