using CH6SelfPractice.utils;
using System.IO.Pipes;

public class HashMapChaining
{
    int size;
    int capacity = 4;
    int extendRatio = 2;
    double loadThres = 3.0 / 4.0;
    List<List<Pair>> buckets;

    public HashMapChaining()
    {
        size = 0;
        buckets = new List<List<Pair>>();
        for (int i = 0; i < capacity; i++)
        {
            buckets.Add(new List<Pair>());
        }
    }

    public int HashFunc(int key)
    {
        return key % capacity;
    }
    public double LoadFactor()
    {
        return (double)size / capacity;
    }
    public string? Get(int key, string value)
    {
        int index = HashFunc(key);
        foreach (Pair pair in buckets[index])
        {
            if (pair.key == key)
            {
                return pair.val;
            }
        }
        return null;
    }
    public void Put(int key, string value)
    {
        if (LoadFactor() > loadThres)
        {
            Extend();
        }
        int index = HashFunc(key);
        foreach (Pair pair in buckets[index])
        {
            if (pair.key == key)
            {
                pair.val = value;
                return;
            }
        }
        buckets[index].Add(new Pair(key, value));
        size++;
    }
    public void Remove(int key)
    {
        int index = HashFunc(key);
        foreach (Pair pair in buckets[index].ToList())
        {
            if (pair.key == key)
            {
                buckets[index].Remove(pair);
                size--;
                return;
            }
        }
    }
    //public void Extend()
    //{
    //    List<List<Pair>> tempBuckets = new List<List<Pair>>();
    //    capacity *= extendRatio;
    //    size = 0;
    //    foreach (List<Pair> bucket in buckets)
    //    {
    //        List<Pair> newBucket = new List<Pair>();
    //        foreach (Pair pair in bucket)
    //        {
    //            if (pair != null)
    //            {
    //                newBucket.Add(pair);
    //                size++;
    //            }
    //        }
    //        tempBuckets.Add(newBucket);
    //    }
    //}
    public void Extend()
    {
        List<List<Pair>> tempBuckets = buckets;
        capacity *= extendRatio;
        buckets = new List<List<Pair>>(capacity);
        for (int i = 0; i < capacity; i++)
        {
            buckets.Add(new List<Pair>());
        }
        size = 0;

        foreach (var bucket in tempBuckets)
        {
            foreach (var pair in bucket)
            {
                Put(pair.key, pair.val);
            }
        }
    }
    public void Print()
    {
        foreach (var bucket in buckets)
        {
            List<string> res = new List<string>();
            foreach (var pair in bucket)
            {
                res.Add(pair.key + "->" + pair.val);
            }
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}