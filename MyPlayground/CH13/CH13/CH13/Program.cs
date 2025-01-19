void Backtrack(List<List<string>> state, int row, int n, bool[] cols, bool[] diags1, bool[] diags2,List<List<List<string>>> res)
{
    if (row == n)
    {
        List<List<string>> copyState = new List<List<string>>();
        for (global::System.Int32 i = 0; i <= row; i++)
        {
            copyState.Add(new List<string>(state[i]));
        }
        res.Add(copyState);
        return;
    }

    for (global::System.Int32 col = 0; col < n; col++)
    {
        int diag1 = row - col + n - 1;
        int diag2 = row + col;
        if (!cols[col] && !diags1[diag1] && !diags2[diag2])
        {
            cols[col] = true;
            diags1[diag1] = true;
            diags2[diag2] = true;
            state[row][col] = "Q";

            Backtrack(state, row + 1, n, cols, diags1, diags2, res);

            cols[col] = false;
            diags1[diag1] = false;
            diags2[diag2] = false;
            state[row][col] = "#";
        }
    }


}
List<List<List<string>>> NQueens(int n)
{
    List<List<List<string>>> res = new List<List<List<string>>>();
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
    Backtrack(state, 0, n, new bool[n], new bool[2 * n - 1], new bool[2 * n - 1], res);
    return res;
}