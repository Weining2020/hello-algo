/*
和教程不完全一样，但是逻辑是一样的！！
void Backtract(List<int> state, int target, int[] choices, int start, List<List<int>> res)
{
    if (target == 0)
    {
        res.Add(new List<int>(state));
        return;
    }


    for (global::System.Int32 i = start; i < choices.Length; i++)
    {
        

        int choice = choices[i];
        
        if (target - choice < 0)
        {
            break;
        }

        state.Add(choice);
        Backtract(state, target - choice, choices, i, res);

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