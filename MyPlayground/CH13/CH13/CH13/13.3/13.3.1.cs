/*
void Backtract(List<int> state, int target, int total, int[] choices, List<List<int>> res)
{
    if (total == target)
    {
        res.Add(new List<int>(state));
        return;
    }

    for (global::System.Int32 i = 0; i < choices.Length; i++)
    {
        if (total + choices[i] > target)
        {
            continue;
        }

        int choice = choices[i];
        state.Add(choice);
        total += choice;
        Backtract(state, target, total, choices, res);

        state.RemoveAt(state.Count - 1);
    }
}
List<List<int>> Permutations(int[] nums, int target)
{
    List<List<int>> res = new List<List<int>>();
    int total = 0;
    Backtract(new List<int>(), target, total, nums, res);
    return res;
}
*/