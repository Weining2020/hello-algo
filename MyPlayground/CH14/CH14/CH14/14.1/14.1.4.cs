/*
int ClimbingStairsDP(int n)
{
    if (n == 1 || n == 2)
    {
        return n;
    }
    int a = 1;  //这里声明a和b代表1阶和2阶的结果，只是方便用于后面计算i阶的结果。
    int b = 2;
    for (global::System.Int32 i = 3; i < n + 1; i++)
    {
        int tmp = b;    //之所以是b,是因为 i阶和i-1阶的计算公式中都借助到i-2阶的结果，而不是i-1。即3阶和4阶的计算都需要2阶的结果，而2阶的结果是b。
        b = a + b;  //这一步设计，就决定了是return b。
        a = tmp; //之所以要把a的值也更新，是因为a作为全局变量，在for的下一次循环还得用最新值参与计算呢。
    }
    return b;
}
*/