//最大切分乘积：贪心。
int MaxProductCutting(int n)
{
    if (n <= 3)
    {
        return 1 * (n - 1);
    }
    int b = n / 3;
    int a = n % 3;
    if (a == 0)
    {
        int res = 1;
        for (global::System.Int32 i = 0; i < b; i++)
        {
            res *= 3;
        }
        return res;
    }
    else if (a == 1)
    {
        b--;
        int res = 1;
        for (global::System.Int32 i = 0; i < b; i++)
        {
            res *= 3;
        }
        return res * 2 * 2;
    }
    else
    {
        int res = 1;
        for (global::System.Int32 i = 0; i < b; i++)
        {
            res *= 3;
        }
        return res * 2;
    }
}