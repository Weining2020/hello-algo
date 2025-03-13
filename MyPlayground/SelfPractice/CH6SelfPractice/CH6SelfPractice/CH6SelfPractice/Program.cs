using CH6SelfPractice.utils;

public class ArrayHashMap
{
    int size;
    int capacity;
    double loadFactor;
    int extendRatio;
    List<List<Pair>> buckets;
    public ArrayHashMap()
    {
        size = 0;
        capacity = 100;
        loadFactor = 3.0 / 4.0;
        extendRatio = 2;
        buckets = new List<List<Pair>> ();
        for (int i = 0; i < 100; i++)
        {
            buckets.Add (new List<Pair> ());
        }
    }

    int HashFunc(int key)
    {
        return key % capacity;
    }
    //查询现在的负载因子。
    double LoadFactor()
    {
        return (double) size / capacity;
    }
    public string? Get(int key)
    {
        int index = HashFunc(key);
        foreach (var pair in buckets[index])
        {
            if (pair.key == key)
            {
                return pair.val;
            }
        }
        return null;
    }
    public void Put(int key, string val)
    {
        if (LoadFactor() > loadFactor)
        {
            Extend();
        }
    }
    public void Extend()
    {
        List<List<Pair>> tempBuckets = buckets;
        buckets = new List<List<Pair>>();
        capacity *= extendRatio;
        buckets = Enumerable.Range(0, capacity).Select(_ => new List<Pair>()).ToList();
        size = 0;
        foreach (var bucket in tempBuckets)
        {
            foreach (var pair in bucket)
            {
                Put(pair.key, pair.val);
            }
        }
    }
}
