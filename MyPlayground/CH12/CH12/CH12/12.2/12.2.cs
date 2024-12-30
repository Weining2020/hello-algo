/*
int DFS(int[] nums, int target, int i, int j)
{
    if (i > j)
    {
        return -1;
    }


    int m = i + (j - i) / 2;
    if (nums[m] < target)
    {
        return DFS(nums, target, m + 1, j); //每次调用 DFS 方法时，它期望一个返回值（int 类型）。如果不写 return，递归调用的结果不会被传递回上一层，最终返回给主调用函数的结果将是默认值（通常是 0 或 -1，取决于你的初始化）。每一层递归调用都会依赖下一层递归的返回值。例如：如果 nums[m] < target，我们需要从 DFS(nums, target, m + 1, j) 中得到结果，并返回给上一层。没有 return，当前层递归的结果就会丢失。
    }
    else if (nums[m] > target)
    {
        return DFS(nums, target, i, m - 1);
    }
    else
    {
        return m;
    }

}
int BinarySearchDFS(int[] nums, int target)
{
    int n = nums.Length - 1;
    return DFS(nums, target, 0, n);
}
*/