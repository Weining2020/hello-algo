
//1.初始化。
//List<int> nums = new List<int>() { 1, 3, 2, 5, 4 };

//int[] intArray = [1, 3, 2, 5, 4];
//List<int> myList = [.. intArray];   //.. 表示取数组 numbers 的所有元素。这是将整个数组 numbers 的元素复制到新创建的列表 nums 中。

//2.访问元素。
//没什么好联系的。

//3.插入和删除元素。
//List<int> nums = new List<int>() { 1, 3, 2, 5, 4 };
//nums.Clear();
//nums.Add(1);
//nums.Add(2);
//nums.Add(2);
//nums.Add(5);
//nums.Add(4);
//nums.Insert(3, 6);
//nums.RemoveAt(3);

//4.遍历列表。
//List<int> nums = new List<int>() { 1, 3, 2, 5, 4 };
//void Traverse(List<int> nums)
//{
//    int count = 0;
//    for (global::System.Int32 i = 0; i < nums.Count; i++)
//    {
//        count += nums[i];
//    }
//    foreach (var i in nums)
//    {
//        count += i;
//    }
//}

//5.拼接列表。
//List<int> nums = new List<int>() { 1, 3, 2, 5, 4 };
//List<int> anotherNums = new List<int>() { 6, 8, 7, 10, 9 };
//nums.AddRange(anotherNums);

//6.排序列表。
//List<int> nums = new List<int>() { 1, 3, 2, 5, 4 };
//nums.Sort();