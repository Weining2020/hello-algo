/* 
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
*/