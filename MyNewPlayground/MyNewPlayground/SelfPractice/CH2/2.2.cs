using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.SelfPractice.CH2
{
    internal class _2
    {
/*
         
//Question:求1~n的和。
int result = TailRecur(10, 0);
Console.WriteLine(result);
//法一，for法。
int ForLoop(int n)
{
    int res = 0;
    for (int i = 0; i <= n; i++)
    {
        res += i;
    }
    return res;
}
//法二，while法。
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
//法三，普通递归法。
int CommonRecur(int n)
{
    if (n == 0)
    {
        return 0;
    }
    return n + CommonRecur(n - 1);  // 含义是CommonRecur(n)应该等于 n + "1到n-1 的和" 之和。
}
// 法四：尾递归求 1 + 2 + ... + N 的总和
// 调用入口：TailRecur(N, 0)
//
// 参数说明：
//   n                          : 当前还需要处理的数字（从 N 逐步递减到 0）
//   resultSoFarExcludingMySelf : 在处理 n 之前，已经累加好的部分总和
//                                即 N + (N-1) + ... + (n+1) 的结果
//                                初始调用时传入 0（还没有任何数字被累加）
//
// 不变量：TailRecur(n, acc) 的返回值 = acc + (1 + 2 + ... + n)
//         无论递归深入到哪一层，这个等式始终成立。

int TailRecur(int n, int resultSoFarExcludingMySelf)
{
    // 终止条件：n 已降为 0，没有更多数字需要累加了。
    // 此时 resultSoFarExcludingMySelf 已经包含了 1 + 2 + ... + N 的完整结果，直接返回。
    if (n == 0)
    {
        return resultSoFarExcludingMySelf;
    }

    // 尾递归转移：
    // 1. 把当前数字 n 计入账本：新的累加器 = n + resultSoFarExcludingMySelf
    // 2. 问题规模缩小：下一步只需处理 1 + 2 + ... + (n-1)
    // 关键点：return 后面只有递归调用本身，没有任何额外运算，这是尾递归的标志。
    return TailRecur(n - 1, n + resultSoFarExcludingMySelf);
}

//Question: 给定一个斐波那契数列 0,1,1,2,3,5,18,…,求该数列的第 n个数字。
int result2 = Fib(7);
Console.WriteLine(result2);

//递归树法
int Fib(int n)
{
    if (n == 1 || n == 2)   // 注意！！n涉及到“该数列的第n个数组”，一个数列不存在第0个数字，因此n为1时引出数列的第一个数字为0；n为2时引出数列的第二个数字为1。
    {
        return n - 1; // 由“数列的第一个数字为0”和“数列的第二个数字为1”得出，需要return n - 1。这里确实需要转个弯才能想好。
    }
    return Fib(n - 1) + Fib(n - 2);
}
//////////////////////////
//Question：使用显式的栈来模拟调用栈的行为。这代码好像没解决什么实际问题，而只是借助Stack来展示了一下调用栈的“工作原理”。
int result3 = ForLoopStack(10);
Console.WriteLine(result3);
int ForLoopStack(int n)
{
    int res = 0;
    Stack<int> stack = new Stack<int>();
    for (int i = n; i > 0; i--)
    {
        stack.Push(i);
    }
    while (stack.Count > 0)
    {
        res += stack.Pop();
    }
    return res;
}
//////////////////////////
*/ 
    }
}
