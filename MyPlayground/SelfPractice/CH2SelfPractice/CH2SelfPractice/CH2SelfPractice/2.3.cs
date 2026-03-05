/*
// 20260304
// 指数阶。
int Exp(int n)
{
    int bas = 1;    // bas代表当前细胞总数。起始细胞数量为1
    int count = 0;  // count代表累计细胞总数。这不是最终完成全部分裂后的 细胞的数量，而是总计出现过多少个细胞。
    // 如果问“完成全部分裂后最后一天活着几个细胞”，答案是 bas（即 2^(n-1) 个）。但这段代码返回的是 count（总计出现过的细胞数，即 2^n - 1 个）。
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < bas; j++)
        {
            count++;
        }

        bas *= 2;

    }

    return count;
}

// Exp被改写为递归优化后变为线性阶。
int ExponentialRecursiveFormula(int n, int bas)
{
    if (n == 0)
    {
        return 0;
    }
    return bas + ExponentialRecursiveFormula(n - 1, bas * 2);
}