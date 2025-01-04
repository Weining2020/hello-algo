/*
void Backtrack(int row, int n, List<List<string>> state, bool[] cols, bool[] diags1, bool[] diags2, List<List<List<string>>> res)
{
    if (row == n) //row一共只有n-1个，如果越界了，则是全部row都遍历完了，那么这就是一个解，记录下来。
    {
        List<List<string>> copyState = new List<List<string>>(); //这整个深拷贝可以由LINQ改写一行代码实现，res.Add(state.Select(row => new List<string>(row)).ToList());。
        foreach (List<string> sRow in state)
        {
            copyState.Add(new List<string>(sRow));
        }
        res.Add(copyState);
        res.Add(state.Select(row => new List<string>(row)).ToList());
        return;
        
    }

    for (global::System.Int32 col = 0; col < n; col++)
    {
        int diag1 = row - col + n - 1; //这个计算是基于，我们是根据什么设立diags1和diags2两个bool[]的。对于主对角线，我们是根据row - col ∈ [1-n, n-1]设立的 具体每个主对角线在bool[]里的索引，即每个主对角线在diags1的索引值为此时元素索引为(row - col)值，而在这条主对角线的所有元素都有这个共同值。主对角线还比较特殊，主对角线的 row - col 范围是 [-n + 1, n - 1]，为了便于使用数组，我们需要将负值转换为非负值作为数组索引。因此，加上偏移量 n - 1，主对角线的数组索引为row-col+n-1。
        int diag2 = row + col;//同理，副对角线的所有元素都有row+col这个共同值。而n*n棋盘的 row + col 范围是 [0, 2n - 2]，最小值为0不需要加偏移量，因此副对角线的数组索引为row + col。
        if (!cols[col] && !diags1[diag1] && !diags2[diag2])
        {
            state[row][col] = "Q";
            cols[col] = true; //这里就是把三者都设置成true，因为这个位置被选择放了皇后。
            diags1[diag1] = true;
            diags2[diag2] = true;
            Backtrack(row + 1, n, state, cols, diags1, diags2, res);

            state[row][col] = "#";
            cols[col] = false; //这里就是把三者都设置成false，因为这个位置需要回退到原本初始状态。
            diags1[diag1] = false;
            diags2[diag2] = false;
        }

    }
}
{

}
List<List<List<string>>> NQueens(int n)
{

    //初始化棋盘。
    List<List<string>> state = new List<List<string>>();
    for (global::System.Int32 i = 0; i < n; i++)
    {
        List<string> row = new List<string>();
        for (global::System.Int32 j = 0; j < n; j++)
        {
            row.Add("#");
        }
        state.Add(row);
    }
    bool[] cols = new bool[n];
    //主对角线。[1-n, n-1]。
    //次对角线。[0, 2n-2]。
    bool[] diags1 = new bool[2 * n - 1];
    bool[] diags2 = new bool[2 * n - 1];

    List<List<List<string>>> res = new List<List<List<string>>>();

    Backtrack(0, n, state, cols, diags1, diags2, res);
    return res;
}
*/