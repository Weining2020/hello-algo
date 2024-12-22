
//开放寻址哈希表。底层是环形数组。这不是在用链式地址来改进哈希表，忘掉链式地址改进哈希表用的 List<List<Pair>>结构吧！跟这无关。
public class Pair //我写在这防止报错。
{
    public int key;
    public string val;
    public Pair(int key, string value)
    {
        key = key;
        val = value;
    }
}
public class HashMapOpenAddressing
{
    int size;
    int capacity = 4;
    double loadThres = 2.0 / 3.0;
    int extendRatio = 2;
    Pair[] buckets; //底层用的是Pair数组，即我们追求不同的key（即使有可能对应同一哈希值）的键值对，应存放在Pair数组的不同index上。
    Pair TOMBSTONE = new Pair(-1, "-1"); //TOMBSTONE字段依然是一个Pair实例，只是其中保存很离谱的值以警示这是个TOMBSTONE而不是有效有意义的的Pair实例，比如这里-1 和 "-1" 是人为设定的特殊值，表示这是一个占位键值对，并没有实际的意义，纯粹是为了标记那些已经被删除的槽位。
    //构造方法。
    public HashMapOpenAddressing()
    {
        size = 0; //别忘了一开始size是0。
        buckets = new Pair[capacity];
    }
    //哈希函数。
    int HashFunc(int key)
    {
        return key % capacity;
    }
    //负载因子。
    double LoadFactor()
    {
        return (double)size / capacity;
    }
    //搜索 key 对应的桶索引。
    //FindBucket() 的目的是在哈希表中找到指定 key 的正确位置。这包括以下两种情况: 第一种，查找现有的键值对：如果指定的 key 已经存在于哈希表中，它会返回这个键值对所在的索引（桶的位置）。第二种，确定插入位置：如果指定的 key 不存在于哈希表中，它会返回一个合适的插入位置（桶的位置）。
    //这个方法非常的复杂，需要多思考，很难。
    int FindBucket(int key) //对整个FindBucket()方法做个总结：如果目标键值对存在，FindBucket() 返回其索引。如果目标键值对不存在，FindBucket() 返回一个适合插入的索引（null 或 TOMBSTONE 的位置）。
    {
        int index = HashFunc(key);
        int firstTombstone = -1;
        // 线性探测，当遇到空桶时跳出
        while (buckets[index] != null)
        {
            // 若遇到 key ，返回对应的桶索引
            if (buckets[index].key == key)
            {
                // 若之前遇到了删除标记，则将键值对移动至该索引处。//目的是，如果在找到对应的桶之前，我们曾碰到过TOMBSTONE，则应该把我们找到的目标键值对放到TOMBSTONE所在的索引位置，因为这样做之后，以后的其他操作效率会更高（即目标值离合理的索引位置更接近了）。
                if (firstTombstone != -1)
                {
                    buckets[firstTombstone] = buckets[index]; //把以前发现的TOMBSTONE所在索引处的Pair实例换成我们找到的目标Pair实例。
                    buckets[index] = TOMBSTONE; //把我们找到的目标Pair实例所在索引处的Pair实例换成TOMBSTONE。相当于是完成了TOMBSTONE和目标Pair实例的位置互换。
                    return firstTombstone; // 返回移动后的桶索引。//没错因为我们做了交换，所以在交换之后，原TOMBSTONE所在索引成了 现在目标Pair实例所在索引，因此返回原TOMBSTONE所在索引 即是在 返回现在目标Pair实例所在索引。
                }
                return index; // 返回桶索引。//如果之前没有碰到过TOMBSTONE，当然直接返回我们找到的目标Pair实例所在的索引值，b/c TOMBSTONE压根没参与。
            }
            // 记录遇到的首个删除标记。//这里的意思是，在找目标Pair实例的过程中（过程中，即还没找到），记录遇到的TOMBSTONE。在开放寻址法中，由于探测路径可能会跨越多个槽位（桶），所以有可能多次遇到 TOMBSTONE。但是，在 FindBucket() 中，只记录第一个 TOMBSTONE 的位置，后续遇到的 TOMBSTONE 将被忽略。新的键值对（即把目标键对值挪到TOMBSTONE所在位置）只会占用一个槽位，因此只需要记录第一个可以复用的 TOMBSTONE。
            if (firstTombstone == -1 && buckets[index] == TOMBSTONE)
            { //第一个条件， =-1，保证了firstTombstone没被挪过。第二个条件，即表示了我们在找目标Pair实例过程中遇到了TOMBSTONE。
                firstTombstone = index; //使firstTombstone记录下这个可以被目标Pair实例占据的 可用槽位。
            }
            // 计算桶索引，越过尾部则返回头部
            index = (index + 1) % capacity; //这种越过尾部返回头部继续遍历的情况确实有，继续执行代码就是了，最坏的情况就是本来全部的索引位置上都有有效Pair实例，无法找到一个buckets[index] == null的index来停止while循环，因此程序陷入死循环，其实这种情况肯定也触发了 负载因子过高而执行扩容，因此这个情况不会真实发生。
        }
        // 若 key 不存在，则返回添加点的索引。//即 如果在整个探测路径中没有遇到 TOMBSTONE（firstTombstone 依然== -1），则返回当前的 index，也就是第一个空桶（没碰到TOMBSTONE就代表没碰到过空桶）的位置，作为可以插入的索引（因为此时一定满足了buckets[index] == null, 即index索引对应的Pair实例必为空，不然没法跳出while循环）。如果在探测路径中遇到过 TOMBSTONE（firstTombstone != -1），则优先返回第一个 TOMBSTONE 的位置（即此时firstTomstone的值就是第一个TOMBSTONE的值，b/c之前一定在碰到第一个TOMBSTONE时把firstTombstone的值更新了），作为插入点的索引。
        return firstTombstone == -1 ? index : firstTombstone;
    }
    //查询操作。
    public string? Get(int key) //真巧妙啊。
    {
        int index = FindBucket(key);
        // 根据 FindBucket(key) 返回的索引 index，我们可以访问 buckets[index]。
        // 根据 FindBucket() 的逻辑，buckets[index] 有以下三种可能的值：

        // 1. buckets[index] == null:
        //    - 当前索引位置是空槽，可以用于插入新 Pair 实例。
        //    - 说明哈希表中没有找到用户要查找的目标键值对。

        // 2. buckets[index] == TOMBSTONE:
        //    - 当前索引位置之前存储过一个键值对，但该键值对已经被删除。至于为什么说明该键值对已经被删除，原因是TOMBSTONE所在的位置必是原来的键值对已经被删除，b/c这是TOMBSTONE的来源，键值对被删除会留下TOMBSTONE。
        //    - 查找时需要跳过该位置，继续探测路径。
        //    - 说明哈希表中没有找到用户要查找的目标键值对。

        // 3. buckets[index] 是一个有效的 Pair:
        //    - 当前索引位置存储着一个有效的键值对。
        //    - 如果此键值对的 key 与用户输入的 key 相同，则找到了目标键值对。

        if (buckets[index] != null && buckets[index] != TOMBSTONE) //这个if的原理是，排除三种情况之二，剩下的一种情况会出目标值。之所以没判断buckets[index].key == key，是因为FindBucket() 方法本身 已经处理了 buckets[index].key == key 的判断，我想过了我很确定当buckets[index]是个有效键值对时，这就是我们要找的那个键对值，这是通过研究FindBucket()方法得出的结论，只有在if (buckets[index].key == key)这个block中的两个return才能出现让FindBucket()返回一个用户输入key被找到的桶索引。这里的if逻辑就是用来判断 buckets[index] 是否是一个有效的键值对。
        {
            return buckets[index].val;
        }
        return null; //很有必要，比如buckets[index] == null 的情况，即哈希表中找不到目标值，那就应该返回null啊。我让ChatGPT举例给我展示了这种情况。
    }
    //添加操作。
    public void Put(int key, string val)
    {
        // 当负载因子超过阈值时，执行扩容
        if (LoadFactor() > loadThres)
        { //别忘了检查是否需要扩容。
            Extend();
        }
        // 搜索 key 对应的桶索引
        int index = FindBucket(key);
        // 若找到键值对，则覆盖 val 并返回
        if (buckets[index] != null && buckets[index] != TOMBSTONE)
        { //这里是在处理index索引位置上有 有效键值对的情况，直接替换值就行了。
            buckets[index].val = val;
            return; //别忘了在这里返回。
        }
        // 若键值对不存在，则添加该键值对
        buckets[index] = new Pair(key, val); //把新的Pair实例添加在index位置。这里是在处理buckets[index]为空的情况（即不满足if的情况），需要插入新的键值对。
        size++; //别忘了size也要增加。
    }
    //删除操作。
    public void Remove(int key) //在开放寻址哈希表中，删除操作的核心挑战是不能简单地将槽位设置为 null，否则可能破坏探测路径，导致查找和插入操作出现问题。因此，删除操作会使用特殊的占位标记（TOMBSTONE）来表示被删除的槽位。
    //Remove()方法本质不是删除一个键值对，而是把目标键值对索引那里标记成已删除，即TOMBSTONE。
    {
        int index = FindBucket(key);
        if (buckets[index] != null && buckets[index] != TOMBSTONE)
        {
            buckets[index] = TOMBSTONE; // 将该槽位标记为已删除。
            size--; //别忘了size要减少。
        }
        //在 Remove() 方法中，确实没有显式处理 else 分支的情况。这是因为 不满足 if 条件的情况并不需要额外处理。如果 buckets[index] == null，说明目标键 key 根本不存在于哈希表中，因此不需要任何删除操作。如果 buckets[index] == TOMBSTONE，说明目标键 key 不在这个槽位，同样无需操作。只有在当前槽位存储了一个有效的键值对时（即 buckets[index] != null && buckets[index] != TOMBSTONE），才需要删除该键值对，将其标记为 TOMBSTONE。
    }
    //扩容哈希表。
    void Extend()
    {
        Pair[] tempBuckets = buckets;
        capacity *= extendRatio;
        buckets = new Pair[capacity];
        size = 0; //别忘了size一开始是0，后面由Put()来改变size值。
        foreach (Pair pair in tempBuckets) //这里没写Pair？是没事的，往下看。
        {
            if (pair != null && pair != TOMBSTONE) //这里的if是处理有效键值对，排除了TOMBSTONE和null的情况。
            {
                Put(pair.key, pair.val);
            }
        }
    }
    //打印哈希表。
    public void Print()
    {
        foreach (Pair pair in buckets)
        {
            if(pair == null)
            {
                Console.WriteLine("null");
            }
            else if (pair == TOMBSTONE)
            {
                Console.WriteLine("TOMBSTONE");
            }
            else
            {
                Console.WriteLine(pair.key + "->" + pair.val);
            }
        }
    }

}
*/