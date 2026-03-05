/*
// 20260303
// 问题：求1~n的和。
using System.Text;

int n = 10;
int resultOfForIterationMethod = ForIterationMethod(10);
int resultOfWhileIterationMethod = WhileIterationMethod(10);
int resultOfRecursion = Recursion(10);
int resultOfTailRecursion = TailRecursion(10, 0);
Console.WriteLine($"resultOfForIterationMethod is {resultOfForIterationMethod}");
Console.WriteLine($"resultOfWhileIterationMethod is {resultOfWhileIterationMethod}");
Console.WriteLine($"resultOfRecursion is {resultOfRecursion}");
Console.WriteLine($"resultOfTailRecursion is {resultOfTailRecursion}");

// 法一，迭代/循环（iteration）
int ForIterationMethod(int n)
{
    int res = 0;
    for(int i = 1; i <= n; i++)
    {
        res += i;
    }
    return res;
}
// 法二，迭代/循环（iteration）
int WhileIterationMethod(int n)
{
    int i = 1;
    int res = 0;
    while(i <= n)
    {
        res += i;
        i++;
    }
    return res;
}
// 法三，普通递归(Recursion)
int Recursion(int n)
{
    if (n == 1)
    {
        return 1;
    }
    int resultSoFar = Recursion(n - 1);
    return n + resultSoFar;
}

// 法四，尾递归（TailRecursion）
int TailRecursion(int n, int resultSoFar)
{
    if (n == 0) return resultSoFar;
    return TailRecursion(n - 1, resultSoFar + n);
}

// Fib array
int Fib(int n)
{
    if (n == 1) return 0;
    if (n == 2) return 1;
    return Fib(n - 1) + Fib(n - 2);
}

// 借助“栈”这个数据结构，用 循环代码 来模拟递归。
int ForLoopRecur(int n)
{
    Stack<int> stack = new Stack<int>();

    // 1.用For loop来模拟“递”这个过程，即入栈。
    for(int i = n; i > 0; i--)
    {
        stack.Push(i);
    }

    int res = 0;

    // 2.用while loop来模拟“归”这个过程，即出栈。
    while(stack.Count > 0)
    {
        int number = stack.Pop();
        res += number;
    }

    return res;
}
*/