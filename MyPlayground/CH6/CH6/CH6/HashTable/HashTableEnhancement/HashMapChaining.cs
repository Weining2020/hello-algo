/*
using System.Runtime.CompilerServices;

Console.OutputEncoding = System.Text.Encoding.UTF8; // 设置控制台为 UTF-8，这样我的Console才能正常打印出汉字。

//链式地址哈希表。
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
public class HashMapChaining
{
    int size;
    int capacity;
    double loadThres;
    int extendRatio;
    List<List<Pair>> buckets;

    //构造方法。
    public HashMapChaining()
    {
        size = 0;
        capacity = 4;
        loadThres = 2.0 / 3.0;
        extendRatio = 2;
        buckets = new List<List<Pair>>(); //先显式地声明出buckets是什么类型的实例。这段代码用的是 List<T>(int capacity) 构造函数，而不是 IEnumerable<T> 构造函数。作用是创建了一个空的 List<List<Pair>>，其中：实际元素数量为 0。底层数组容量为 capacity（即分配了存储 capacity 个 List<Pair> 的空间）。提高了效率，提前分配大块连续内存，避免后续动态分配时的内存碎片化问题。即使指定了 capacity，你仍需要手动为每个桶添加 List<Pair>，因为 capacity 只影响底层数组的大小，Count 仍然是 0。
        //注意！！下面如果不想用for loop的形式给buckets每个元素初始化，也可以使用LINQ写法。buckets = new List<List<Pair>>(Enumerable.Range(0, capacity).Select(_ => new List<Pair>())); 这个写法有点高端啊。
        for (int i = 0; i < capacity; i++) //buckets内部每个元素都是 List<Pair>，一共有capacity个 List<Pair>列表。
        {
            buckets.Add(new List<Pair>()); //我有过疑问为什么这里不像C:\Users\LZLZL\OneDrive\文档\GitHub\hello-algo\MyPlayground\CH6\CH6\CH6\HashTable\HashTableImplementation\ArrayHashMap.cs文件（这文件是我自己写的实现，与教程存在些微不同）中构造器里对buckets初始化时借助new Pair?[capacity]。原因是 这里的buckets的每个元素是List列表而不是单独的Pair实例。既然每个元素是个List列表，那也无需具体地显式地初始化每个列表了，b/c列表是可变的。
        }
    }
    //哈希函数。
    int HashFunc(int key)
    {
        return key % capacity;
    }
    //负载因子。//这方法是 动态计算当前的负载因子值并返回。不是返回loadThres!!
    double LoadFactor()
    {
        return (double)size / capacity;
    }
    //查询操作。
    public string? Get(int key)
    {
        int index = HashFunc(key);
        foreach (Pair pair in buckets[index]) //buckets[index]会得到一个列表List<Pair>, 然后我们遍历试图这个列表找到返回值。
        {
            if(pair.key == key) return pair.val; //由于哈希函数只能确保键映射到正确的桶，但桶内可能有多个键值对，因此需要通过遍历桶中的链表进行进一步匹配。
            //Question:为什么在桶（即本例的每个List<Pair>）中，依然用用户输入的key值来遍历判断是否匹配？
            //答：所以哈希表本质是，最好情况是每个键值对都单独放在哈希表底层列表的一个index上，这样我们直接按照用户输入key值由哈希函数转换成index值来访问键值对就行了。但是因为我们在用链式地址改进哈希表，每个键值对（即Pair实例）的key都是不同的，可多个键值对的key可能对应哈希算法得出的同个index值，因此我们由index值锁定桶后，还是要用 用户输入的key值在Pair list中遍历查找用户需要的Pair实例。之所以还用 用户输入的key值来遍历，是因为key值对于Pair实例永远起作用，在某个桶中所有的键值对的键都是不同的，所有的键值对的键只是刚好对应这个桶而已，所以用key值来遍历 同个桶中的不同Pair实例 是可行的。
        }
        return null;
    }
//添加操作。
    public void Put(int key, string value) //我写的和教程有些微区别，但是也是对的。
    {
        if (LoadFactor() > loadThres)
        {
            Extend();
        }
        int index = HashFunc(key);
        foreach (Pair p in buckets[index])
        {
            if(p.key == key)
            {
                p.val = value;
                return;
            }
            
        }
        Pair pair = new Pair(key, value); //把这行代码放在这里而不是foreach之前，因为foreach如果能做到 更新操作，那没必要执行新Pair实例的创建了，因此放在这里更合理。
        buckets[index].Add(pair);
        size++;
    }
    //删除操作。
    public void Remove(int key)
    {
        int index = HashFunc(key);
        // 遍历桶，从中删除键值对
        foreach (Pair pair in buckets[index].ToList()) //调用 ToList() 方法生成链表的副本，主要是为了在遍历 List 时对原链表进行修改（例如删除元素）时，避免出现**"并发修改异常"**（InvalidOperationException），即 C#不允许在用foreach遍历一个集合对象时同时修改集合对象中元素，因为这可能使迭代器变得不可预测。即我们的解决方法是生成副本，遍历副本，根据条件在副本中找到目标后修改原集合中的目标，然后继续遍历副本寻找下个目标。
        {
            if (pair.key == key)
            {
                buckets[index].Remove(pair);
                size--;
                break; //使用 break 提前终止循环，因为目标键值对最多只会出现一次。在这用return也行。
            }
        }
    }
    //扩容哈希表。
    void Extend()
    {
        //注意！！我们无法通过一个foreach loop的newBuckets[i] = buckets[i]来实现搬运，b/c newBuckets这个变量只是刚创建出来，内部的每个元素（即每个list）都没被实例化，刚创建的 newBuckets 是一个空的 List，其 Count == 0，尝试通过索引访问 newBuckets[i] 会抛出 ArgumentOutOfRangeException，因为 List 中没有初始化的元素。因此我们最终选择了教程的写法。
        List<List<Pair>> tempBuckets = this.buckets;
        capacity *= extendRatio;
        buckets = new List<List<Pair>>(capacity);
        for (int i = 0; i < capacity; i++)
        {
            buckets.Add(new List<Pair>()); //同样的初始化newBuckets每个桶，就像构造函数里讲过的一样。
        }
        size = 0; //在扩容时，教程代码中通过调用 Put() 方法将旧哈希表中的键值对重新插入到新哈希表中。在此过程中，Put() 方法会自动增加 size 的值。因此，在扩容之前将 size 重置为 0 是为了确保扩容后，size 的值能够正确反映新哈希表中实际存储的键值对数量。
        foreach (List<Pair> bucket in tempBuckets)
        {
            foreach (Pair pair in bucket)
            {
                Put(pair.key, pair.val);
            }
        }
    }
    //打印哈希表。//我写的Print()是嵌套foreach直接输出，教程多了一步收集是将所有键值对先存入列表 res 后再统一输出，方便扩展，比如如果后续需要对结果进行排序、过滤或其他处理，只需操作 res 即可。最终选择了教程的写法。
    public void Print()
    {
        foreach (List<Pair> bucket in buckets)
        {
            List<string> res = new List<string>();
            foreach (Pair pair in bucket)
            {
                res.Add(pair.key + "->" + pair.val);
            }
            foreach (string kv in res)
            {
                Console.WriteLine(kv);
            }
        }
    }

}
*/