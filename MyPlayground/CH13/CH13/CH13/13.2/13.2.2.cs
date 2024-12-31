/*
void Backtrack(List<int> state, int[] choices, bool[] selected, List<List<int>> res)
{
    if (state.Count == choices.Length)
    {
        res.Add(new List<int>(state));
        return;
    }

    HashSet<int> duplicated = new HashSet<int>();
    for (global::System.Int32 i = 0; i < choices.Length; i++)
    {
        int choice = choices[i];

        if (!selected[i] && !duplicated.Contains(choice))
        {
            state.Add(choice);
            selected[i] = true;
            duplicated.Add(choice);
            Backtrack(state, choices, selected, res);

            //从下一层返回来这一层之后接着执行这一层这一个i的循环还没执行完的代码。
            selected[i] = false;
            state.RemoveAt(state.Count - 1);
            //本层的for循环内并不会有把 元素 从duplicated中拿出来的代码。因为我们需要duplicated记录好本层for循环到底进行过哪些元素值的循环，好在结束一次该元素值的for循环后，不会在for循环的下一次再次碰到该元素值时还选择该元素，碰到那种情况我们应该避免重复选择该元素值。e.g. 对于nums=[1,1,2], 第一层的i=0会选择到[1,1]并进行完到底层的递归了，现在回到这里该进行第一层的i=1了，还是1，这会被duplicated检查避免，从而不会再次出现state第一个元素值是1的情况了。
        }
    }
}
List<int> Permutations(int[] nums)
{
    List<List<int>> res = new List<List<int>>();
    Backtrack(new List<int>(), nums, new bool[nums.Length], res);
    return res;
}
*/