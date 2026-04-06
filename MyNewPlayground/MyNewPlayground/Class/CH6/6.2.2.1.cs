using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH6
{
    internal class _6221
    {
        /*
public class Pair
{
    public int Key;
    public string Value;
    public Pair(int k, string v)
    {
        Key = k; Value = v;
    }
}
public class HashMapOpenAddressing
{
    int size;
    int capacity = 4;
    double loadThres = 2.0 / 3.0;
    int extendRatio = 2;
    Pair[] buckets;
    Pair TOMBSTONE = new Pair(-1, "-1");

    public HashMapOpenAddressing()
    {
        size = 0;
        buckets = new Pair[capacity];
    }

    int HashFunc(int k)
    {
        return k % capacity;
    }

    double LoadFactor()
    {
        return (double) size / capacity;
    }

    int FindIndex(int k)
    {
        int index = HashFunc(k);
        int firstTombstone = -1;
        while (buckets[index] != null)
        {
            if (buckets[index].Key == k)    //真的找到了目标元素
            {
                if (firstTombstone != -1)   //以前碰到过墓碑。
                {
                    buckets[firstTombstone] = buckets[index];
                    buckets[index] = TOMBSTONE;
                    return firstTombstone;
                }
                else //以前没碰到过墓碑。
                {
                    return index;
                }
            }

            if (firstTombstone == -1 && buckets[index] == TOMBSTONE)
            {
                firstTombstone = index;
            }

            index = (index + 1) % capacity;
        }

        //撞到了null桶（不是撞到了墓碑）正常退出了while循环。说明找不到目标元素，那就返回可用index。
        return firstTombstone == -1 ? index : firstTombstone;
    }

    public string? Get(int k)
    {
        int index = FindIndex(k);
        if (buckets[index] != TOMBSTONE && buckets[index] != null)
        {
            return buckets[index].Value;
        }
        else
        {
            return null;
        }
    }
    public void Put(int k, string v)
    {
        if(LoadFactor() > loadThres)
        {
            Extend();
        }

        int index = FindIndex(k);
        if (buckets[index] != TOMBSTONE && buckets[index] != null)
        {
            buckets[index].Value = v;
            return;
            //这里不需要增加size，我自己写时写错了。
        }
        else
        {
            Pair pair = new Pair(k, v);
            buckets[index] = pair;
            size++;
        }
    }

    public void Remove(int k)
    {
        int index = FindIndex(k);
        if (buckets[index] != TOMBSTONE && buckets[index] != null)
        {
            buckets[index] = TOMBSTONE;
            size--;
        }
    }

    public void Extend()
    {
        capacity *= extendRatio;
        Pair[] bucketsTmp = buckets;
        buckets = new Pair[capacity];
        size = 0;
        foreach (var pair in bucketsTmp)
        {
            if (pair != null && pair != TOMBSTONE)
            {
                Put(pair.Key, pair.Value);
            }
        }
    }

    public void Print()
    {
        foreach (Pair pair in buckets)
        {
            if (pair == null)
            {
                Console.WriteLine("null");
            }
            else if (pair == TOMBSTONE)
            {
                Console.WriteLine("TOMBSTONE");
            }
            else
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
*/

    }
}
