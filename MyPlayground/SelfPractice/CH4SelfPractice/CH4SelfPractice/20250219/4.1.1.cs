/*

//1.初始化Array。
int[] myArray = new int[2];
int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };

//2.随机访问元素。
int RandomAccess(int[] nums)
{
    Random random = new Random();
    return nums[random.Next(nums.Length)];
}

//3.增加元素。
void Insert(int[] nums, int index, int num)
{
    for (global::System.Int32 i = nums.Length - 1; i > index; i--)
    {
        nums[i] = nums[i - 1];
    }
    nums[index] = num;
}

//4.删除元素。
void Remove(int[] nums, int index)
{
    for (global::System.Int32 i = index; i < nums.Length - 1; i++)
    {
        nums[i] = nums[i + 1];
    }

}

//5.Traverse。
void Traverse(int[] nums)
{
    for (global::System.Int32 i = 0; i < nums.Length; i++)
    {
        nums[i] = nums[i];
    }
}

//6.查找。
int Find(int[] nums, int target)
{
    for (global::System.Int32 i = 0; i < nums.Length; i++)
    {
        if (nums[i] == target)
        {
            return i;
        }
    }
    return -1;
}

//7.扩容。
int[] Extend(int[] nums, int enlarge)
{
    int[] tmp = new int[nums.Length + enlarge];
    for (global::System.Int32 i = 0; i < nums.Length; i++)
    {
        tmp[i] = nums[i];
    }
    return tmp;
}

*/