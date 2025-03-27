/*
using CH6SelfPractice.utils;

public class HashMapOpenAdressing
{
    int size;
    int capacity = 4;
    double loadThres = 3.0 / 4.0;
    int extendRatio = 2;
    Pair[] buckets;
    Pair TOMBSTONE = new Pair(-1, "-1");
    public HashMapOpenAdressing()
    {
        buckets = new Pair[capacity];
        size = 0;
    }
    public double LoadFactor()
    {
        return (double)size / capacity;
    }
    public int HashFunc(int key)
    {
        return key % capacity;
    }
    public int FindBucket(int key)
    {
        int index = HashFunc(key);
        int firstTombstone = -1;
        while (buckets[index] != null)  //遍历buckets时只要不碰到null值，就一直遍历；当碰到null值，停止遍历。
        {
            if (buckets[index] == TOMBSTONE && firstTombstone == -1)
            {
                firstTombstone = index;
            }

            if (buckets[index].key == key)
            {
                if (firstTombstone != -1)
                {
                    buckets[firstTombstone] = buckets[index];
                    buckets[index] = TOMBSTONE;
                    return firstTombstone;
                }
                else
                {
                    return index;
                }
            }

            index = (index + 1) % capacity;
        }

        return firstTombstone == -1 ? index : firstTombstone;
    }
    public void Put(int key, string val)
    {
        if (LoadFactor() > loadThres)
        {
            Extend();
        }
        int index = FindBucket(key);
        if (buckets[index] != TOMBSTONE && buckets[index] != null)
        {
            buckets[index].val = val;
        }
        else
        {
            buckets[index] = new Pair(key, val);
            size++;
        }
    }
    public string? Get(int key)
    {
        int index = FindBucket(key);
        if (buckets[index] != TOMBSTONE && buckets[index] != null)
        {
            return buckets[index].val;
        }
        else
        {
            return null;
        }
    }
    public void Remove(int key)
    {
        int index = FindBucket(key);
        if (buckets[index] != TOMBSTONE && buckets[index] != null)
        {
            buckets[index] = TOMBSTONE;
            size--;
        }
    }
    public void Print()
    {
        foreach (Pair pair in buckets)
        {
            if (pair == TOMBSTONE)
            {
                Console.WriteLine("TOMBSTONE");
            }
            else if (pair == null)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                Console.WriteLine(pair.key + "->" + pair.val);
            }
        }
    }
    public void Extend()
    {
        Pair[] tempBuckets = buckets;
        capacity *= extendRatio;
        buckets = new Pair[capacity];
        size = 0;
        foreach (Pair pair in tempBuckets)
        {
            if (pair != TOMBSTONE && pair != null)
            {
                Put(pair.key, pair.val);
            }
        }
    }

}
*/