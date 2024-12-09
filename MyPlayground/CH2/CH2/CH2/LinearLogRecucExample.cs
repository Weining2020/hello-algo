/*
//线性对数阶。注意！！很难写注释，实在看不懂就问chatGPT。我觉得教程上的图解还清晰些。
int LinearLogRecur(int n)
{
    if (n < 1) return 0;    //当n减半至1时，已经没得减半了，因此接下来要操作的次数为0。
    int count = LinearLogRecur(n / 2) + LinearLogRecur(n / 2);  //每次n减半分成的两个数，各自要进行的操作次数 之和。这里分出来的两个调用，每个调用中还会执行下面的for loop操作。
    for (global::System.Int32 i = 0; i < n; i++)    //好难解释。这个for loop是对于每个n分出来的数，分别要进行的for loop操作。
    {
        count++;
    }
    return count;
}
*/