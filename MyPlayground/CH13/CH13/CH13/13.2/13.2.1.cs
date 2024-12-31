/*
using hello_algo.utils;

void Backtrack(List<int> state, int[] choices, bool[] selected, List<List<int>> res)
{
    if(state.Count == choices.Length)
    {
        res.Add(new List<int>(state));
        return;
    }

    for (global::System.Int32 i = 0; i < choices.Length; i++)
    {
        int choice = choices[i];
        if (!selected[i])
        {
            state.Add(choice);
            selected[i] = true;
            Backtrack(state, choices, selected, res);

            selected[i] = false;
            state.RemoveAt(state.Count - 1);
        }
    }
}
List<List<int>> Permutations(int[] nums)
{
    List<List<int>> res = new List<List<int>>();
    Backtrack(new List<int>(), nums, new bool[nums.Length], res);
    return res;
}
*/