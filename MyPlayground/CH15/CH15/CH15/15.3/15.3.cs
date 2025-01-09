/*
//最大容量：贪心。
int MaxCapacity(int[] ht)
{
    if (ht == null || ht.Length == 0)
    {
        return 0;
    }

    int i = 0;
    int j = ht.Length - 1;
    int res = 0;
    while (i < j)
    {
        int cap = 0;
        if (ht[i] < ht[j])
        {
            cap = ht[i] * (j - i);
            i++;
        }
        else
        {
            cap = ht[j] * (j - i);
            j--;
        }
        res = cap > res ? cap : res;
    }

    return res;
}
*/