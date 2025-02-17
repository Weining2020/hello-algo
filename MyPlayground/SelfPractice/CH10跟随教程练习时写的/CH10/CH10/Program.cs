using CH10;

//int[] nums = { 1, 3, 6, 6, 6, 6, 6, 10, 12, 15 };

Solution sol = new Solution();
foreach (int target in new int[] { 2, 6, 20 })
{
    int index = sol.FindRightBoundary(new int[] { 1, 3, 6, 6, 6, 6, 6, 10, 12, 15 }, target);
    Console.WriteLine("元素 " + target + " 的插入点的索引为 " + index);
}


