int MaxProductCutting(int n)
{
    //n = 3*a +b
    if (n <= 3)
    {
        return 1 * (n - 1);
    }

    int a = n / 3;
    int b = n % 3;

    double res = 0;
    if (b == 0)
    {
        res = Math.Pow(3, a);
    }
    else if (b == 1)
    {
        a--;
        res = Math.Pow(3, a) * 2 * 2;
    }
    else if (b == 2)
    {
        res = Math.Pow(3, a) * 2;
    }

    return (int)res;
}