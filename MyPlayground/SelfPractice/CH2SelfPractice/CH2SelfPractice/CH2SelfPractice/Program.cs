// 1~n

int result = TailRecusive(10, 0);
Console.WriteLine(result);
int ForLoop(int n)
{
    int res = 0;
    for (int i = 0; i <= n; i++)
    {
        res += i;
    }
    return res;
}

int WhileLoop(int n)
{
    int res = 0;
    int i = 0;
    while (i <= n)
    {
        res += i;
        i++;
    }
    return res;
}

int CommenRecursive(int n)
{
    if (n == 1)
    {
        return n;
    }
    int result = n + CommenRecursive(n - 1);
    return result;
}

int TailRecusive(int n, int resultSoFar) 
{
    if (n == 0)
    {
        return resultSoFar;
    }
    int result = TailRecusive(n - 1, n + resultSoFar);
    return result;
}