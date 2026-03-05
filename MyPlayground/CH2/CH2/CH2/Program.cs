
//阶乘阶（递归实现） 。注意！！我写了注释理解。
int FactorialRecur(int n)
{
    if (n == 0) return 0;
    int count = 0;
    for (global::System.Int32 i = 0; i < n; i++)
    {
        count += FactorialRecur(n - 1);
    }   //这整个for循环，可以想象成对于每个n，要执行n遍for循环，即操作 T(n) = n*T(n-1)。因此，借助T(0)=1和数学归纳法可以推导出T(n)=n!。不会推导可以问chatGPT。当 n = 1 时，只调用一次 FactorialRecur(0)。当 n = 2 时，会调用2次 FactorialRecur(1)，而每个 FactorialRecur(1) 又调用1次 FactorialRecur(0)。当 n = 3 时，会先有1个根节点调用 FactorialRecur(3)，它分裂出3个 FactorialRecur(2)，而每个 FactorialRecur(2) 又分裂出2个 FactorialRecur(1)，每个 FactorialRecur(1) 再分裂出1个 FactorialRecur(0)。
    return count;
}

//我自己尝试实现书中的简单递归：求1~n的和（不涉及负数）。我认为这个方法启发了我关于“如何完成递归method的写法”。
int SumUntil(int n)
{
    if (n == 1) // 3.我最后想到了需要终止条件，我想到了n为1的情况就是终止条件，b/c题目要求是1~n。
    {
        return 1;
    }

    int res = SumUntil(n - 1);  // 2.我其次想到了“到我之前的和”的值刚好用这个算法就能表示，即MethodXXX(n - 1)。

    return n + res; // 1.我首先想到了返回值应该是“我 + 到我之前的和”，这个“到我之前的和”用res变量表示。
}
