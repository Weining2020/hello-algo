/*

// 指数阶（循环实现） ，注意！！我自己添加注释。
int Exponential(int n)  //n表示 用户需要的分裂轮数。
{
    int count = 0;  //表示总共的分裂 操作次数。
    int bas = 1;    //表示此时存在的细胞数量。
    for (global::System.Int32 i = 0; i < n; i++)
    {
        for (global::System.Int32 j = 0; j < bas; j++)
        {
            count++;    //每个已存在的细胞，都进行一次分裂操作。这里是分裂操作次数+1。
        }   
        bas *= 2;   //在内循环（已存在的细胞 的分裂操作）结束后，已存在的细胞数量 应该 翻倍，因为每个已存在的细胞 都分裂成了两个细胞。
    }   
    return count;
    //当i=0时，bas=1;当i=1时，bas=2;...当i=n时，bas = 2^(n-1)。当bas = 2^(n-1)时，内循环执行2^(n-1)次；...当bas = 2时，内循环执行2次；当bas = 1时，内循环执行1次；因此内循环共执行1+2+4+...+2^(n-1)次。即count = 1+2+4+...+2^(n-1)，此为2^n指数阶。
}

//注意！！上面这个方法也可以修改成递归法。
int ExponentialRecursiveFormula(int n, int bas = 1) //时间复杂度是O(n)。函数 ExponentialRecursiveFormula(int n, int bas = 1) 在每次调用中，只会进行一次递归调用并将 n 减 1。也就是说，从初始的 n 直到 n = 0，会进行 n 次调用。没有额外的嵌套循环或多重递归分支，因此调用次数随 n 线性增长。在每次调用中，所做的工作（加法、乘法操作）都是常量时间操作，与 n 无关。综合起来，每次递归调用都是 O(1) 的操作，总共调用 n 次，因此总的时间复杂度为 O(n)。
{
    if (n == 0) //当n=0,没有需要分裂的轮数了。此时再需要进行的分裂操作次数为0。
    {
        return 0;
    }
    else
    {
        return bas + ExponentialRecursiveFormula(n - 1, bas * 2);
    }
}
*/