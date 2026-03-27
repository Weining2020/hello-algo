using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH6
{
    internal class _612
    {/*
//键值对 int->string
public class Pair
{
    public int key;
    public string val;
    public Pair(int key, string val)
    {
        this.key = key;
        this.val = val;
    }
}
//基于数组实现的哈希表
public class ArrayHashMap
{
    List<Pair?> buckets; //哈希表初始化时，大多数桶是空的——没有任何键值对存进来。这个"空"必须用某种方式表达：如果用 List<Pair?>（可空），槽位可以是 null，完美表达"空桶"这个语义 ✅.所以 List<Pair?> 的完整语义是："一个列表，其中每个元素可以是一个 Pair 对象，也可以是 null"。
    public ArrayHashMap()
    {
        buckets = [];
        // 初始化数组，包含 100 个桶
        for (int i = 0; i < 100; i++)
        {
            buckets.Add(null); //显式地初始化成null，代表空桶。
        }
    }

    //哈希函数
    public int HashFunc(int key)
    {
        return key % 100;
    }

    //查询操作
    public string? Get(int key)
    {
        int index = HashFunc(key);
        Pair? pair = buckets[index];
        if (pair == null)
        {
            return null;
        }
        return pair.val;
    }

    //添加操作
    public void Put(int key, string val)
    {
        Pair pair = new Pair(key, val);
        int index = HashFunc(key);
        buckets[index] = pair;
    }

    public void Remove(int key)
    {
        int index = HashFunc(key);
        // 置为 null ，代表删除
        buckets[index] = null;  //绝不可以用buckets.RemoveAt()。本例中，buckets本质是数组，删除一个index会导致这个槽破坏，后续所有槽都改变了位置，整体结构被破坏。
    }

    //获取所有键值对
    public List<Pair> PairSet()
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

    //获取所有键
    public List<int> KeySet()
    {
        List<int> keySet = [];
        foreach (Pair? pair in buckets)
        {
            if (pair != null)
            {
                keySet.Add(pair.key);
            }
        }
        return keySet;
    }

    //获取所有值
    public List<string> ValueSet()
    {
        List<string> valueSet = [];
        foreach (Pair? pair in buckets)
        {
            if (pair != null)
            {
                valueSet.Add(pair.val);
            }
        }
        return valueSet;
    }

    //打印哈希表
    public void Print()
    {
        foreach (Pair kv in PairSet())
        {

            Console.WriteLine(kv.key + "->" + kv.val);
        }
    }
}
*/
    }
}
