/*
void Backtrack(List<int> choices, int state, int n, List<int> res)
{
    if (state == n)
    {
        res[0]++;
        return;
    }

    foreach (int choice in choices)
    {
        //剪枝。
        if (state + choice > n)
        {
            continue;
        }
        Backtrack(choices, state + choice, n, res);

        
    }
}

int ClimbingStairsBacktrack(int n)
{
    List<int> choices = new List<int>() { 1, 2 }; //这是读题目读来的已知条件，所以才有了这行代码。
    int state = 0;
    List<int> res = new List<int>() { 0 };
    Backtrack(choices, state, n, res);
    return res[0];
}
*/