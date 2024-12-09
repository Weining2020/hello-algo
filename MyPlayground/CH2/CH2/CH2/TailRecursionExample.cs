/*
//我自己写的TailRecursion。注意！！这里有我对TailRecursion写法的思路总结。
int myResult = TailRecursion(10, 0);
Console.WriteLine(myResult);    //55
int TailRecursion(int n, int res)   //这里教程上的第二个参数是res。我在想，在真正调用TailRecursion函数时，res的值很好确定，就用边界值0试试就行，因为0的和是0，显然在真正调用TailRecursion函数时给res一个值为0。我甚至觉得可以在函数声明时直接把res默认值设置成0，即括号内第二个参数int res = 0。
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