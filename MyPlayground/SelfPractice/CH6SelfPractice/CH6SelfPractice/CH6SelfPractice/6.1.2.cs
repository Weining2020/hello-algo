/*

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

public class ArrayHashMap
{
    public List<Pair?> buckets;
    public ArrayHashMap()
    {
        buckets = new List<Pair?>();
        for (int i = 0; i < 100; i++)   //这好像是直接把空Pair实例放入buckets的尾部吧？这不是正常的初始化吧？
        {
            buckets.Add(null);
        }
    }
    
    //哈希函数hash function。
    public int HashFun(int key)
    {
        return key % 100;
    }
    //查询。
    public string? Find(int key)
    {
        int index = HashFun(key);
        return buckets[index]?.val;
    }
    //添加。
    public void Put(int key, string val)
    {
        Pair pair = new Pair(key, val);
        int index = HashFun(key);
        buckets[index] = pair;
    }
    //移除。
    public void Remove(int key)
    {
        int index = HashFun(key);
        buckets[index] = null;
    }
    //3个返回。
    public List<Pair> GetPairs()
    {
        List<Pair> list = new List<Pair>();
        foreach (var pair in buckets)
        {
            if (pair!= null)
            {
                list.Add(pair);
            }
        }
        return list;
    }
    public List<int> GetKeys()
    {
        List<int> list = new List<int>();
        foreach (var pair in buckets)
        {
            if (pair != null)
            {
                list.Add(pair.key);
            }
        }
        return list;
    }
    public List<string> GetValues()
    {
        List<string> list = new List<string>();
        foreach (var pair in buckets)
        {
            if (pair != null)
            {
                list.Add(pair.val);
            }
        }
        return list;
    }
    //遍历打印。
    public void Print()
    {
        List<Pair> list = GetPairs();
        foreach (var pair in list)
        {
            Console.WriteLine(pair.key + "->" + pair.val);
        }
    }
}
*/