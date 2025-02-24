//1.初始化列表。
List<int> nums1 = new List<int>() { 1, 2, 3, 4, 5 };
//好像有第二种方式。忘了。

//2.访问元素+给元素赋值。
int Access(List<int> nums, int index)
{
    return nums[index];
}

//3.添加/删除元素。
nums1.Clear();
nums1.Add(1);
nums1.Add(2);
nums1.Add(3);
nums1.Add(4);
nums1.Add(5);
nums1.Insert(3, 6);
nums1.Insert(4, 7);
nums1.RemoveAt(3);

//4.遍历数组。
int count1 = 0;
foreach (var num in nums1)
{
    count1++;
}
int count2 = 0;
for (int i = 0; i < nums1.Count; i++)
{
    count2++;
}

//5.拼接列表。
List<int> nums2 = new List<int>() { 5, 6, 7, 8, 9 };
nums1.AddRange(nums2);

//6.排序列表。
nums1.Sort();