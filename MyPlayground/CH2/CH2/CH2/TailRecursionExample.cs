/*
//我自己写的TailRecursion。注意！！这里有我对TailRecursion写法的思路总结。
int myResult = TailRecursion(10, 0);
Console.WriteLine(myResult);    //55
int TailRecursion(int n, int res)
// 设置res这个参数的目的是，这个 res 的全称是 Result（或者 Accumulator，累加器），它就像是一个接力棒 。在把棒子交给下一个方法之前，它已经把加法做完了！它把结果装进接力棒 res 中，传给了下一个人。e.g. n为3，当 TailRecur(3, 0) 把接力棒交给 TailRecur(2, 3) 时，TailRecur(3, 0) 的历史使命就已经彻底结束了，因为它后面没有多余的加法操作需要执行。这就像是一个员工把所有工作都做完后，把文件交接给下一位同事，自己就可以立刻下班了，而不需要在办公室干等着下一位同事做完再走 。这就是为什么它叫**“尾”**递归——递归调用是整个方法执行的绝对最后一个操作，没有任何善后工作（比如 +n）留在当前方法中 。
{
    if (n == 0)
    {
        return res;
    }
    else
    {
        return TailRecursion(n - 1, res + n);
    }
}
*/
int n = 4;
Console.WriteLine(n);
int TailRecur(int n, int resultSoFar)
{
    if (n == 0)
    {
        return 0 + resultSoFar;
    }
    return TailRecur(n - 1, n + resultSoFar);
}