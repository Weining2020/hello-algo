/*
Console.OutputEncoding = System.Text.Encoding.UTF8; // 设置控制台为 UTF-8，这样我的Console才能正常打印出汉字。

//基于数组实现的哈希表。

//键值对 int->string。先造一个Pair类以实现键值对。
public class Pair
{
    public int key;
    public string val;
    public Pair(int key, string value)
    {
        key = key;
        val = value;
    }
}
public class ArrayHashMap
{
    public List<Pair?> buckets; //是Pair的列表。列表中每一个元素都是Pair实例，每个Pair实例都是一对键值对，这是Pair类声明中规定的。

    //初始化哈希表。
    public ArrayHashMap()
    {
        //在初始化哈希表中，也需要初始化底层数组，本例中我们规定底层数组包含100个桶。我认为这里之所以说初始化数组，应该是List被认为是实现了动态数组Dynamic List。
        buckets = new List<Pair?>(new Pair?[100]); //因为初始化哈希表的桶时，每个桶一开始并没有存储任何键值对，因此每个桶的默认值是 null。如果 buckets 的类型是 List<Pair>，编译器会要求每个 List 的元素必须是一个有效的 Pair 实例，而不能是 null。为了允许 buckets 中的元素可以是 null，我们需要定义为 List<Pair?>。同理，new Pair?[100] 创建了一个包含 100 个元素的数组，其中每个元素默认值为 null。这个数组被用来初始化 List<Pair?> 的底层数据。
        //这里List列表的构造器接收一个IEnumerable<T> 来初始化列表实例。使用此构造函数时，会将传入的集合的元素拷贝到新的 List 实例中。new Pair?[100] 创建了一个长度为 100 的数组（Pair?[]），它实现了 IEnumerable<Pair?>。然后，这个数组被传递给 List<Pair?> 的构造函数。最终，List<Pair?> 的内容是数组中的所有元素。
    }
    //哈希函数。//HashFunc() 内部逻辑的具体实现是根据本例的要求设计的。在本例中，我们的哈希表包含 100 个桶，因此 HashFunc 是通过对 100 取模 (key % 100) 来将键映射到数组的索引范围 [0, 99]。但在实际中，HashFunc 的实现并不是固定为取模操作，也不一定是对 100 取模，它可以根据具体需求和数据结构的特点灵活设计。
    int HashFunc(int key)
    {
        int index = key % 100;
        return index;
    }
    //查询操作。
    public string? Get(int key)
    {
        int index = HashFunc(key);
        Pair? pair = buckets[index]; //先借助buckets[index]造出一个Pair实例来。
        if (pair == null) return null; //处理如果Pair实例 为空的情况。
        return pair.val;
    }
    //添加操作。
    public void Put(int key, string value) //本Put()没有处理当buckets在index位置已存储Pair实例的情况，本意是在本例中当发生哈希冲突时直接覆盖旧值。
    {
        Pair pair = new Pair(key, value);
        int index = HashFunc(key);
        buckets[index] = pair;
    }
    //删除操作。
    public void Remove(int key)
    {
        int index = HashFunc(key);
        buckets[index] = null;
    }
    //获取所有键值对。
    public List<Pair> PairSet() //本方法的作用就是遍历哈希表中的所有桶，将非 null 的 Pair 实例集中收集到一个列表中，并返回这个列表。对于空值（null），它直接跳过，忽略处理。这种设计在实现上是很常见的。
    {
        List<Pair> pairSet = new List<Pair>();
        foreach (Pair? pair in buckets)
        {
            if (pair != null)
            {
                pairSet.Add(pair);
            }
        }
        return pairSet;
    }
    // 获取所有键。//原理同PairSet()。
    public List<int> KeySet()
    {
        List<int> keySet = new List<int>();
        foreach (Pair? pair in buckets)
        {
            if (pair != null)
            {
                keySet.Add(pair.key);
            }
        }
        return keySet;
    }
    //获取所有值。//原理同PairSet()。
    public List<string> ValueSet()
    {
        List<string> valueSet = new List<string>();
        foreach (Pair? pair in buckets)
        {
            if (pair != null)
            {
                valueSet.Add(pair.val);
            }
        }
        return valueSet;
    }
    //打印哈希表。
    public void Print()
    {
        foreach (Pair kv in PairSet()) //是从PairSet()拿取数据来打印的，PairSet()就确定里面都是非空Pair实例了。
        {
            Console.WriteLine(kv.key + "->" + kv.val);
        }
    }
}
*、