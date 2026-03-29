using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.SelfPractice.CH2
{
    internal class _23
    {
/*
//我认为一共有:O(1) < O(log n) < O(n) < O(n log n) < O(n^2) < O(2^n) < O(n!)

//1.常数阶。常数阶没有提到通常出现在哪里。
void ForLoop(int n)
{
    for (int i = 0; i < 99; i++)
    {
        Console.WriteLine(i);
    }
}

//2.对数阶。常出现于递归函数。
// Question: 给定一个正整数 n，请问它需要被 2 连续整除多少次，才能变成 1 或者更小？
// 用递推来优化了Logarithmic写法。
int LogRecur(int n)
{
    // 终止条件：n 已经不能再被有意义地砍了
    if (n <= 1)
    {
        return 0;
    }

    // 递推：当前砍一刀（+1），剩下的交给子问题（n/2）
    return 1 + LogRecur(n / 2);
}

//3.线性阶。常出现于单层iteration。
void ForLoop2(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(i);
    }
}

//4.线性对数阶。常出现于嵌套循环。
//不解决实际问题，提供一个代码例子来展示线性对数阶。
int LinearLogRecur(int n) // LinearLogRecur(n) 统计的是 count++ 总共被执行了多少次。
{
    if (n < 1) //C# 整数除法会向下取整，导致 n 不一定能精确地落在 1 上，有可能直接跳过 1 变成 0。n = 1 时：1 / 2 = 0   （直接变成 0，跳过了 1！）.
    {
        return 0;   // 当 n < 1（即 n = 0）时：for 循环的条件是 i < n，即 i < 0，一次都不会执行。两个递归子调用也不会产生任何 count++。所以这一层贡献的操作次数是 0，返回 0 完全正确。
    }
    int count = LinearLogRecur(n / 2) + LinearLogRecur(n / 2);
    for (int i = 0; i < n; i++)
    {
        count++;
    }
    return count;
}

//5.平方阶。常出现于嵌套循环。
int BubbleSort(int[] nums)
{
    int count = 0;
    //[0, i]
    for (int i = nums.Length - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (nums[j] > nums[j + 1])
            {
                (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                count+=3;
            }
        }
    }
    return count;
}

//6.指数阶。常出现于递归。
int Exp(int n)  // 这不是递归写法！递归写法在后面！
{
    int count = 0;
    int bas = 1;
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


int ExpRec(int n)
{
    if (n == 1)
    {
        return 1;
    }
    return ExpRec(n - 1) + ExpRec(n - 1) + 1;
}

//这个Exp指数阶也可以优化成
int ExponentialRecursiveFormula(int n, int bas)
{
    if (n == 0)
    {
        return 0;
    }
    return bas + ExponentialRecursiveFormula(n - 1, bas * 2);
}

// 7.阶乘阶。常出现于递归。
// Question: 计算 n 个不同元素的全排列数量。
// 循环写法。
int Factorial(int n)
{
    int count = 1;
    for (int i = n; i > 0; i--)
    {
        count *= i;
    }
    return count;
}
// 递归写法。
int FactorialRecur(int n)
{
    if (n == 0)
    {
        return 1;
    }
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        count += FactorialRecur(n - 1); // 我们是观察 “count+=” 被调用多少次，而判断出这是阶乘阶的时间复杂度。可以用FactorialRecur(3)来举个例子帮助理解。
    }
    return count;   
}
*/
    }
}
