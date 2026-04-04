using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewPlayground.Class.CH6
{
    internal class _621
    {
        /*
        public class Pair
        {
            public int key;
            public string val;
            public Pair(int k, string v)
            {
                key = k;
                val = v;
            }
        }

        public class HashMapChaining
        {
            int size;
            int capacity;
            double loadThres;
            int extendRatio;
            List<List<Pair>> buckets;

            public HashMapChaining()
            {
                size = 0;
                capacity = 4;
                loadThres = 2.0 / 3.0;
                extendRatio = 2;
                buckets = new List<List<Pair>>(capacity);
                for (int i = 0; i < capacity; i++)
                {
                    buckets.Add([]);
                }
            }

            int HashFunc(int k)
            {
                return k % capacity;
            }

            double LoadFactor()
            {
                return (double)size / capacity;
            }

            public string? Get(int k)
            {
                int index = HashFunc(k);
                foreach (Pair pair in buckets[index])
                {
                    if (pair.key == index)
                    {
                        return pair.val;
                    }
                }
                return null;
            }

            public void Put(int k, string v)
            {
                if (LoadFactor() > loadThres)
                {
                    Extend();
                }

                int key = HashFunc(k);
                foreach (Pair pair in buckets[key])
                {
                    if (pair.key == key)    //注意！！这里不要写错成“pair.key == index”,那样写不对！
                    {
                        pair.val = v;
                        return;
                    }
                }
                buckets[key].Add(new Pair(k, v));
                size++;
            }

            public void Remove(int k)
            {
                int index = HashFunc(k);
                foreach (Pair pair in buckets[index].ToList())
                {
                    if (pair.key == k)
                    {
                        buckets[index].Remove(pair);    //这里使用了Remove()来从列表中移除元素，参数是该元素，而不是该元素的索引。在列表的Remove()方法，明确说了只移除第一个匹配到的元素。
                    }
                    size--;
                    return;
                }
                //如果没找到，就啥也不做直接return。
            }

            void Extend()
            {
                List<List<Pair>> bucketsTmp = buckets;
                capacity = capacity * extendRatio;
                buckets = new List<List<Pair>>(capacity);
                for (int i = 0; i < capacity; i++)
                {
                    buckets.Add([]);
                }
                size = 0;
                foreach (List<Pair> bucket in bucketsTmp)
                {
                    foreach (Pair pair in bucket)
                    {
                        Put(pair.key, pair.val);
                    }
                }
            }

            public void Print()
            {
                List<string> res = [];
                foreach (List<Pair> bucket in buckets)
                {
                    foreach (Pair pair in bucket)
                    {
                        res.Add(pair.key + "-" + pair.val);
                    }
                }

                foreach (string item in res)
                {
                    Console.WriteLine(item);
                }
            }
        }
        */
    }
}
