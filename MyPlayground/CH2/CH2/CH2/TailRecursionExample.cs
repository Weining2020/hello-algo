/*
//我自己写的TailRecursion。注意！！这里有我对TailRecursion写法的思路总结。
int myResult = TailRecursion(10, 0);
Console.WriteLine(myResult);    //55
int TailRecursion(int n, int res)   //这里教程上的第二个参数是res。我在想，在真正调用TailRecursion函数时，res的值很好确定，就用边界值0试试就行，因为0的和是0，显然在真正调用TailRecursion函数时给res一个值为0。我甚至觉得可以在函数声明时直接把res默认值设置成0，即括号内第二个参数int res = 0。
// 设置res这个参数的目的是，这个 res 的全称是 Result（或者 Accumulator，累加器），它就像是一个接力棒 。在把棒子交给下一个方法之前，它已经把加法做完了！它把结果装进接力棒 res 中，传给了下一个人。e.g. n为3，当 TailRecur(3, 0) 把接力棒交给 TailRecur(2, 3) 时，TailRecur(3, 0) 的历史使命就已经彻底结束了，因为它后面没有多余的加法操作需要执行。这就像是一个员工把所有工作都做完后，把文件交接给下一位同事，自己就可以立刻下班了，而不需要在办公室干等着下一位同事做完再走 。这就是为什么它叫**“尾”**递归——递归调用是整个方法执行的绝对最后一个操作，没有任何善后工作（比如 +n）留在当前方法中 。
{
    if (n == 0)
    {
        return res; //我理解的是，这里是return一个值，而不是函数调用。因此如果这里执行，那么递归就结束了。所以思路是：当执行执行到n=0时，我们显然已执行完 需求1+2+...+n了，那么就在这里结束递归就好，因为需求已执行完了。
    }
    else
    {
        return TailRecursion(n - 1, res + n);    //我理解的是，这里是return函数调用，因此递归还在进行。因为在这个else循环分支我们还没进行到n=0的步骤，因此我们希望递归继续进行，因此return函数调用。
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